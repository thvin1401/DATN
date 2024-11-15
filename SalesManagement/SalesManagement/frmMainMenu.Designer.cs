namespace SalesManagement
{
    partial class frmMainMenu
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
            panel1 = new Panel();
            btnsettings = new Button();
            btnsearchbilljournal = new Button();
            btndebtmanagement = new Button();
            btnusermanagement = new Button();
            btnproductmanagement = new Button();
            panel2 = new Panel();
            lblaccounttype = new Label();
            lbldate = new Label();
            lbltime = new Label();
            grdheader = new DataGridView();
            grdnote = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdnote).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnsettings);
            panel1.Controls.Add(btnsearchbilljournal);
            panel1.Controls.Add(btndebtmanagement);
            panel1.Controls.Add(btnusermanagement);
            panel1.Controls.Add(btnproductmanagement);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 679);
            panel1.TabIndex = 0;
            // 
            // btnsettings
            // 
            btnsettings.Cursor = Cursors.Hand;
            btnsettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsettings.Location = new Point(44, 385);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(231, 30);
            btnsettings.TabIndex = 6;
            btnsettings.Text = "Settings";
            btnsettings.UseVisualStyleBackColor = true;
            btnsettings.Click += btnsettings_Click;
            // 
            // btnsearchbilljournal
            // 
            btnsearchbilljournal.Cursor = Cursors.Hand;
            btnsearchbilljournal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearchbilljournal.Location = new Point(44, 320);
            btnsearchbilljournal.Name = "btnsearchbilljournal";
            btnsearchbilljournal.Size = new Size(231, 30);
            btnsearchbilljournal.TabIndex = 5;
            btnsearchbilljournal.Text = "Search Bill Journal";
            btnsearchbilljournal.UseVisualStyleBackColor = true;
            btnsearchbilljournal.Click += btnsearchbilljournal_Click;
            // 
            // btndebtmanagement
            // 
            btndebtmanagement.Cursor = Cursors.Hand;
            btndebtmanagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndebtmanagement.Location = new Point(44, 255);
            btndebtmanagement.Name = "btndebtmanagement";
            btndebtmanagement.Size = new Size(231, 30);
            btndebtmanagement.TabIndex = 4;
            btndebtmanagement.Text = "Debt Management";
            btndebtmanagement.UseVisualStyleBackColor = true;
            btndebtmanagement.Click += btndebtmanagement_Click;
            // 
            // btnusermanagement
            // 
            btnusermanagement.Cursor = Cursors.Hand;
            btnusermanagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnusermanagement.Location = new Point(44, 190);
            btnusermanagement.Name = "btnusermanagement";
            btnusermanagement.Size = new Size(231, 30);
            btnusermanagement.TabIndex = 3;
            btnusermanagement.Text = "User Management";
            btnusermanagement.UseVisualStyleBackColor = true;
            btnusermanagement.Click += btnusermanagement_Click;
            // 
            // btnproductmanagement
            // 
            btnproductmanagement.Cursor = Cursors.Hand;
            btnproductmanagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnproductmanagement.Location = new Point(44, 125);
            btnproductmanagement.Name = "btnproductmanagement";
            btnproductmanagement.Size = new Size(231, 30);
            btnproductmanagement.TabIndex = 2;
            btnproductmanagement.Text = "Product Management";
            btnproductmanagement.UseVisualStyleBackColor = true;
            btnproductmanagement.Click += btnproductmanagement_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaptionText;
            panel2.Controls.Add(lblaccounttype);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 87);
            panel2.TabIndex = 1;
            // 
            // lblaccounttype
            // 
            lblaccounttype.AutoSize = true;
            lblaccounttype.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblaccounttype.ForeColor = Color.Transparent;
            lblaccounttype.Location = new Point(100, 20);
            lblaccounttype.Name = "lblaccounttype";
            lblaccounttype.Size = new Size(113, 45);
            lblaccounttype.TabIndex = 0;
            lblaccounttype.Text = "Owner";
            lblaccounttype.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbldate
            // 
            lbldate.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbldate.Location = new Point(499, -1);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(572, 82);
            lbldate.TabIndex = 1;
            lbldate.Text = "Fri, 15 November 2024";
            lbldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltime
            // 
            lbltime.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbltime.Location = new Point(718, 81);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(144, 65);
            lbltime.TabIndex = 2;
            lbltime.Text = "14:21";
            lbltime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grdheader
            // 
            grdheader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdheader.Location = new Point(366, 164);
            grdheader.Name = "grdheader";
            grdheader.RowTemplate.Height = 25;
            grdheader.Size = new Size(859, 39);
            grdheader.TabIndex = 3;
            // 
            // grdnote
            // 
            grdnote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdnote.Location = new Point(366, 200);
            grdnote.Name = "grdnote";
            grdnote.RowTemplate.Height = 25;
            grdnote.Size = new Size(859, 446);
            grdnote.TabIndex = 4;
            // 
            // frmMainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1258, 676);
            Controls.Add(grdnote);
            Controls.Add(grdheader);
            Controls.Add(lbltime);
            Controls.Add(lbldate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainMenu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "frmMainMenu";
            Load += FrmMainMenu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdheader).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdnote).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbldate;
        private Label lbltime;
        private DataGridView grdheader;
        private DataGridView grdnote;
        private Label lblaccounttype;
        private Button btnproductmanagement;
        private Button btnusermanagement;
        private Button btndebtmanagement;
        private Button btnsearchbilljournal;
        private Button btnsettings;
    }
}