namespace SalesManagement
{
    partial class frmCreateUpdateNotes
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
            txtmessage = new TextBox();
            dpkreminddatetime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cmbisdone = new ComboBox();
            cmbisdeleted = new ComboBox();
            label3 = new Label();
            lbltitle = new Label();
            btnsave = new Button();
            btnback = new Button();
            SuspendLayout();
            // 
            // txtmessage
            // 
            txtmessage.BorderStyle = BorderStyle.FixedSingle;
            txtmessage.Location = new Point(123, 182);
            txtmessage.Name = "txtmessage";
            txtmessage.Size = new Size(200, 23);
            txtmessage.TabIndex = 0;
            // 
            // dpkreminddatetime
            // 
            dpkreminddatetime.Location = new Point(123, 83);
            dpkreminddatetime.Name = "dpkreminddatetime";
            dpkreminddatetime.Size = new Size(200, 23);
            dpkreminddatetime.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 2;
            label1.Text = "Remind Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 182);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "Message";
            // 
            // cmbisdone
            // 
            cmbisdone.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbisdone.FlatStyle = FlatStyle.Flat;
            cmbisdone.FormattingEnabled = true;
            cmbisdone.Location = new Point(123, 130);
            cmbisdone.Name = "cmbisdone";
            cmbisdone.Size = new Size(90, 23);
            cmbisdone.TabIndex = 4;
            cmbisdone.SelectedIndexChanged += cmbisdone_SelectedIndexChanged;
            // 
            // cmbisdeleted
            // 
            cmbisdeleted.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbisdeleted.FlatStyle = FlatStyle.Flat;
            cmbisdeleted.FormattingEnabled = true;
            cmbisdeleted.Location = new Point(231, 130);
            cmbisdeleted.Name = "cmbisdeleted";
            cmbisdeleted.Size = new Size(92, 23);
            cmbisdeleted.TabIndex = 5;
            cmbisdeleted.SelectedIndexChanged += cmbisdeleted_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 6;
            label3.Text = "Status";
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(12, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(311, 54);
            lbltitle.TabIndex = 16;
            lbltitle.Text = "Note update screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(123, 223);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 34);
            btnsave.TabIndex = 17;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(248, 224);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 34);
            btnback.TabIndex = 18;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // frmCreateUpdateNotes
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(336, 270);
            ControlBox = false;
            Controls.Add(btnback);
            Controls.Add(btnsave);
            Controls.Add(lbltitle);
            Controls.Add(label3);
            Controls.Add(cmbisdeleted);
            Controls.Add(cmbisdone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dpkreminddatetime);
            Controls.Add(txtmessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateUpdateNotes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmCreateUpdateNotes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmessage;
        private DateTimePicker dpkreminddatetime;
        private Label label1;
        private Label label2;
        private ComboBox cmbisdone;
        private ComboBox cmbisdeleted;
        private Label label3;
        private Label lbltitle;
        private Button btnsave;
        private Button btnback;
    }
}