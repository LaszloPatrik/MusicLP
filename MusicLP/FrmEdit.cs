using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLP
{
    public partial class FrmEdit : Form
    {
        SqlConnection conn;
        int idEdit;

        public FrmEdit(SqlConnection conn, string title, TimeSpan length, string url, string album, int id)
        {
            this.conn = conn;

            InitializeComponent();

            tbTitle.Text = title;
            tbLength.Text = length + "";
            tbUrl.Text = url;
            tbAlbum.Text = album;
            idEdit = id;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string url = (string.IsNullOrWhiteSpace(tbUrl.Text))
                ? "null"
                : tbUrl.Text;

            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                MessageBox.Show("Title is required!");
            }
            else if(string.IsNullOrWhiteSpace(tbAlbum.Text))
            {
                MessageBox.Show("Album is required!");
            }
            else if (string.IsNullOrWhiteSpace(tbLength.Text))
            {
                MessageBox.Show("Length is required!");
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure?",
                    "WARNING!",
                    MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        var cmd = new SqlCommand(
                            "UPDATE Tracks SET " +
                            $@"title = '{tbTitle.Text}', " +
                            $@"length = '{TimeSpan.Parse(tbLength.Text)}', " +
                            $@"album = '{tbAlbum.Text}', " +
                            $@"url = '{url}' " +
                            $"WHERE id = {idEdit};", conn);
                        var r = cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Done!");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong while the update. :(");
                    }
                }
                else
                {
                    this.Close();
                }
            } 
        }
    }
}
