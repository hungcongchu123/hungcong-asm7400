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
    public partial class Change_Password : Form
    {
        private String username;
        public Change_Password(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {

            string oldPassword = txt_oldpass.Text;
            string newPassword = txt_newpass.Text;
            var user = dataContext.Logins.SingleOrDefault(u => u.UserName == username && u.PassWord == oldPassword);
            if (user != null)
            {
                user.PassWord = newPassword;
                dataContext.SubmitChanges();
                MessageBox.Show("Password changed successfully.");
            }
            else
            {
                MessageBox.Show("Old password is incorrect.");
            }
        }
    }
}
