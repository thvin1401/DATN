namespace SalesManagement
{
    public partial class frmMDIMain : Form
    {
        public frmMDIMain()
        {
            InitializeComponent();
        }


        private void FrmMDIMain_Shown(object sender, EventArgs e)
        {
            mdlMain.Main(this);
        }
    }
}
