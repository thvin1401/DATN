namespace SalesManagement
{
    public partial class frmMDIMain : Form
    {
        private System.Windows.Forms.Timer timer;
        public frmMDIMain()
        {
            InitializeComponent();

            lblmessage.Text = "";
            lblactivestatus.Text = "";
            lblactivestatusstring.Text = "";
            lbldesktopname.Text = Environment.MachineName;
            lblipadress.Text = clsUtility.GetIpAddress();

            updateOnlineStatus();

            timer = new System.Windows.Forms.Timer
            {
                Interval = 5000
            };

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void updateOnlineStatus()
        {
            if (clsUtility.IsConnectedToInternet())
            {
                lblactivestatus.Text = "•";
                lblactivestatus.ForeColor = Color.LimeGreen;
                lblactivestatusstring.Text = "Online";
                lblactivestatusstring.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblactivestatus.Text = "•";
                lblactivestatus.ForeColor = Color.Red;
                lblactivestatusstring.Text = "Offline";
                lblactivestatusstring.ForeColor = Color.Red;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            updateOnlineStatus();
        }

        private void FrmMDIMain_Shown(object sender, EventArgs e)
        {
            mdlMain.Main(this);
        }
    }
}
