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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login tl = new Login();
                

                if(txt_ps.Text != txt_ps2.Text)
                {
                    MessageBox.Show("Password does not match, please re-enter!");
                    return;
                }

                else
                {
                    tl.UserName = txt_us.Text.ToString();
                    tl.PassWord = txt_ps.Text.ToString();
                    tl.Email = txt_email.Text.ToString();
                }
                

                data.Logins.InsertOnSubmit(tl);
                data.SubmitChanges();


                MessageBox.Show("Sign Up Success");
                login loginForm = new login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Registration failed");
            }
            finally
            {
               
            }
        }
    }
}
