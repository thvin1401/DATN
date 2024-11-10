using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsAccountDM
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsAccountDM));

        public static bool getAccountLoggedIn(string username, string password)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from account where username = '{username}' and password = '{password}' and isenabled = true");

            return clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString()).Any();
        }

        public static bool isExistedUsername(string username)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from account where username = '{username}' and isenabled = true");

            return clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString()).Any();
        }

        public static bool isExistedEmail(string email)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine($"select id from userinfo where email = '{email}' and isactive = true limit 1");

            var userinfoId = clsDBConnectionManager.Connection.Query<Guid>(sSQL.ToString());

            if (userinfoId.Any())
            {
                sSQL = new StringBuilder();
                sSQL.AppendLine($"select * from account where userinfoid = '{userinfoId.First()}' and isenabled = true");

                return clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString()).Any();
            }

            return false;
        }

        public static void createAccount(mdlAccount account, mdlUserInfo userInfo)
        {
            clsUserInfoDM.createUser(userInfo);

            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into account");
            sSQL.AppendLine($"values (");
            sSQL.AppendLine($"'{account.username}',");
            sSQL.AppendLine($"'{account.password}',");
            sSQL.AppendLine($"'{userInfo.id}',");
            sSQL.AppendLine($"'{account.createdatetime.ToString("yyyy-MM-dd")}',");
            sSQL.AppendLine($"'{account.updatedatetime.ToString("yyyy-MM-dd")}',");
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
