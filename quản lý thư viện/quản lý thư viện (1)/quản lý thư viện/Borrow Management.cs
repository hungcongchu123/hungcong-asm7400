using System;
using System.Collections;
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
    public partial class Borrow_Management : Form
    {
        private String username;
        private String password;
        public Borrow_Management(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Borrow_Management_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var query = from a in data.Borrows

                        select new
                        {
                            BorrowID = a.BorrowID,
                            BookID = a.BookID,
                            CardNumber = a.CardNumber,
                            BranchID = a.BranchID,
                            BorrowDate = a.BorrowDate,
                            ReturnDate = a.ReturnDate,
                            

                        };

            cbo_bookid.DataSource = data.Books;
            cbo_bookid.DisplayMember = "BookID";
            cbo_bookid.ValueMember = "BookID";

            cbo_branid.DataSource = data.Branches;
            cbo_branid.DisplayMember = "BranchID";
            cbo_branid.ValueMember = "BranchID";



            cbo_card.DataSource = data.Borrowers;
            cbo_card.DisplayMember = "CardNumber";
            cbo_card.ValueMember = "CardNumber";


            data_Borrow.DataSource = query.ToList();
            data_Borrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void data_Borrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_Borrow.Rows[e.RowIndex];
            txt_id.Text = row.Cells["BorrowID"].Value.ToString();
            txt_id.Enabled=false;
            cbo_branid.Text = row.Cells["BranchID"].Value.ToString();
            cbo_bookid.Text = row.Cells["BookID"].Value.ToString();
            cbo_card.Text = row.Cells["CardNumber"].Value.ToString();
            date_bd.Text = row.Cells["BorrowDate"].Value.ToString();
            a.Text = row.Cells["ReturnDate"].Value.ToString();
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Borrow tl = new Borrow();
                tl.BorrowID = Convert.ToInt32(txt_id.Text.ToString());
                tl.BookID = Convert.ToInt32(cbo_bookid.Text.ToString());
                tl.BranchID = Convert.ToInt32(cbo_branid.Text.ToString());
                tl.CardNumber = Convert.ToInt32(cbo_card.Text.ToString());

                tl.ReturnDate = Convert.ToDateTime(date_return.Text.ToString());
                tl.BorrowDate = Convert.ToDateTime(date_bd.Text.ToString());



                data.Borrows.InsertOnSubmit(tl);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                var qlpb = data.Borrows;
                data_Borrow.DataSource = qlpb;
                Borrow_Management_Load(sender, e);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
               
                var tl2 = txt_id.Text;
                Borrow edit_tl1 = data.Borrows.Where(o => o.BorrowID.Equals(tl2)).FirstOrDefault();
                edit_tl1.BookID = Convert.ToInt32(cbo_bookid.Text.ToString());
                edit_tl1.BranchID = Convert.ToInt32(cbo_branid.Text.ToString());
                edit_tl1.CardNumber = Convert.ToInt32(cbo_card.Text.ToString());

                edit_tl1.ReturnDate = Convert.ToDateTime(date_return.Text.ToString());
                edit_tl1.BorrowDate = Convert.ToDateTime(date_bd.Text.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Repair failed");
            }
            finally
            {
                var qlpb = data.Borrows;
                data_Borrow.DataSource = qlpb;
                data.SubmitChanges();

                Borrow_Management_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var tl2 = txt_id.Text;
                Borrow del_tl = data.Borrows.Where(o => o.BorrowID.Equals(tl2)).FirstOrDefault();
                data.Borrows.DeleteOnSubmit(del_tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Failure !");
            }
            finally
            {
                var pb3 = data.Borrows;
                data_Borrow.DataSource = pb3;
                Borrow_Management_Load(sender, e);

            }
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            txt_id.Enabled= true;
            date_bd.Text = "";
            date_return.Text = "";
            cbo_bookid.Text = "";
            cbo_branid.Text = "";
            cbo_card.Text = "";
            txt_id.Text = "";
            Borrow_Management_Load(sender,e);
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
                var query = from a in data.Borrows

                            select new
                            {
                                BorrowID = a.BorrowID,
                                BookID = a.BookID,
                                CardNumber = a.CardNumber,
                                BranchID = a.BranchID,
                                BorrowDate = a.BorrowDate,
                                ReturnDate = a.ReturnDate,
                            };

                var a1 = from a in query
                         where a.BorrowID == Convert.ToInt32(c)
                         select a;
                data_Borrow.DataSource = a1;
            }
        }
    }
}
