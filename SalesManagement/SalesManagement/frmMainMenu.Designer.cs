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
            btnadjustment = new Button();
            btnlogout = new Button();
            btnaccountmanagement = new Button();
            btnsettings = new Button();
            btnsearchbilljournal = new Button();
            btndebtmanagement = new Button();
            btnusermanagement = new Button();
            btnproductmanagement = new Button();
            panel2 = new Panel();
            lblaccounttype = new Label();
            lbldate = new Label();
            lbltime = new Label();
            grdnote = new DataGridView();
            lblnotecount = new Label();
            dpkreminddatefrom = new DateTimePicker();
            dpkreminddateto = new DateTimePicker();
            btngetallnote = new Button();
            label1 = new Label();
            label2 = new Label();
            lblallnote = new Label();
            btnaddnotes = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdnote).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnadjustment);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnaccountmanagement);
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
            // btnadjustment
            // 
            btnadjustment.Cursor = Cursors.Hand;
            btnadjustment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnadjustment.Location = new Point(44, 115);
            btnadjustment.Name = "btnadjustment";
            btnadjustment.Size = new Size(231, 30);
            btnadjustment.TabIndex = 9;
            btnadjustment.Text = "Adjustment";
            btnadjustment.UseVisualStyleBackColor = true;
            btnadjustment.Click += btnadjustment_Click;
            // 
            // btnlogout
            // 
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogout.Location = new Point(44, 615);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(231, 30);
            btnlogout.TabIndex = 8;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnaccountmanagement
            // 
            btnaccountmanagement.Cursor = Cursors.Hand;
            btnaccountmanagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaccountmanagement.Location = new Point(44, 440);
            btnaccountmanagement.Name = "btnaccountmanagement";
            btnaccountmanagement.Size = new Size(231, 30);
            btnaccountmanagement.TabIndex = 7;
            btnaccountmanagement.Text = "Account Management";
            btnaccountmanagement.UseVisualStyleBackColor = true;
            btnaccountmanagement.Click += btnaccountmanagement_Click;
            // 
            // btnsettings
            // 
            btnsettings.Cursor = Cursors.Hand;
            btnsettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsettings.Location = new Point(44, 505);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(231, 30);
            btnsettings.TabIndex = 6;
            btnsettings.Text = "Settings";
            btnsettings.UseVisualStyleBackColor = true;
            btnsettings.Visible = false;
            btnsettings.Click += btnsettings_Click;
            // 
            // btnsearchbilljournal
            // 
            btnsearchbilljournal.Cursor = Cursors.Hand;
            btnsearchbilljournal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearchbilljournal.Location = new Point(44, 375);
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
            btndebtmanagement.Location = new Point(44, 310);
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
            btnusermanagement.Location = new Point(44, 245);
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
            btnproductmanagement.Location = new Point(44, 180);
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
            // grdnote
            // 
            grdnote.AllowUserToAddRows = false;
            grdnote.AllowUserToDeleteRows = false;
            grdnote.AllowUserToResizeRows = false;
            grdnote.BackgroundColor = SystemColors.Control;
            grdnote.BorderStyle = BorderStyle.Fixed3D;
            grdnote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdnote.ColumnHeadersVisible = false;
            grdnote.Location = new Point(366, 196);
            grdnote.Name = "grdnote";
            grdnote.ReadOnly = true;
            grdnote.RowHeadersVisible = false;
            grdnote.RowTemplate.Height = 25;
            grdnote.Size = new Size(859, 450);
            grdnote.TabIndex = 4;
            grdnote.CellDoubleClick += grdnote_CellDoubleClick;
            // 
            // lblnotecount
            // 
            lblnotecount.AutoSize = true;
            lblnotecount.Location = new Point(366, 158);
            lblnotecount.Name = "lblnotecount";
            lblnotecount.Size = new Size(77, 15);
            lblnotecount.TabIndex = 5;
            lblnotecount.Text = "0 reminder(s)";
            // 
            // dpkreminddatefrom
            // 
            dpkreminddatefrom.Location = new Point(622, 160);
            dpkreminddatefrom.Name = "dpkreminddatefrom";
            dpkreminddatefrom.Size = new Size(200, 23);
            dpkreminddatefrom.TabIndex = 6;
            // 
            // dpkreminddateto
            // 
            dpkreminddateto.Location = new Point(877, 160);
            dpkreminddateto.Name = "dpkreminddateto";
            dpkreminddateto.Size = new Size(200, 23);
            dpkreminddateto.TabIndex = 7;
            // 
            // btngetallnote
            // 
            btngetallnote.Location = new Point(1092, 160);
            btngetallnote.Name = "btngetallnote";
            btngetallnote.Size = new Size(75, 23);
            btngetallnote.TabIndex = 8;
            btngetallnote.Text = "All notes";
            btngetallnote.UseVisualStyleBackColor = true;
            btngetallnote.Click += btngetallnote_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 164);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 10;
            label1.Text = "From :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(846, 164);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 11;
            label2.Text = "To :";
            // 
            // lblallnote
            // 
            lblallnote.AutoSize = true;
            lblallnote.Location = new Point(1184, 164);
            lblallnote.Name = "lblallnote";
            lblallnote.Size = new Size(21, 15);
            lblallnote.TabIndex = 12;
            lblallnote.Text = "All";
            // 
            // btnaddnotes
            // 
            btnaddnotes.Cursor = Cursors.Hand;
            btnaddnotes.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddnotes.ForeColor = SystemColors.Highlight;
            btnaddnotes.Location = new Point(446, 137);
            btnaddnotes.Margin = new Padding(0);
            btnaddnotes.Name = "btnaddnotes";
            btnaddnotes.Size = new Size(57, 51);
            btnaddnotes.TabIndex = 13;
            btnaddnotes.Text = "+";
            btnaddnotes.TextAlign = ContentAlignment.MiddleCenter;
            btnaddnotes.Click += btnaddnotes_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1258, 676);
            Controls.Add(btnaddnotes);
            Controls.Add(lblallnote);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btngetallnote);
            Controls.Add(dpkreminddateto);
            Controls.Add(dpkreminddatefrom);
            Controls.Add(lblnotecount);
            Controls.Add(grdnote);
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
            ((System.ComponentModel.ISupportInitialize)grdnote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbldate;
        private Label lbltime;
        private DataGridView grdnote;
        private Label lblaccounttype;
        private Button btnproductmanagement;
        private Button btnusermanagement;
        private Button btndebtmanagement;
        private Button btnsearchbilljournal;
        private Button btnsettings;
        private Button btnaccountmanagement;
        private Button btnlogout;
        private Label lblnotecount;
        private DateTimePicker dpkreminddatefrom;
        private DateTimePicker dpkreminddateto;
        private Button btngetallnote;
        private Label label1;
        private Label label2;
        private Label lblallnote;
        private Label btnaddnotes;
        private Button btnadjustment;
    }
}