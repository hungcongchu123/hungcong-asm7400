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

namespace quản_lý_thư_viện
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public String username = "";
        public String password = "";
        private string connectionString = "Data Source=.;Initial Catalog=ABC_LIBRARY;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string us = txt_us.Text;
            string ps = txt_ps.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Login WHERE UserName = @UserName AND PassWord = @PassWord";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", us);
                    cmd.Parameters.AddWithValue("@PassWord", ps);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        this.username = us;
                        this.password = ps;

                        this.Hide();
                        librarian ac = new librarian(username, password);
                        ac.ShowDialog();
                        ac = null;
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Account or password is incorrect");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

    private void label4_Click(object sender, EventArgs e)
        {
            Register ac = new Register();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
