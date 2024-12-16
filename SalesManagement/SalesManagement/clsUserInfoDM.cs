using Dapper;
using SalesManagement.model;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesManagement
{
    public static class clsUserInfoDM
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsUserInfoDM));
        public static void createUser(mdlUserInfo userInfo)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into userinfo ");
            sSQL.AppendLine("values(");
            sSQL.AppendLine($"'{userInfo.id}',");
            sSQL.AppendLine($"'{userInfo.name}',");
            sSQL.AppendLine($"'{userInfo.address}',");
            sSQL.AppendLine($"'{userInfo.phone}',");
            sSQL.AppendLine($"'{userInfo.email}',");
            sSQL.AppendLine($"'{userInfo.rankid}',");
            sSQL.AppendLine($"{userInfo.isactive},");
            sSQL.AppendLine($"{userInfo.point},");
            sSQL.AppendLine($"{userInfo.type},");
            sSQL.AppendLine($"'{userInfo.createdatetime.ToString("yyyy-MM-dd")}',");
            sSQL.AppendLine($"'{userInfo.updatedatetime.ToString("yyyy-MM-dd")}',");
            sSQL.AppendLine($"'{userInfo.birthday.ToString("yyyy-MM-dd")}')");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void updateUser(mdlUserInfo userInfo)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update userinfo ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine($"name = '{userInfo.name}', ");
            sSQL.AppendLine($"address = '{userInfo.address}', ");
            sSQL.AppendLine($"phone = '{userInfo.phone}', ");
            sSQL.AppendLine($"email = '{userInfo.email}', ");
            sSQL.AppendLine($"isactive = {userInfo.isactive}, ");
            sSQL.AppendLine($"type ={userInfo.type}, ");
            sSQL.AppendLine($"updatedatetime = '{userInfo.updatedatetime.ToString("yyyy-MM-dd")}', ");
            sSQL.AppendLine($"birthday = '{userInfo.birthday.ToString("yyyy-MM-dd")}' ");
            sSQL.AppendLine($"where id = '{userInfo.id}' ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void updateUserPointAndRank(mdlUserInfo userInfo)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update userinfo ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine($"point = {userInfo.point}, ");
            sSQL.AppendLine($"rankid = '{userInfo.rankid.ToString()}', ");
            sSQL.AppendLine($"updatedatetime = '{userInfo.updatedatetime.ToString("yyyy-MM-dd")}' ");
            sSQL.AppendLine($"where id = '{userInfo.id}' ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static List<mdlUserInfo> getAllUsers(string? name = null, int? type = null, int? typeExcept = null)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine("select * from userinfo where isactive = true ");

            if(string.IsNullOrEmpty(name))
            {
                sSQL.AppendLine($"and name like '%{name}%' ");
            }

            if(type != null)
            {
                sSQL.AppendLine($"and type = {type} ");
            }

            if (typeExcept != null)
            {
                sSQL.AppendLine($"and type != {typeExcept} ");
            }

            sSQL.AppendLine("order by name, type");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).ToList();
        }

        public static bool checkExistEmail(string email)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine($"select * from userinfo where email = '{email}' ");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).Any();
        }

        public static List<mdlUserInfo> getAllUserCanCreateAccount()
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine("select * from userinfo ");
            sSQL.AppendLine("where not exists (select 1 from account where userinfoid = id) ");
            sSQL.AppendLine("and type in (0, 1) and isactive = true");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).ToList();
        }

        public static mdlUserInfo getUserInfoByBillReceiptNumber(int receiptNumber)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine("select * from userinfo us");
            sSQL.AppendLine("join bill b on us.id = b.userinfoid ");
            sSQL.AppendLine($"where b.receiptnumber = {receiptNumber} ");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).First();
        }
    }
}
