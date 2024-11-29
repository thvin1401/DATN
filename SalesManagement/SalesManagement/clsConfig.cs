using System.Configuration;

namespace SalesManagement
{
    public static class clsConfig
    {
        public static string ConnectionString => ConfigurationManager.AppSettings["connectionString"] + "";

        public static int amountPerPoint = Convert.ToInt32(mdlMain.App.systemProperty.First(x=>x.name == "AmountPerPoint").value);

        public static string systemEmail = mdlMain.App.systemProperty.First(x => x.name == "SystemEmail").value;

        public static string systemEmailPassword = mdlMain.App.systemProperty.First(x => x.name == "SystemEmailPassword").value;

        public static string smtpClient = mdlMain.App.systemProperty.First(x => x.name == "SMTPClient").value;

        public static string messageErrorTryAgain = mdlMain.App.systemProperty.First(x => x.name == "MessageErrorTryAgain").value;

        public static string messageNoData = mdlMain.App.systemProperty.First(x => x.name == "MessageNoData").value;

        public static string messageUpdateSuccessfully = mdlMain.App.systemProperty.First(x => x.name == "MessageUpdateSuccessfully").value;

        public static string messageCreateSuccessfully = mdlMain.App.systemProperty.First(x => x.name == "MessageCreateSuccessfully").value;

        public static string messageProcessFailed = mdlMain.App.systemProperty.First(x => x.name == "MessageProcessFailed").value;
    }
}
