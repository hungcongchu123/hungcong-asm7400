using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quản_lý_thư_viện
{
    public partial class Book_management : Form
    {
        private String username;
        private String password;
        public Book_management(string username, string password)
        {
           
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Book_management_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var query = from a in data.Books
                        join b in data.AuthorBooks on a.BookID equals b.BookID
                        join c in data.Publishers on a.PublisherID equals c.PublisherID

                        select new
                        {
                            BookID = a.BookID,
                            Title = a.Title,
                            Publication_Year = a.PublicationYear,
                            PublisherID = a.PublisherID,
                            AuthorID = b.AuthorID,
                            Publishers_Name = c.PublisherName

                        };

            cbo_pubname.DataSource = data.Publishers; 
            cbo_pubname.DisplayMember = "PublisherName";
            cbo_pubname.ValueMember = "PublisherID";

            cbo_auid.DataSource = data.Authors;
            cbo_auid.DisplayMember = "AuthorID";
            cbo_auid.ValueMember = "AuthorID";



            data_Book.DataSource = query.ToList();
            data_Book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void data_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_Book.Rows[e.RowIndex];
            txt_id.Text = row.Cells["BookID"].Value.ToString();
            txt_id.Enabled = false;
            txt_title.Text = row.Cells["Title"].Value.ToString();
            txt_year.Text = row.Cells["Publication_Year"].Value.ToString();
            cbo_pubname.Text = row.Cells["Publishers_Name"].Value.ToString();
            cbo_auid.Text = row.Cells["AuthorID"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Book tl = new Book();
                tl.BookID = Convert.ToInt32(txt_id.Text.ToString());
                tl.Title = txt_title.Text.ToString();
                tl.PublicationYear = Convert.ToInt32(txt_year.Text.ToString());



                var m = (from ds in data.Publishers
                         where ds.PublisherName == cbo_pubname.Text
                         select ds.PublisherID).FirstOrDefault();

                tl.PublisherID = Convert.ToInt32(m);
                data.Books.InsertOnSubmit(tl);


                AuthorBook au = new AuthorBook();
                au.BookID = Convert.ToInt32(txt_id.Text.ToString());
                au.AuthorID = Convert.ToInt32(cbo_auid.Text.ToString());
                data.AuthorBooks.InsertOnSubmit(au);

                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("More Failure");
            }
            finally
            {
                var qlpb = data.Books;
                data_Book.DataSource = qlpb;
                Book_management_Load(sender, e);

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;

                Book edit_tl1 = data.Books.Where(o => o.BookID.Equals(tl1)).FirstOrDefault();
                edit_tl1.Title = txt_title.Text.ToString();
                edit_tl1.PublicationYear = Convert.ToInt32(txt_year.Text.ToString());

                var m = (from ds in data.Publishers
                         where ds.PublisherName == cbo_pubname.Text
                         select ds.PublisherID).FirstOrDefault();

                edit_tl1.PublisherID = Convert.ToInt32(m);


              

            }
            catch (Exception)
            {
                MessageBox.Show("Repair failed");
            }
            finally
            {

                var qlpb = data.Books;
                data_Book.DataSource = qlpb;
                data.SubmitChanges();

                Book_management_Load(sender, e);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;
                Book del_tl = data.Books.Where(o => o.BookID.Equals(tl1)).FirstOrDefault();
                data.Books.DeleteOnSubmit(del_tl);

                AuthorBook edit_tl2 = data.AuthorBooks.Where(o => o.BookID.Equals(tl1)).FirstOrDefault();
                data.AuthorBooks.DeleteOnSubmit(edit_tl2);

                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Failure !");
            }
            finally
            {
                var pb3 = data.Books;
                data_Book.DataSource = pb3;
                Book_management_Load(sender, e);

            }
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            txt_title.Text = "";
            txt_id.Text = "";
            txt_year.Text = "";
            txt_search.Text = "";
            cbo_pubname.Text = "";
            txt_id.Enabled = true;
            cbo_auid.Text = "";
            cbo_auid.Enabled = true;
            Book_management_Load(sender,e);
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
                var query = from a in data.Books
                            join b in data.AuthorBooks on a.BookID equals b.BookID

                            select new
                            {
                                BookID = a.BookID,
                                Title = a.Title,
                                Publication_Year = a.PublicationYear,
                                PublisherID = a.PublisherID,
                                AuthorID = b.AuthorID,

                            };

                var a1 = from a in query
                         where a.BookID == Convert.ToInt32(c)
                         select a;
                data_Book.DataSource = a1;
            }
        }
    }
}
