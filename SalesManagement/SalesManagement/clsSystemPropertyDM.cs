using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsSystemPropertyDM
    {
        public static List<mdlSystemProperty> getAllSystemProperties()
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from systemproperty");

            return clsDBConnectionManager.Connection.Query<mdlSystemProperty>(sSQL.ToString()).ToList();
        }
    }
}
