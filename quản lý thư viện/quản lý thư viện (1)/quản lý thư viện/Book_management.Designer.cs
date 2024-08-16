namespace quản_lý_thư_viện
{
    partial class Book_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_management));
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_pubname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripLabel();
            this.btn_edit = new System.Windows.Forms.ToolStripLabel();
            this.btn_delete = new System.Windows.Forms.ToolStripLabel();
            this.btn_res = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cbo_auid = new System.Windows.Forms.ComboBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_Book = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(767, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 206;
            this.label5.Text = "AuthorID:";
            // 
            // cbo_pubname
            // 
            this.cbo_pubname.FormattingEnabled = true;
            this.cbo_pubname.Location = new System.Drawing.Point(556, 156);
            this.cbo_pubname.Name = "cbo_pubname";
            this.cbo_pubname.Size = new System.Drawing.Size(121, 24);
            this.cbo_pubname.TabIndex = 205;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(424, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 204;
            this.label3.Text = "Publisher Name:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(676, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 43);
            this.button1.TabIndex = 199;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(455, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 197;
            this.label4.Text = "Title:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.btn_edit,
            this.btn_delete,
            this.btn_res,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip1.TabIndex = 196;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 22);
            this.btn_add.Text = "Add Book";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(93, 22);
            this.btn_edit.Text = "Edit Book";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(111, 22);
            this.btn_delete.Text = "Delete Book";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_res
            // 
            this.btn_res.Image = ((System.Drawing.Image)(resources.GetObject("btn_res.Image")));
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(78, 22);
            this.btn_res.Text = "Refresh";
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Return";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(745, 61);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(272, 24);
            this.txt_search.TabIndex = 195;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cbo_auid
            // 
            this.cbo_auid.FormattingEnabled = true;
            this.cbo_auid.Location = new System.Drawing.Point(868, 122);
            this.cbo_auid.Name = "cbo_auid";
            this.cbo_auid.Size = new System.Drawing.Size(121, 24);
            this.cbo_auid.TabIndex = 207;
            // 
            // txt_title
            // 
            this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_title.Location = new System.Drawing.Point(556, 116);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(128, 22);
            this.txt_title.TabIndex = 203;
            // 
            // txt_year
            // 
            this.txt_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_year.Location = new System.Drawing.Point(200, 159);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(124, 22);
            this.txt_year.TabIndex = 202;
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Location = new System.Drawing.Point(200, 119);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(124, 22);
            this.txt_id.TabIndex = 201;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(62, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 200;
            this.label12.Text = "Publication Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(88, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 198;
            this.label2.Text = "BookID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 193;
            this.label1.Text = "Book Management";
            // 
            // data_Book
            // 
            this.data_Book.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Book.Location = new System.Drawing.Point(12, 224);
            this.data_Book.Name = "data_Book";
            this.data_Book.RowHeadersWidth = 51;
            this.data_Book.RowTemplate.Height = 24;
            this.data_Book.Size = new System.Drawing.Size(1021, 538);
            this.data_Book.TabIndex = 194;
            this.data_Book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Book_CellClick);
            // 
            // Book_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 775);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_pubname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cbo_auid);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_Book);
            this.Name = "Book_management";
            this.Text = "Book_management";
            this.Load += new System.EventHandler(this.Book_management_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_pubname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btn_add;
        private System.Windows.Forms.ToolStripLabel btn_edit;
        private System.Windows.Forms.ToolStripLabel btn_delete;
        private System.Windows.Forms.ToolStripLabel btn_res;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cbo_auid;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_Book;
    }
}