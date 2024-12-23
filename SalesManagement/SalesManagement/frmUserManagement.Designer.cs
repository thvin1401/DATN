namespace SalesManagement
{
    partial class frmUserManagement
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
            btnback = new Button();
            grdheader = new DataGridView();
            grddata = new DataGridView();
            lbltitle = new Label();
            txtname = new TextBox();
            cmbstatus = new ComboBox();
            dpkbirthdayfrom = new DateTimePicker();
            label1 = new Label();
            txtphone = new TextBox();
            txtaddress = new TextBox();
            dpkbirthdayto = new DateTimePicker();
            btnsearch = new Button();
            btnadd = new Button();
            btndeactivate = new Button();
            btnactivate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grddata).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(1154, 619);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 33);
            btnback.TabIndex = 0;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // grdheader
            // 
            grdheader.AllowUserToAddRows = false;
            grdheader.AllowUserToDeleteRows = false;
            grdheader.AllowUserToResizeColumns = false;
            grdheader.AllowUserToResizeRows = false;
            grdheader.BackgroundColor = SystemColors.Window;
            grdheader.BorderStyle = BorderStyle.Fixed3D;
            grdheader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdheader.ColumnHeadersVisible = false;
            grdheader.Location = new Point(28, 117);
            grdheader.Name = "grdheader";
            grdheader.RowHeadersVisible = false;
            grdheader.RowTemplate.Height = 25;
            grdheader.Size = new Size(1201, 31);
            grdheader.TabIndex = 1;
            // 
            // grddata
            // 
            grddata.AllowUserToAddRows = false;
            grddata.AllowUserToDeleteRows = false;
            grddata.AllowUserToResizeColumns = false;
            grddata.AllowUserToResizeRows = false;
            grddata.BackgroundColor = SystemColors.Window;
            grddata.BorderStyle = BorderStyle.Fixed3D;
            grddata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grddata.ColumnHeadersVisible = false;
            grddata.Location = new Point(28, 146);
            grddata.Name = "grddata";
            grddata.RowHeadersVisible = false;
            grddata.RowTemplate.Height = 25;
            grddata.Size = new Size(1201, 456);
            grddata.TabIndex = 2;
            grddata.CellContentClick += grddata_CellContentClick;
            grddata.CellDoubleClick += grddata_CellDoubleClick;
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(28, 22);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(311, 54);
            lbltitle.TabIndex = 18;
            lbltitle.Text = "User management screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(450, 47);
            txtname.Name = "txtname";
            txtname.Size = new Size(253, 29);
            txtname.TabIndex = 19;
            // 
            // cmbstatus
            // 
            cmbstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbstatus.FlatStyle = FlatStyle.Flat;
            cmbstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(1108, 82);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(121, 29);
            cmbstatus.TabIndex = 20;
            cmbstatus.SelectedIndexChanged += cmbstatus_SelectedIndexChanged;
            // 
            // dpkbirthdayfrom
            // 
            dpkbirthdayfrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkbirthdayfrom.Location = new Point(450, 82);
            dpkbirthdayfrom.Name = "dpkbirthdayfrom";
            dpkbirthdayfrom.Size = new Size(278, 29);
            dpkbirthdayfrom.TabIndex = 21;
            dpkbirthdayfrom.ValueChanged += dpkbirthdayfrom_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1050, 85);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 22;
            label1.Text = "Status";
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtphone.Location = new Point(769, 47);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(131, 29);
            txtphone.TabIndex = 23;
            txtphone.KeyPress += txtphone_KeyPress;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(978, 47);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(150, 29);
            txtaddress.TabIndex = 24;
            // 
            // dpkbirthdayto
            // 
            dpkbirthdayto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkbirthdayto.Location = new Point(769, 82);
            dpkbirthdayto.Name = "dpkbirthdayto";
            dpkbirthdayto.Size = new Size(275, 29);
            dpkbirthdayto.TabIndex = 25;
            dpkbirthdayto.ValueChanged += dpkbirthdayto_ValueChanged;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(1154, 44);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 32);
            btnsearch.TabIndex = 26;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(1053, 619);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 33);
            btnadd.TabIndex = 27;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btndeactivate
            // 
            btndeactivate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndeactivate.Location = new Point(915, 619);
            btndeactivate.Name = "btndeactivate";
            btndeactivate.Size = new Size(110, 33);
            btndeactivate.TabIndex = 28;
            btndeactivate.Text = "Deactivate";
            btndeactivate.UseVisualStyleBackColor = true;
            btndeactivate.Click += btndeactivate_Click;
            // 
            // btnactivate
            // 
            btnactivate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnactivate.Location = new Point(798, 619);
            btnactivate.Name = "btnactivate";
            btnactivate.Size = new Size(85, 33);
            btnactivate.TabIndex = 29;
            btnactivate.Text = "Activate";
            btnactivate.UseVisualStyleBackColor = true;
            btnactivate.Click += btnactivate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(340, 85);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 30;
            label2.Text = "Birthday from";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(734, 85);
            label3.Name = "label3";
            label3.Size = new Size(24, 21);
            label3.TabIndex = 31;
            label3.Text = "to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(392, 50);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 32;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(709, 50);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 33;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(906, 50);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 34;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 85);
            label7.Name = "label7";
            label7.Size = new Size(316, 21);
            label7.TabIndex = 35;
            label7.Text = "---------------------------------------------------";
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 676);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnactivate);
            Controls.Add(btndeactivate);
            Controls.Add(btnadd);
            Controls.Add(btnsearch);
            Controls.Add(dpkbirthdayto);
            Controls.Add(txtaddress);
            Controls.Add(txtphone);
            Controls.Add(label1);
            Controls.Add(dpkbirthdayfrom);
            Controls.Add(cmbstatus);
            Controls.Add(txtname);
            Controls.Add(lbltitle);
            Controls.Add(grddata);
            Controls.Add(grdheader);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUserManagement";
            StartPosition = FormStartPosition.Manual;
            Text = "frmUserManagement";
            ((System.ComponentModel.ISupportInitialize)grdheader).EndInit();
            ((System.ComponentModel.ISupportInitialize)grddata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private DataGridView grdheader;
        private DataGridView grddata;
        private Label lbltitle;
        private TextBox txtname;
        private ComboBox cmbstatus;
        private DateTimePicker dpkbirthdayfrom;
        private Label label1;
        private TextBox txtphone;
        private TextBox txtaddress;
        private DateTimePicker dpkbirthdayto;
        private Button btnsearch;
        private Button btnadd;
        private Button btndeactivate;
        private Button btnactivate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}