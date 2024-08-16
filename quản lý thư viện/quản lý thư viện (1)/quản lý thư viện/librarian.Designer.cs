namespace quản_lý_thư_viện
{
    partial class librarian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1359, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.branchManagementToolStripMenuItem,
            this.authorManagementToolStripMenuItem,
            this.publisherManagementToolStripMenuItem,
            this.borrowerManagementToolStripMenuItem,
            this.borrowManagementToolStripMenuItem,
            this.bookCopyToolStripMenuItem,
            this.bookManagementToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // branchManagementToolStripMenuItem
            // 
            this.branchManagementToolStripMenuItem.Name = "branchManagementToolStripMenuItem";
            this.branchManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.branchManagementToolStripMenuItem.Text = "Branch Management";
            this.branchManagementToolStripMenuItem.Click += new System.EventHandler(this.branchManagementToolStripMenuItem_Click);
            // 
            // authorManagementToolStripMenuItem
            // 
            this.authorManagementToolStripMenuItem.Name = "authorManagementToolStripMenuItem";
            this.authorManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.authorManagementToolStripMenuItem.Text = "Author Management";
            this.authorManagementToolStripMenuItem.Click += new System.EventHandler(this.authorManagementToolStripMenuItem_Click);
            // 
            // publisherManagementToolStripMenuItem
            // 
            this.publisherManagementToolStripMenuItem.Name = "publisherManagementToolStripMenuItem";
            this.publisherManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.publisherManagementToolStripMenuItem.Text = "Publisher Management";
            this.publisherManagementToolStripMenuItem.Click += new System.EventHandler(this.publisherManagementToolStripMenuItem_Click);
            // 
            // borrowerManagementToolStripMenuItem
            // 
            this.borrowerManagementToolStripMenuItem.Name = "borrowerManagementToolStripMenuItem";
            this.borrowerManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.borrowerManagementToolStripMenuItem.Text = "Borrower Management";
            this.borrowerManagementToolStripMenuItem.Click += new System.EventHandler(this.borrowerManagementToolStripMenuItem_Click);
            // 
            // borrowManagementToolStripMenuItem
            // 
            this.borrowManagementToolStripMenuItem.Name = "borrowManagementToolStripMenuItem";
            this.borrowManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.borrowManagementToolStripMenuItem.Text = "Borrow Management";
            this.borrowManagementToolStripMenuItem.Click += new System.EventHandler(this.borrowManagementToolStripMenuItem_Click);
            // 
            // bookCopyToolStripMenuItem
            // 
            this.bookCopyToolStripMenuItem.Name = "bookCopyToolStripMenuItem";
            this.bookCopyToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.bookCopyToolStripMenuItem.Text = "Book Copy";
            this.bookCopyToolStripMenuItem.Click += new System.EventHandler(this.bookCopyToolStripMenuItem_Click);
            // 
            // bookManagementToolStripMenuItem
            // 
            this.bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            this.bookManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.bookManagementToolStripMenuItem.Text = "Book Management";
            this.bookManagementToolStripMenuItem.Click += new System.EventHandler(this.bookManagementToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsInformationToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.accountToolStripMenuItem.Text = "Account Information";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // detailsInformationToolStripMenuItem
            // 
            this.detailsInformationToolStripMenuItem.Name = "detailsInformationToolStripMenuItem";
            this.detailsInformationToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.detailsInformationToolStripMenuItem.Text = "Details information";
            this.detailsInformationToolStripMenuItem.Click += new System.EventHandler(this.detailsInformationToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click_1);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quản_lý_thư_viện.Properties.Resources.z5661373989331_5ce6aa641cd52a031b000c6cddae0bd6;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1359, 698);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "librarian";
            this.Text = "librarian";
            this.Load += new System.EventHandler(this.librarian_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publisherManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagementToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}