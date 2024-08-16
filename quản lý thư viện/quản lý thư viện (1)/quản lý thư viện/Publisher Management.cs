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
    public partial class Publisher_Management : Form
    {
        private String username;
        private String password;
        public Publisher_Management(string username, string password)
        {
       
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Publisher_Management_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.Publishers

                        select new
                        {
                            PublishersID = a.PublisherID,
                            Publishers_Name = a.PublisherName,
                            Address = a.Address,
                            Phone = a.Phone,
                        };
            data_publisher.DataSource = quyry.ToList();
            data_publisher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void data_publisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_publisher.Rows[e.RowIndex];
            txt_id.Text = row.Cells["PublishersID"].Value.ToString();
            txt_id.Enabled = false;
            txt_name.Text = row.Cells["Publishers_Name"].Value.ToString();
            txt_address.Text = row.Cells["Address"].Value.ToString();
            phone.Text = row.Cells["Phone"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Publisher tl = new Publisher();
                tl.PublisherID = Convert.ToInt32(txt_id.Text.ToString());
                tl.PublisherName = txt_name.Text.ToString();
                tl.Address = txt_address.Text.ToString();
                tl.Phone = phone.Text.ToString();

                data.Publishers.InsertOnSubmit(tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("More Failure");
            }
            finally
            {
                var qlpb = data.Publishers;
                data_publisher.DataSource = qlpb;
                Publisher_Management_Load(sender, e);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;
                Publisher edit_tl1 = data.Publishers.Where(o => o.PublisherID.Equals(tl1)).FirstOrDefault();
                edit_tl1.PublisherName = txt_name.Text.ToString();
                edit_tl1.Address = txt_address.Text.ToString();
                edit_tl1.Phone = phone.Text.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Repair failed");
            }
            finally
            {
                var qlpb = data.Publishers;
                data_publisher.DataSource = qlpb;
                data.SubmitChanges();

                Publisher_Management_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var tl1 = txt_id.Text;
                Publisher del_tl = data.Publishers.Where(o => o.PublisherID.Equals(tl1)).FirstOrDefault();
                data.Publishers.DeleteOnSubmit(del_tl);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Failure !");
            }
            finally
            {
                var pb3 = data.Publishers;
                data_publisher.DataSource = pb3;
                Publisher_Management_Load(sender, e);

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
            Publisher_Management_Load(sender,e);
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
                var quyry = from a in data.Publishers

                            select new
                            {
                                PublishersID = a.PublisherID,
                                Publishers_Name = a.PublisherName,
                                Address = a.Address,
                                Phone = a.Phone,
                            };

                var a1 = from a in quyry
                         where a.PublishersID == Convert.ToInt32(c)
                         select a;
                data_publisher.DataSource = a1;
            }
        }
    }
}
