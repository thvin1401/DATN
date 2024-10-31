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

            
        }
    }
}
