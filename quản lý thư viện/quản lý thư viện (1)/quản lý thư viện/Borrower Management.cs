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
    public partial class Borrower_Management : Form
    {
        private String username;
        private String password;
        public Borrower_Management(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Borrower_Management_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var query = from a in data.Borrowers

                        select new
                        {
                            CardNumber = a.CardNumber,
                            Borrowers_Name = a.Name,
                            Address = a.Address,
                            Phone = a.Phone,
                        };
            data_Borrower.DataSource = query.ToList();
            data_Borrower.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void data_Borrower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_Borrower.Rows[e.RowIndex];
            txt_id.Text = row.Cells["CardNumber"].Value.ToString();
            txt_id.Enabled = false;
            txt_name.Text = row.Cells["Borrowers_Name"].Value.ToString();
            txt_address.Text = row.Cells["Address"].Value.ToString();
            phone.Text = row.Cells["Phone"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Borrower tl = new Borrower();
                tl.CardNumber = Convert.ToInt32(txt_id.Text.ToString());
                tl.Name = txt_name.Text.ToString();
                tl.Address = txt_address.Text.ToString();
                tl.Phone = phone.Text.ToString();

                data.Borrowers.InsertOnSubmit(tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("More Failure");
            }
            finally
            {
                var qlpb = data.Borrowers;
                data_Borrower.DataSource = qlpb;
                Borrower_Management_Load(sender, e);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;
                Borrower edit_tl1 = data.Borrowers.Where(o => o.CardNumber.Equals(tl1)).FirstOrDefault();
                edit_tl1.Name = txt_name.Text.ToString();
                edit_tl1.Address = txt_address.Text.ToString();
                edit_tl1.Phone = phone.Text.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Repair failed");
            }
            finally
            {
                var qlpb = data.Borrowers;
                data_Borrower.DataSource = qlpb;
                data.SubmitChanges();

                Borrower_Management_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;
                Borrower del_tl = data.Borrowers.Where(o => o.CardNumber.Equals(tl1)).FirstOrDefault();
                data.Borrowers.DeleteOnSubmit(del_tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Failure !");
            }
            finally
            {
                var pb3 = data.Borrowers;
                data_Borrower.DataSource = pb3;
                Borrower_Management_Load(sender, e);

            }
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_id.Text = "";
            txt_name.Text = "";
            txt_search.Text = "";
            phone.Text = "";
            txt_id.Enabled = true;
            Borrower_Management_Load(sender,e);
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
                var query = from a in data.Borrowers

                            select new
                            {
                                CardNumber = a.CardNumber,
                                Borrowers_Name = a.Name,
                                Address = a.Address,
                                Phone = a.Phone,
                            };

                var a1 = from a in query
                         where a.CardNumber == Convert.ToInt32(c)
                         select a;
                data_Borrower.DataSource = a1;
            }
        }
    }
}
