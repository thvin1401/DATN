using System.Configuration;

namespace SalesManagement
{
    public static class clsConfig
    {
        public static string ConnectionString => ConfigurationManager.AppSettings["connectionString"] + "";
        public static int amountPerPoint = 200000;
    }
}
