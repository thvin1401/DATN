using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsUserInfoDM
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsUserInfoDM));
        public static void createUser(mdlUserInfo userInfo)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into userinfo");
            sSQL.AppendLine("values(");
            sSQL.AppendLine($"'{userInfo.id}'");
            sSQL.AppendLine($"'{userInfo.name}'");
            sSQL.AppendLine($"'{userInfo.address}'");
            sSQL.AppendLine($"'{userInfo.phone}'");
            sSQL.AppendLine($"'{userInfo.email}'");
            sSQL.AppendLine($"'{Guid.Empty}'");
            sSQL.AppendLine($"{true}");
            sSQL.AppendLine($"{0}");
            sSQL.AppendLine($"'{userInfo.createdatetime.ToString("yyyy-MM-dd")}'");
            sSQL.AppendLine($"{userInfo.updatedatetime.ToString("yyyy-MM-dd")}");

            try
            {
                clsDBConnectionManager.Connection.Query(sSQL.ToString());
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
