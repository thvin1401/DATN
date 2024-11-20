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

            var result = clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString());

            if (result.Count() == 1)
            {
                mdlMain.App.currentUser = result.First();
            }

            return result.Count() == 1;
        }

        public static bool isExistedUsername(string username)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from account where username = '{username}' ");

            return clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString()).Count() == 1;
        }

        public static bool isExistedEmail(string username, string email)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine($"select id from userinfo us join account ac on us.id = ac.userinfoid where email = '{email}' and username != '{username}'");

            return clsDBConnectionManager.Connection.Query<mdlAccount>(sSQL.ToString()).Any();
        }

        public static void createAccount(mdlAccount account, mdlUserInfo userInfo)
        {
            clsController.createUser(userInfo);

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

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void updateAccount(mdlAccount account, mdlUserInfo userInfo, bool isUpdatePassword)
        {
            clsController.updateUser(userInfo);

            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update account ");
            sSQL.AppendLine($"set ");
            sSQL.AppendLine($"isenabled = {account.isenabled}, ");
            sSQL.AppendLine($"accounttype = {account.accounttype}, ");
            sSQL.AppendLine($"updatedatetime = '{account.updatedatetime.ToString("yyyy-MM-dd")}' ");

            if (isUpdatePassword)
            {
                sSQL.AppendLine($",password = '{account.password}' ");
            }

            sSQL.AppendLine($"where username = '{account.username}'");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void changePassword(string username, string password)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"update account set password = '{password}', updatedatetime = '{DateTime.Now.ToString("yyyy-MM-dd")}' where username = '{username}'");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static bool checkEmailUsernameConsistency(string username, string email)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from account ac ");
            sSQL.AppendLine("join userinfo us on ac.userinfoid = us.id ");
            sSQL.AppendLine("where ac.isenabled = true and us.isactive = true ");
            sSQL.AppendLine($"and ac.username = '{username}' and us.email = '{email}' ");
            sSQL.AppendLine("limit 1");

            return clsDBConnectionManager.Connection.Query(sSQL.ToString()).Any();
        }

        public static List<dynamic> getAllAccountInfo(int type, int activation, string text)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select username, isenabled, accounttype, ac.createdatetime, ");
            sSQL.AppendLine("name, phone, email ");
            sSQL.AppendLine("from account ac ");
            sSQL.AppendLine("join userinfo us ");
            sSQL.AppendLine("on ac.userinfoid = us.id ");
            sSQL.AppendLine($"where accounttype = {type} and isenabled = {Convert.ToBoolean(activation)} ");

            if (!string.IsNullOrEmpty(text))
            {
                sSQL.AppendLine($"and (username like '%{text}%' ");
                sSQL.AppendLine($"or name like '%{text}%' ");
                sSQL.AppendLine($"or email like '%{text}%')");
            }

            return clsDBConnectionManager.Connection.Query<dynamic>(sSQL.ToString()).ToList();
        }

        public static void deactiveOrActivateAccount(string username, bool isActivate)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update account ");
            sSQL.AppendLine($"set isenabled = {isActivate} ");
            sSQL.AppendLine($"where username = '{username}' ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static dynamic getAccountInfoByUsername(string username)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from account ac ");
            sSQL.AppendLine("join userinfo us on ac.userinfoid = us.id ");
            sSQL.AppendLine($"where username = '{username}' ");

            return clsDBConnectionManager.Connection.Query<dynamic>(sSQL.ToString()).First();
        }
    }
}
