using System.Runtime.CompilerServices;

namespace SalesManagement
{
    public static class mdlMain
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(mdlMain));

        public static frmMDIMain frmMDIMain { get; private set; }
        public static clsApplication App { get; private set; }

        public static void Main(frmMDIMain mdiMain)
        {
            if(frmMDIMain == null)
                if(mdiMain!=null)  
                    frmMDIMain = mdiMain;
            if(App is null)
            {
                App = new clsApplication();
            }
            /*App.frmSplash.MdiParent = frmMDIMain;
            App.frmSplash.Show();
            App.frmSplash.Activate();*/

            //App.frmSplash.lblMessage.Text = "Connecting...";

            clsDBConnectionManager.Connection.Open();

            if(clsDBConnectionManager.Connection.State != System.Data.ConnectionState.Open)
            {
                App.frmSplash.lblMessage.Text = "Connection failed!";
                Application.Exit();
            }

            App.frmLogin.MdiParent = frmMDIMain;
            App.frmLogin.Show();

            //App.frmSplash.Close();

            //frmMDIMain.Show();
        }
    }
}
