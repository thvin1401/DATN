using SalesManagement.model;

namespace SalesManagement
{
    public class clsApplication
    {
        public frmSplash frmSplash { get; private set; }

        public frmLogin frmLogin { get; private set; }

        public List<mdlRanking> ranks { get; private set; }

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

            if(ranks is null)
            {
                ranks = clsRankingDM.getAllRankingData();
            }
        }

        private void UpdSplashMessage(string sMessage)
        {
            frmSplash.lblMessage.Text = sMessage;
            Application.DoEvents();
        }
    }
}
