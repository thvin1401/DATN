using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsAccountDM
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsAccountDM));

        public static mdlAccount getAccountLoggedIn(string username)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from account where username = '{username}'");

            return clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString()).FirstOrDefault();
        }

        public static void createAccount(mdlAccount account, mdlUserInfo userInfo)
        {
            clsUserInfoDM.createUser(userInfo);

            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into account");
            sSQL.AppendLine($"values (");
            sSQL.AppendLine($"'{account.id}',");
            sSQL.AppendLine($"'{account.username}',");
            sSQL.AppendLine($"'{account.password}',");
            sSQL.AppendLine($"'{userInfo.id}',");
            sSQL.AppendLine($"'{account.createdatetime.ToString("yyyy-MM-dd")}'");
            sSQL.AppendLine($"'{account.updatedatetime.ToString("yyyy-MM-dd")}'");
            sSQL.AppendLine($"{true}");

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
