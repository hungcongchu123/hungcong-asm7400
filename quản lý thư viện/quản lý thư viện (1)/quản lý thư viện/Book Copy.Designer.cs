namespace quản_lý_thư_viện
{
    partial class Book_Copy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Copy));
            this.btn_lm = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.ToolStripLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_them = new System.Windows.Forms.ToolStripLabel();
            this.btn_xoa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbo_bookid = new System.Windows.Forms.ComboBox();
            this.cbo_branid = new System.Windows.Forms.ComboBox();
            this.txt_CopyNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.data_bookcopy = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bookcopy)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lm
            // 
            this.btn_lm.Image = ((System.Drawing.Image)(resources.GetObject("btn_lm.Image")));
            this.btn_lm.Name = "btn_lm";
            this.btn_lm.Size = new System.Drawing.Size(78, 22);
            this.btn_lm.Text = "Refresh";
            this.btn_lm.Click += new System.EventHandler(this.btn_lm_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(602, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 47);
            this.button1.TabIndex = 170;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(125, 22);
            this.btn_sua.Text = "Edit Bookcopy";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(290, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 168;
            this.label4.Text = "BookID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_them,
            this.btn_sua,
            this.btn_xoa,
            this.btn_lm,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 25);
            this.toolStrip1.TabIndex = 167;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(127, 22);
            this.btn_them.Text = "Add Bookcopy";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(141, 22);
            this.btn_xoa.Text = "delete Bookcopy";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Return";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // cbo_bookid
            // 
            this.cbo_bookid.FormattingEnabled = true;
            this.cbo_bookid.Location = new System.Drawing.Point(381, 116);
            this.cbo_bookid.Name = "cbo_bookid";
            this.cbo_bookid.Size = new System.Drawing.Size(121, 24);
            this.cbo_bookid.TabIndex = 174;
            // 
            // cbo_branid
            // 
            this.cbo_branid.FormattingEnabled = true;
            this.cbo_branid.Location = new System.Drawing.Point(106, 116);
            this.cbo_branid.Name = "cbo_branid";
            this.cbo_branid.Size = new System.Drawing.Size(121, 24);
            this.cbo_branid.TabIndex = 173;
            // 
            // txt_CopyNumber
            // 
            this.txt_CopyNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CopyNumber.Location = new System.Drawing.Point(755, 124);
            this.txt_CopyNumber.Name = "txt_CopyNumber";
            this.txt_CopyNumber.Size = new System.Drawing.Size(124, 22);
            this.txt_CopyNumber.TabIndex = 172;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(639, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 171;
            this.label12.Text = "CopyNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 169;
            this.label2.Text = "BranchID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(157, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 33);
            this.label1.TabIndex = 164;
            this.label1.Text = "Book Copy";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(677, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(272, 24);
            this.txt_search.TabIndex = 166;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // data_bookcopy
            // 
            this.data_bookcopy.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_bookcopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bookcopy.Location = new System.Drawing.Point(12, 163);
            this.data_bookcopy.Name = "data_bookcopy";
            this.data_bookcopy.RowHeadersWidth = 51;
            this.data_bookcopy.RowTemplate.Height = 24;
            this.data_bookcopy.Size = new System.Drawing.Size(1021, 517);
            this.data_bookcopy.TabIndex = 165;
            this.data_bookcopy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_bookcopy_CellClick);
            // 
            // Book_Copy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbo_bookid);
            this.Controls.Add(this.cbo_branid);
            this.Controls.Add(this.txt_CopyNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.data_bookcopy);
            this.Name = "Book_Copy";
            this.Text = "Book_Copy";
            this.Load += new System.EventHandler(this.Book_Copy_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bookcopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel btn_lm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripLabel btn_sua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btn_them;
        private System.Windows.Forms.ToolStripLabel btn_xoa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox cbo_bookid;
        private System.Windows.Forms.ComboBox cbo_branid;
        private System.Windows.Forms.TextBox txt_CopyNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView data_bookcopy;
    }
}