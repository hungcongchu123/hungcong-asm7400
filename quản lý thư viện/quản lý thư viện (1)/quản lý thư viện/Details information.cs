using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_thư_viện
{
    public partial class Details_information : Form
    {


        private String username;
        private String password;
        public Details_information(String username, String password)
        {
            InitializeComponent();
            this.password = password;
            this.username = username;
        }
       DataClasses1DataContext data = new DataClasses1DataContext();
        private void Details_information_Load(object sender, EventArgs e)
        {
            txt_us.Text = username;
            txt_ps.Text = password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            librarian ac = new librarian(username, password);
            ac.ShowDialog();
            ac = null;
            this.Show();
        }
    }
}
