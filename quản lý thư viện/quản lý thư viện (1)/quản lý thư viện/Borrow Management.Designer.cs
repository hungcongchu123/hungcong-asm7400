namespace quản_lý_thư_viện
{
    partial class Borrow_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow_Management));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_Borrow = new System.Windows.Forms.DataGridView();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_res = new System.Windows.Forms.ToolStripLabel();
            this.btn_delete = new System.Windows.Forms.ToolStripLabel();
            this.btn_edit = new System.Windows.Forms.ToolStripLabel();
            this.btn_add = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.date_bd = new System.Windows.Forms.DateTimePicker();
            this.date_return = new System.Windows.Forms.DateTimePicker();
            this.cbo_bookid = new System.Windows.Forms.ComboBox();
            this.cbo_card = new System.Windows.Forms.ComboBox();
            this.cbo_branid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Borrow)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Location = new System.Drawing.Point(171, 118);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(124, 22);
            this.txt_id.TabIndex = 186;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(59, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 185;
            this.label12.Text = "BookID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 183;
            this.label2.Text = "BorrowID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 178;
            this.label1.Text = "Borrow Management";
            // 
            // data_Borrow
            // 
            this.data_Borrow.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.data_Borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Borrow.Location = new System.Drawing.Point(12, 205);
            this.data_Borrow.Name = "data_Borrow";
            this.data_Borrow.RowHeadersWidth = 51;
            this.data_Borrow.RowTemplate.Height = 24;
            this.data_Borrow.Size = new System.Drawing.Size(1021, 538);
            this.data_Borrow.TabIndex = 179;
            this.data_Borrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Borrow_CellClick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Return";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btn_res
            // 
            this.btn_res.Image = ((System.Drawing.Image)(resources.GetObject("btn_res.Image")));
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(78, 22);
            this.btn_res.Text = "Refresh";
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 22);
            this.btn_delete.Text = "Delete Borrow";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 22);
            this.btn_edit.Text = "Edit Borrow";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 22);
            this.btn_add.Text = "Add Borrow";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(389, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 189;
            this.label3.Text = "BranchID";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(572, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 43);
            this.button1.TabIndex = 184;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(389, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 182;
            this.label4.Text = "Card Number";
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
            this.toolStrip1.TabIndex = 181;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(641, 57);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(272, 24);
            this.txt_search.TabIndex = 180;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(702, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 182;
            this.label5.Text = "Borrow Date";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.ForeColor = System.Drawing.Color.Black;
            this.a.Location = new System.Drawing.Point(702, 159);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(78, 16);
            this.a.TabIndex = 189;
            this.a.Text = "Return Date";
            // 
            // date_bd
            // 
            this.date_bd.Location = new System.Drawing.Point(812, 119);
            this.date_bd.Name = "date_bd";
            this.date_bd.Size = new System.Drawing.Size(200, 22);
            this.date_bd.TabIndex = 191;
            // 
            // date_return
            // 
            this.date_return.Location = new System.Drawing.Point(812, 159);
            this.date_return.Name = "date_return";
            this.date_return.Size = new System.Drawing.Size(200, 22);
            this.date_return.TabIndex = 191;
            // 
            // cbo_bookid
            // 
            this.cbo_bookid.FormattingEnabled = true;
            this.cbo_bookid.Location = new System.Drawing.Point(171, 159);
            this.cbo_bookid.Name = "cbo_bookid";
            this.cbo_bookid.Size = new System.Drawing.Size(121, 24);
            this.cbo_bookid.TabIndex = 192;
            // 
            // cbo_card
            // 
            this.cbo_card.FormattingEnabled = true;
            this.cbo_card.Location = new System.Drawing.Point(499, 119);
            this.cbo_card.Name = "cbo_card";
            this.cbo_card.Size = new System.Drawing.Size(121, 24);
            this.cbo_card.TabIndex = 192;
            // 
            // cbo_branid
            // 
            this.cbo_branid.FormattingEnabled = true;
            this.cbo_branid.Location = new System.Drawing.Point(499, 157);
            this.cbo_branid.Name = "cbo_branid";
            this.cbo_branid.Size = new System.Drawing.Size(121, 24);
            this.cbo_branid.TabIndex = 192;
            // 
            // Borrow_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 755);
            this.Controls.Add(this.cbo_branid);
            this.Controls.Add(this.cbo_card);
            this.Controls.Add(this.cbo_bookid);
            this.Controls.Add(this.date_return);
            this.Controls.Add(this.date_bd);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.data_Borrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_search);
            this.Name = "Borrow_Management";
            this.Text = "Borrow Management";
            this.Load += new System.EventHandler(this.Borrow_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Borrow)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_Borrow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel btn_res;
        private System.Windows.Forms.ToolStripLabel btn_delete;
        private System.Windows.Forms.ToolStripLabel btn_edit;
        private System.Windows.Forms.ToolStripLabel btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DateTimePicker date_bd;
        private System.Windows.Forms.DateTimePicker date_return;
        private System.Windows.Forms.ComboBox cbo_bookid;
        private System.Windows.Forms.ComboBox cbo_card;
        private System.Windows.Forms.ComboBox cbo_branid;
    }
}