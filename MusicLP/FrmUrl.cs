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
    public partial class FrmUrl : Form
    {
        SqlConnection conn;
        int idAdd;
        public FrmUrl(SqlConnection conn, string url, int id)
        {
            this.conn = conn;
            InitializeComponent();

            tbUrl.Text = url;
            idAdd = id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUrl.Text) || tbUrl.Text.Contains("null"))
            {
                MessageBox.Show("No need to update.");
                this.Close();
            }
            else
            {
                string[] spl = tbUrl.Text.Split('/');

                if (spl.Length != 4 && !spl[2].Contains("youtu.be"))
                {
                    MessageBox.Show("It's not a correct tiny Youtube link.");
                }
                else
                {
                    try
                    {
                        conn.Open();

                        var cmd = new SqlCommand(
                            "UPDATE Tracks SET " +
                            $@"url = '{spl.Last()}' " +
                            $"WHERE id = {idAdd};", conn);
                        var r = cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("URL is added!");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Unhandled problem with the update.");
                    }
                }
            }
        }
    }
}
