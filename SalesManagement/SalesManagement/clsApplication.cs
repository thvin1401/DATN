namespace SalesManagement
{
    public class clsApplication
    {
        public frmSplash frmSplash { get; private set; }

        public frmLogin frmLogin { get; private set; }

        public clsApplication()
        {
            if(frmSplash is null)
            {
                frmSplash = new frmSplash();
            }

            if(frmLogin is null)
            {
                frmLogin = new frmLogin(); 
            }
        }

        private void UpdSplashMessage(string sMessage)
        {
            frmSplash.lblMessage.Text = sMessage;
            Application.DoEvents();
        }
    }
}
