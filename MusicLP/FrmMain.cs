using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MusicLP
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        OpenFileDialog ofd = new OpenFileDialog();
        public FrmMain()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Replace(@"bin\Debug", "Data"));


            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB; " +
                @"AttachDbFilename = |DataDirectory|music.mdf;");

            InitializeComponent();

            tbSearch.TextChanged += Search;
        }

        private void Search(object sender, EventArgs e)
        {
            dgvTracks.Rows.Clear();

            conn.Open();

            var cmd = new SqlCommand(
                "SELECT Tracks.title, length, url, album, Tracks.id FROM Tracks INNER JOIN Albums " +
                "ON Tracks.album = Albums.id " +
                $"WHERE Albums.title LIKE '{cbAlbum.SelectedItem}' " +
                $"AND Tracks.title like '%{tbSearch.Text}%';", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgvTracks.Rows.Add(r[0], r[1], r[2], r[3], r[4]);
            }
            conn.Close();
        }

        private void BtnDisco_Click(object sender, EventArgs e)
        {

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(ofd.FileName);
                    string sor = sr.ReadLine();
                    bool track = false;

                    while ((sor = sr.ReadLine()) != null)
                    {
                        if (sor.Contains("[tracks]"))
                        {
                            track = true;
                        }
                        else if (track == false)
                        {
                            string[] spl = sor.Split(';');

                            conn.Open();
                            var cmd = new SqlCommand(
                                "INSERT INTO Albums VALUES " +
                                $"('{spl[0]}', '{spl[1]}', '{spl[2]}', '{spl[3]}');", conn);
                            var r = cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        else
                        {
                            string[] spl = sor.Split(';');

                            conn.Open();
                            var cmd = new SqlCommand(
                                "INSERT INTO Tracks (title, length, album, url) VALUES " +
                                $@"('{spl[0]}', '00:{spl[1]}', '{spl[2]}', '{spl[3]}');", conn);
                            var r = cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("The file structure is incorrect or has already been uploaded.");
                }
            }

            Application.Restart();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ofd.Filter = "Text Files (.txt)| *.txt";

            FillcbArtist();
        }

        private void FillcbArtist()
        {
            conn.Open();

            var cmd = new SqlCommand(
                "SELECT artist FROM Albums " +
                "GROUP BY artist;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbArtist.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void CbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcbAlbum();
        }

        private void FillcbAlbum()
        {
            cbAlbum.Enabled = true;

            conn.Open();

            var cmd = new SqlCommand(
                "SELECT title FROM Albums " +
                $"WHERE artist LIKE '{cbArtist.SelectedItem}';", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbAlbum.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void CbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImagepbAlbum();
            FillrtbAlbum();
            FilldgvTracks();
        }

        private void ImagepbAlbum()
        {
            string filepath = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources");

            conn.Open();

            var cmd = new SqlCommand(
               "SELECT id FROM Albums " +
               $"WHERE title LIKE '{cbAlbum.SelectedItem}';", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                Image im = Image.FromFile(filepath + $@"\{r[0]}.jpg");
                pbAlbum.Image = im;
                pbAlbum.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            conn.Close();
        }

        private void FillrtbAlbum()
        {
            rtbAlbumDatas.Clear();

            conn.Open();

            var cmd = new SqlCommand(
               "SELECT release, " +
               "CONVERT(TIME, DATEADD(s, SUM(( DATEPART(mi, length) * 60 ) + DATEPART(ss, length)), 0)) " +
               "FROM Albums INNER JOIN Tracks " +
               "ON Albums.id = album " +
               $"WHERE Albums.title LIKE '{cbAlbum.SelectedItem}' " +
               $"GROUP BY release;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                rtbAlbumDatas.Text +=
                    "Release: " + r.GetDateTime(0).ToString("yyyy. MMMM dd.") + "\n" +
                    "Length: " + r[1];
            }

            conn.Close();
        }

        private void FilldgvTracks()
        {
            try
            {
                dgvTracks.Rows.Clear();
                dgvTracks.Refresh();

                tbSearch.Enabled = true;

                conn.Open();

                var cmd = new SqlCommand(
                    "SELECT Tracks.title, length, url, album, Tracks.id FROM Tracks INNER JOIN Albums " +
                    "ON Tracks.album = Albums.id " +
                    $"WHERE Albums.title LIKE '{cbAlbum.SelectedItem}';", conn);
                var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dgvTracks.Rows.Add(r[0], r[1], r[2], r[3], r[4]);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong. (FilldgvTracks)");
            }
        }

        string title;
        TimeSpan length;
        string url;
        string album;
        int id;

        private void DgvTracks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTracks.Rows[e.RowIndex];

                if (row.Cells[2].Value.ToString().Contains("null"))
                {
                    lLink.Text = "There is no video for this song. :(";
                    lLink.Enabled = false;
                    btnUrl.Enabled = true;
                }
                else
                {
                    lLink.Text = @"https://youtu.be/" + row.Cells[2].Value.ToString();
                    lLink.Enabled = true;
                    btnUrl.Enabled = false;
                }
            }

            title = (string)dgvTracks[0, e.RowIndex].Value;
            length = (TimeSpan)dgvTracks[1, e.RowIndex].Value;
            url = (string)dgvTracks[2, e.RowIndex].Value;
            album = (string)dgvTracks[3, e.RowIndex].Value;
            id = (int)dgvTracks[4, e.RowIndex].Value;

        }

        private void LLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lLink.Text);
        }

        private void BtnUrl_Click(object sender, EventArgs e)
        {
            var frm = new FrmUrl(
                conn,
                url,
                id);
            frm.ShowDialog();

            FilldgvTracks();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var frm = new FrmEdit(
                conn,
                title,
                length,
                url,
                album,
                id);
            frm.ShowDialog();

            FilldgvTracks();
        }
    }
}
