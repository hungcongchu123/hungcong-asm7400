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
    public partial class librarian : Form
    {
        private String username;
        private String password;
        public librarian(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void librarian_Load(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void branchManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 tkvc = new Form1(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void authorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author_Management tkvc = new Author_Management(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void publisherManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publisher_Management tkvc = new Publisher_Management(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void borrowerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower_Management tkvc = new Borrower_Management(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void borrowManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow_Management tkvc = new Borrow_Management(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void bookCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Copy tkvc = new Book_Copy(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void detailsInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details_information tkvc = new Details_information(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password tkvc = new Change_Password(username);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Change_Password tkvc = new Change_Password(username);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

       

        private void bookManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_management tkvc = new Book_management(username, password);
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login tkvc = new login();
            tkvc.ShowDialog();
            tkvc = null;
            this.Close();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
