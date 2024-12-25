namespace SalesManagement
{
    partial class frmAccountManagement
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
            txtsearch = new TextBox();
            btnsearch = new Button();
            label12 = new Label();
            cmbtype = new ComboBox();
            cmbactivation = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnedit = new Button();
            btnregister = new Button();
            btndeactive = new Button();
            btnactivate = new Button();
            ((System.ComponentModel.ISupportInitialize)grdheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grddata).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(1146, 617);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 31);
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
            grdheader.BackgroundColor = SystemColors.Control;
            grdheader.BorderStyle = BorderStyle.Fixed3D;
            grdheader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdheader.ColumnHeadersVisible = false;
            grdheader.Location = new Point(35, 87);
            grdheader.Margin = new Padding(0);
            grdheader.Name = "grdheader";
            grdheader.ReadOnly = true;
            grdheader.RowHeadersVisible = false;
            grdheader.RowTemplate.Height = 25;
            grdheader.Size = new Size(1186, 30);
            grdheader.TabIndex = 1;
            // 
            // grddata
            // 
            grddata.AllowUserToAddRows = false;
            grddata.AllowUserToDeleteRows = false;
            grddata.AllowUserToResizeColumns = false;
            grddata.AllowUserToResizeRows = false;
            grddata.BackgroundColor = SystemColors.Control;
            grddata.BorderStyle = BorderStyle.Fixed3D;
            grddata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grddata.ColumnHeadersVisible = false;
            grddata.Location = new Point(35, 114);
            grddata.Margin = new Padding(0);
            grddata.Name = "grddata";
            grddata.ReadOnly = true;
            grddata.RowHeadersVisible = false;
            grddata.RowTemplate.Height = 25;
            grddata.Size = new Size(1186, 480);
            grddata.TabIndex = 2;
            grddata.CellContentClick += grddata_CellContentClick;
            // 
            // txtsearch
            // 
            txtsearch.BorderStyle = BorderStyle.FixedSingle;
            txtsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtsearch.Location = new Point(843, 38);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search name, username, email...";
            txtsearch.Size = new Size(275, 29);
            txtsearch.TabIndex = 5;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(1146, 38);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 29);
            btnsearch.TabIndex = 6;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // label12
            // 
            label12.BackColor = Color.Blue;
            label12.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Aqua;
            label12.Location = new Point(35, 13);
            label12.Name = "label12";
            label12.Size = new Size(311, 54);
            label12.TabIndex = 16;
            label12.Text = "Account Management";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbtype
            // 
            cmbtype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtype.FlatStyle = FlatStyle.Flat;
            cmbtype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbtype.FormattingEnabled = true;
            cmbtype.Location = new Point(439, 37);
            cmbtype.Name = "cmbtype";
            cmbtype.Size = new Size(135, 29);
            cmbtype.TabIndex = 17;
            cmbtype.SelectedIndexChanged += cmbtype_SelectedIndexChanged;
            // 
            // cmbactivation
            // 
            cmbactivation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbactivation.FlatStyle = FlatStyle.Flat;
            cmbactivation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbactivation.FormattingEnabled = true;
            cmbactivation.Location = new Point(665, 37);
            cmbactivation.Name = "cmbactivation";
            cmbactivation.Size = new Size(145, 29);
            cmbactivation.TabIndex = 18;
            cmbactivation.SelectedIndexChanged += cmbactivation_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(391, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 19;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(580, 41);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 20;
            label2.Text = "Activation";
            // 
            // btnedit
            // 
            btnedit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnedit.Location = new Point(819, 617);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 32);
            btnedit.TabIndex = 22;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnregister
            // 
            btnregister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnregister.Location = new Point(709, 617);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(84, 31);
            btnregister.TabIndex = 23;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click;
            // 
            // btndeactive
            // 
            btndeactive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndeactive.Location = new Point(922, 617);
            btndeactive.Name = "btndeactive";
            btndeactive.Size = new Size(86, 31);
            btndeactive.TabIndex = 24;
            btndeactive.Text = "Deactive";
            btndeactive.UseVisualStyleBackColor = true;
            btndeactive.Click += btndeactive_Click;
            // 
            // btnactivate
            // 
            btnactivate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnactivate.Location = new Point(1037, 617);
            btnactivate.Name = "btnactivate";
            btnactivate.Size = new Size(81, 31);
            btnactivate.TabIndex = 25;
            btnactivate.Text = "Activate";
            btnactivate.UseVisualStyleBackColor = true;
            btnactivate.Click += btnactivate_Click;
            // 
            // frmAccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 676);
            Controls.Add(btnactivate);
            Controls.Add(btndeactive);
            Controls.Add(btnregister);
            Controls.Add(btnedit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbactivation);
            Controls.Add(cmbtype);
            Controls.Add(label12);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(grddata);
            Controls.Add(grdheader);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccountManagement";
            StartPosition = FormStartPosition.Manual;
            Text = "frmAccountManagement";
            ((System.ComponentModel.ISupportInitialize)grdheader).EndInit();
            ((System.ComponentModel.ISupportInitialize)grddata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private DataGridView grdheader;
        private DataGridView grddata;
        private TextBox txtsearch;
        private Button btnsearch;
        private Label label12;
        private ComboBox cmbtype;
        private ComboBox cmbactivation;
        private Label label1;
        private Label label2;
        private Button btnedit;
        private Button btnregister;
        private Button btndeactive;
        private Button btnactivate;
    }
}