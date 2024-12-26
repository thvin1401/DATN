namespace SalesManagement
{
    partial class frmEmailVeryfication
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
            label1 = new Label();
            txtcode = new TextBox();
            btnverify = new Button();
            btncancel = new Button();
            label2 = new Label();
            lblmessage = new Label();
            btnresend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 79);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter Code";
            // 
            // txtcode
            // 
            txtcode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcode.Location = new Point(124, 76);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(183, 29);
            txtcode.TabIndex = 1;
            // 
            // btnverify
            // 
            btnverify.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnverify.Location = new Point(32, 146);
            btnverify.Name = "btnverify";
            btnverify.Size = new Size(75, 34);
            btnverify.TabIndex = 2;
            btnverify.Text = "Verify";
            btnverify.UseVisualStyleBackColor = true;
            btnverify.Click += btnverify_Click;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancel.Location = new Point(232, 146);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 34);
            btncancel.TabIndex = 3;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(32, 24);
            label2.Name = "label2";
            label2.Size = new Size(275, 40);
            label2.TabIndex = 4;
            label2.Text = "4-digit Code Verification";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblmessage
            // 
            lblmessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblmessage.Location = new Point(32, 112);
            lblmessage.Name = "lblmessage";
            lblmessage.Size = new Size(275, 21);
            lblmessage.TabIndex = 5;
            lblmessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnresend
            // 
            btnresend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnresend.Location = new Point(133, 146);
            btnresend.Name = "btnresend";
            btnresend.Size = new Size(75, 34);
            btnresend.TabIndex = 6;
            btnresend.Text = "Resend";
            btnresend.UseVisualStyleBackColor = true;
            btnresend.Click += btnresend_Click;
            // 
            // frmEmailVeryfication
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(340, 207);
            ControlBox = false;
            Controls.Add(btnresend);
            Controls.Add(lblmessage);
            Controls.Add(label2);
            Controls.Add(btncancel);
            Controls.Add(btnverify);
            Controls.Add(txtcode);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmailVeryfication";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmEmailVeryfication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtcode;
        private Button btnverify;
        private Button btncancel;
        private Label label2;
        private Label lblmessage;
        private Button btnresend;
    }
}