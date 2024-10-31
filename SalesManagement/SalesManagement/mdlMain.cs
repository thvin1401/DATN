using System.Runtime.CompilerServices;

namespace SalesManagement
{
    public static class mdlMain
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(mdlMain));

        public static frmMDIMain frmMDIMain { get; private set; } = new frmMDIMain();
        public static clsApplication App { get; private set; } = new clsApplication();

        public static void Main(frmMDIMain mdiMain)
        {
            if(frmMDIMain == null)
                if(mdiMain!=null)  
                    frmMDIMain = mdiMain;

            App = new();
            App.frmSplash.MdiParent = frmMDIMain;
            App.frmSplash.Show();
            App.frmSplash.Activate();

            App.frmSplash.lblMessage.Text = "Connecting...";

            clsDBConnectionManager.Connection.Open();

            if(clsDBConnectionManager.Connection.State != System.Data.ConnectionState.Open)
            {
                App.frmSplash.lblMessage.Text = "Connection failed!";
                Application.Exit();
            }

            var xxx = clsAccountDM.getAccountLoggedIn("vinhth");

            //App.frmSplash.Close();

            //frmMDIMain.Show();
        }
    }
}
