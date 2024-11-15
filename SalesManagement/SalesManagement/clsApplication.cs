using SalesManagement.model;

namespace SalesManagement
{
    public class clsApplication
    {
        public frmSplash frmSplash { get; private set; }

        public frmLogin frmLogin { get; private set; }

        public frmMainMenu frmMainMenu { get; private set; }

        public List<mdlRanking> ranks { get; private set; }

        public mdlAccount currentUser;

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
                ranks = clsRankingDM.getAllRankingData();
            }

            if(currentUser is null)
            {
                currentUser = new mdlAccount();
            }
        }

        private void UpdSplashMessage(string sMessage)
        {
            frmSplash.lblMessage.Text = sMessage;
            Application.DoEvents();
        }
    }
}
