using Dapper;
using SalesManagement.model;
using System.Security.Principal;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalesManagement
{
    public static class clsAccountDM
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsAccountDM));

        public static bool getAccountLoggedIn(string username, string password)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from account where username = '{username}' and password = '{password}' and isenabled = true");

            var result = clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString());

            if (result.Any())
            {
                mdlMain.App.currentUser = result.First();
                return true;
            }

            return false;
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
            sSQL.AppendLine($"{account.isenabled},");
            sSQL.AppendLine($"{account.accounttype},");
            sSQL.AppendLine($"'{account.createdatetime.ToString("yyyy-MM-dd")}',");
            sSQL.AppendLine($"'{account.updatedatetime.ToString("yyyy-MM-dd")}')");

            try
            {
                clsDBConnectionManager.Connection.Query(sSQL.ToString());
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static bool changePassword(string username, string password)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"update account set password = '{password}', updatedatetime = '{DateTime.Now.ToString("yyyy-MM-dd")}' where username = '{username}'");

            try
            {
                clsDBConnectionManager.Connection.Query(sSQL.ToString());
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static bool checkEmailUsernameConsistency(string username, string email)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from account ac ");
            sSQL.AppendLine("join userinfo us on ac.userinfoid = us.id ");
            sSQL.AppendLine("where ac.isenabled = true and us.isactive = true ");
            sSQL.AppendLine($"and ac.username = '{username}' and us.email = '{email}' ");
            sSQL.AppendLine("limit 1");

            try
            {
                return clsDBConnectionManager.Connection.Query(sSQL.ToString()).Any();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }
    }
}
