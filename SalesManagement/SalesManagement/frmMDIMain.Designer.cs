﻿namespace SalesManagement
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
            SuspendLayout();
            // 
            // frmMDIMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1264, 681);
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "frmMDIMain";
            Text = "Sales Management v1.0";
            Shown += FrmMDIMain_Shown;
            ResumeLayout(false);
        }
        #endregion
    }
}
