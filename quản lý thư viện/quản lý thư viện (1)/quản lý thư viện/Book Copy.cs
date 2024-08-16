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
    public partial class Book_Copy : Form
    {
        private String username;
        private String password;
        public Book_Copy(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Book_Copy_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var query = from a in data.BookCopies
                       
                        select new
                        {
                            BookID = a.BookID,
                            BranchID = a.BranchID,
                            CopyNumber = a.CopyNumber

                        };

            cbo_bookid.DataSource = data.Books;
            cbo_bookid.DisplayMember = "BookID";
            cbo_bookid.ValueMember = "BookID";

            cbo_branid.DataSource = data.Branches;
            cbo_branid.DisplayMember = "BranchID";
            cbo_branid.ValueMember = "BranchID";



            data_bookcopy.DataSource = query.ToList();
            data_bookcopy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void data_bookcopy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_bookcopy.Rows[e.RowIndex];
            cbo_bookid.Text = row.Cells["BookID"].Value.ToString();
            cbo_bookid.Enabled = false;
            cbo_branid.Enabled = false;



            cbo_branid.Text = row.Cells["BranchID"].Value.ToString();
            txt_CopyNumber.Text = row.Cells["CopyNumber"].Value.ToString();
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                BookCopy tl = new BookCopy();
                tl.BranchID = Convert.ToInt32(cbo_branid.Text.ToString());
                tl.BookID = Convert.ToInt32(cbo_bookid.Text.ToString());
                tl.CopyNumber = Convert.ToInt32(txt_CopyNumber.Text.ToString());
              

                data.BookCopies.InsertOnSubmit(tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("More Failure");
            }
            finally
            {
                var qlpb = data.BookCopies;
                data_bookcopy.DataSource = qlpb;
                Book_Copy_Load(sender, e);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = cbo_bookid.Text;
                var tl2 = cbo_branid.Text;
                BookCopy edit_tl1 = data.BookCopies.Where(o => o.BookID.Equals(tl1)&& o.BranchID.Equals(tl2)).FirstOrDefault();
                edit_tl1.CopyNumber = Convert.ToInt32(txt_CopyNumber.Text.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Repair failed");
            }
            finally
            {
                var qlpb = data.BookCopies;
                data_bookcopy.DataSource = qlpb;
                data.SubmitChanges();

                Book_Copy_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = cbo_bookid.Text;
                var tl2 = cbo_branid.Text;
                BookCopy del_tl = data.BookCopies.Where(o => o.BookID.Equals(tl1) && o.BranchID.Equals(tl2)).FirstOrDefault();
                data.BookCopies.DeleteOnSubmit(del_tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Failure !");
            }
            finally
            {
                var pb3 = data.BookCopies;
                data_bookcopy.DataSource = pb3;
                Book_Copy_Load(sender, e);

            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            cbo_bookid.Enabled = true;
            cbo_branid.Enabled = true;
            txt_CopyNumber.Text = "";
            Book_Copy_Load(sender,e);
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
                var query = from a in data.BookCopies

                            select new
                            {
                                BookID = a.BookID,
                                BranchID = a.BranchID,
                                CopyNumber = a.CopyNumber

                            };

                var a1 = from a in query
                         where a.BookID == Convert.ToInt32(c)
                         select a;
                data_bookcopy.DataSource = a1;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            librarian ac = new librarian(username, password);
            ac.ShowDialog();
            ac = null;
            this.Show();
        }
    }
}
