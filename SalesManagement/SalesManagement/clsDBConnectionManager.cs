using Npgsql;
using System.Data;

namespace SalesManagement
{
    public static class clsDBConnectionManager
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsDBConnectionManager));

        public static IDbConnection Connection { get; set; } = new NpgsqlConnection(clsConfig.ConnectionString);
    }
}
