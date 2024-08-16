using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private string username;
        private string password;
        private string connectionString = "Data Source=.;Initial Catalog=ABC_LIBRARY;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form1(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT BranchID, BranchName AS Branch_Name, Address FROM Branch";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    data_branch.DataSource = dataTable;
                    data_branch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Branch (BranchID, BranchName, Address) VALUES (@BranchID, @BranchName, @Address)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BranchID", Convert.ToInt32(txt_id.Text));
                    cmd.Parameters.AddWithValue("@BranchName", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add Failure: " + ex.Message);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Branch SET BranchName = @BranchName, Address = @Address WHERE BranchID = @BranchID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BranchID", Convert.ToInt32(txt_id.Text));
                    cmd.Parameters.AddWithValue("@BranchName", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Edit Failure: " + ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Branch WHERE BranchID = @BranchID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BranchID", Convert.ToInt32(txt_id.Text));
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Failure: " + ex.Message);
                }
            }
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_id.Text = "";
            txt_name.Text = "";
            txt_search.Text = "";
            txt_id.Enabled = true;
            LoadData();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            librarian ac = new librarian(username, password);
            ac.ShowDialog();
            ac = null;
            this.Show();
        }
        private void data_branch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_branch.Rows[e.RowIndex];
            txt_id.Text = row.Cells["BranchID"].Value.ToString();
            txt_id.Enabled = false;
            txt_name.Text = row.Cells["Branch_Name"].Value.ToString();
            txt_address.Text = row.Cells["Address"].Value.ToString();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text) || !int.TryParse(txt_search.Text, out _))
            {
                MessageBox.Show("No results were found!");
                LoadData();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT BranchID, BranchName AS Branch_Name, Address FROM Branch WHERE BranchID = @BranchID";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@BranchID", Convert.ToInt32(txt_search.Text));
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        data_branch.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error searching data: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
