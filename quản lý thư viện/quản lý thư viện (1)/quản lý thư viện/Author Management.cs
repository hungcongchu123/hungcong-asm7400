using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quản_lý_thư_viện
{
    public partial class Author_Management : Form
    {
        private String username;
        private String password;
        public Author_Management(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Author_Management_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var query = from a in data.Authors

                        select new
                        {
                            AuthorID = a.AuthorID,
                            Author_Name = a.AuthorName,
                          
                        };
            data_Author.DataSource = query.ToList();
            data_Author.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void data_Author_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_Author.Rows[e.RowIndex];
            txt_id.Text = row.Cells["AuthorID"].Value.ToString();
            txt_id.Enabled = false;
            txt_name.Text = row.Cells["Author_Name"].Value.ToString();
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Author tl = new Author();
                tl.AuthorID = Convert.ToInt32(txt_id.Text.ToString());
                tl.AuthorName = txt_name.Text.ToString();
               

                data.Authors.InsertOnSubmit(tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("More Failure");
            }
            finally
            {
                var qlpb = data.Authors;
                data_Author.DataSource = qlpb;
                Author_Management_Load(sender, e);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;
                Author edit_tl1 = data.Authors.Where(o => o.AuthorID.Equals(tl1)).FirstOrDefault();
                edit_tl1.AuthorName = txt_name.Text.ToString();
              

            }
            catch (Exception)
            {
                MessageBox.Show("Repair failed");
            }
            finally
            {
                var qlpb = data.Authors;
                data_Author.DataSource = qlpb;
                data.SubmitChanges();

                Author_Management_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;
                Author del_tl = data.Authors.Where(o => o.AuthorID.Equals(tl1)).FirstOrDefault();
                data.Authors.DeleteOnSubmit(del_tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Failure !");
            }
            finally
            {
                var pb3 = data.Authors;
                data_Author.DataSource = pb3;
                Author_Management_Load(sender, e);

            }
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_search.Text = "";
            txt_id.Enabled = true;
            Author_Management_Load(sender, e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            librarian ac = new librarian(username, password);
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var c = txt_search.Text;
            if (string.IsNullOrEmpty(txt_search.Text) || !int.TryParse(txt_search.Text, out _))
            {
                MessageBox.Show("No results were found!");
            }
            else
            {
                var query = from a in data.Authors

                            select new
                            {
                                AuthorID = a.AuthorID,
                                Author_Name = a.AuthorName,

                            };

                var a1 = from a in query
                         where a.AuthorID == Convert.ToInt32(c)
                         select a;
                data_Author.DataSource = a1;
            }
        }
    }
}
