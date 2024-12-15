namespace SalesManagement
{
    partial class frmMDIMain : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIMain));
            panel1 = new Panel();
            lblactivestatus = new Label();
            lblactivestatusstring = new Label();
            lblmessage = new Label();
            lblipadress = new Label();
            lbldesktopname = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblactivestatus);
            panel1.Controls.Add(lblactivestatusstring);
            panel1.Controls.Add(lblmessage);
            panel1.Controls.Add(lblipadress);
            panel1.Controls.Add(lbldesktopname);
            panel1.Location = new Point(0, 680);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 30);
            panel1.TabIndex = 1;
            // 
            // lblactivestatus
            // 
            lblactivestatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblactivestatus.Location = new Point(1172, 0);
            lblactivestatus.Name = "lblactivestatus";
            lblactivestatus.Size = new Size(27, 28);
            lblactivestatus.TabIndex = 4;
            lblactivestatus.Text = "•";
            lblactivestatus.TextAlign = ContentAlignment.TopRight;
            // 
            // lblactivestatusstring
            // 
            lblactivestatusstring.Location = new Point(1198, 0);
            lblactivestatusstring.Name = "lblactivestatusstring";
            lblactivestatusstring.Size = new Size(62, 28);
            lblactivestatusstring.TabIndex = 3;
            lblactivestatusstring.Text = "Online";
            lblactivestatusstring.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblmessage
            // 
            lblmessage.BorderStyle = BorderStyle.Fixed3D;
            lblmessage.Location = new Point(304, 0);
            lblmessage.Name = "lblmessage";
            lblmessage.Size = new Size(862, 28);
            lblmessage.TabIndex = 2;
            lblmessage.Text = "label1";
            lblmessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblipadress
            // 
            lblipadress.BorderStyle = BorderStyle.Fixed3D;
            lblipadress.Location = new Point(210, 0);
            lblipadress.Name = "lblipadress";
            lblipadress.Size = new Size(96, 28);
            lblipadress.TabIndex = 1;
            lblipadress.Text = "192.168.88.88";
            lblipadress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldesktopname
            // 
            lbldesktopname.BorderStyle = BorderStyle.Fixed3D;
            lbldesktopname.Location = new Point(-2, 0);
            lbldesktopname.Name = "lbldesktopname";
            lbldesktopname.Size = new Size(212, 28);
            lbldesktopname.TabIndex = 0;
            lbldesktopname.Text = "DESKTOP - 1";
            lbldesktopname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmMDIMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 711);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "frmMDIMain";
            Text = "Sales Management v1.0";
            Shown += FrmMDIMain_Shown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel panel1;
        private Label lbldesktopname;
        private Label lblipadress;
        public Label lblmessage;
        public Label lblactivestatusstring;
        public Label lblactivestatus;
    }
}
