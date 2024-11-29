using SalesManagement.model;

namespace SalesManagement
{
    public class clsApplication
    {
        public frmSplash frmSplash { get; private set; }

        public frmLogin frmLogin { get; private set; }

        public frmMainMenu frmMainMenu { get; private set; }

        public List<mdlRanking> ranks { get; private set; }

        public List<mdlCurrencyExchange> currencyExchange { get; private set; }

        public mdlAccount currentUser;

        public List<mdlSystemProperty> systemProperty;

        public clsApplication()
        {
            if(frmSplash is null)
            {
                frmSplash = new frmSplash();
            }

            if(frmLogin is null)
            {
                frmLogin = new frmLogin();
                frmLogin.MdiParent = mdlMain.frmMDIMain;
            }

            if(frmMainMenu is null)
            {
                frmMainMenu = new frmMainMenu();
                frmMainMenu.MdiParent = mdlMain.frmMDIMain;
            }

            if(ranks is null)
            {
                ranks = clsController.getAllRankingData();
            }

            if(currentUser is null)
            {
                currentUser = new mdlAccount();
            }

            if(currencyExchange is null)
            {
                currencyExchange = clsController.getAllCurrencyExchange();
            }

            if(systemProperty is null)
            {
                systemProperty = clsController.getAllSystemProperties();
            }
        }

        private void UpdSplashMessage(string sMessage)
        {
            frmSplash.lblMessage.Text = sMessage;
            Application.DoEvents();
        }
    }
}
