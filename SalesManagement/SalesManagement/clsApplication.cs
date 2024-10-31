namespace SalesManagement
{
    public class clsApplication
    {
        private frmSplash _frmSplash;

        public frmSplash frmSplash
        {
            get
            {
                if (_frmSplash is null)
                    _frmSplash = new();

                return _frmSplash;
            }
        }

        private void UpdSplashMessage(string sMessage)
        {
            frmSplash.lblMessage.Text = sMessage;
            Application.DoEvents();
        }
    }
}
