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

        public static List<mdlUserInfo> getAllUsersNoCondition()
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine("select * from userinfo ");

            sSQL.AppendLine("order by name, type");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).ToList();
        }

        public static bool checkExistEmail(string email, string? exceptId = null)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine($"select * from userinfo where email = '{email}' ");

            if (!string.IsNullOrEmpty(exceptId))
            {
                sSQL.AppendLine($"and id != '{exceptId}' ");

            }

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

            sSQL.AppendLine("select * from userinfo us ");
            sSQL.AppendLine("join bill b on us.id = b.userinfoid ");
            sSQL.AppendLine($"where b.receiptnumber = {receiptNumber} ");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).First();
        }

        public static mdlUserInfo getUserInfoById(string userId)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine("select * from userinfo ");
            sSQL.AppendLine($"where id = '{userId}' ");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).First();
        }

        public static List<dynamic> getListUserInfoByFullCondition(DateTime birthdayFrom, DateTime birthdayTo, int status, string? fullName = null, string? address = null, string? phone = null)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine("select us.id, ");
            sSQL.AppendLine("us.name, ");
            sSQL.AppendLine("us.address, ");
            sSQL.AppendLine("us.phone, ");
            sSQL.AppendLine("us.email, ");
            sSQL.AppendLine("us.isactive, ");
            sSQL.AppendLine("us.point, ");
            sSQL.AppendLine("us.type, ");
            sSQL.AppendLine("us.birthday, ");
            sSQL.AppendLine("r.name as rank, ");
            sSQL.AppendLine("COALESCE(SUM(CASE WHEN B.BILLTYPE = 0 THEN B.PAYAMOUNT END), 0) AS TOTALPURCHASE, ");
            sSQL.AppendLine("COALESCE(SUM(CASE WHEN B.BILLTYPE = 2 and dm.type = 0 THEN B.PAYAMOUNT ELSE 0 END) - COALESCE(SUM(CASE WHEN B.BILLTYPE = 2 and dm.type = 0 THEN p.AMOUNT ELSE 0 END), 0)) AS TOTALDEBT, ");
            sSQL.AppendLine("COALESCE(SUM(CASE WHEN B.BILLTYPE = 2 and dm.type = 1 THEN B.PAYAMOUNT ELSE 0 END) - COALESCE(SUM(CASE WHEN B.BILLTYPE = 2 and dm.type = 1 THEN p.AMOUNT ELSE 0 END), 0)) AS TOTALLEND ");
            sSQL.AppendLine("from userinfo us ");
            sSQL.AppendLine("join ranking r on us.rankid = r.id ");
            sSQL.AppendLine("join bill b on us.id = b.userinfoid ");
            sSQL.AppendLine("left join debtmanager dm on dm.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine("left join payment p on p.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine("where ");
            sSQL.AppendLine("us.type != 0 ");
            sSQL.AppendLine("and b.isdeleted = false and billtype != 1 ");
            sSQL.AppendLine($"and (birthday >= '{birthdayFrom.ToString("yyyy-MM-dd 00:00:00")}' ");
            sSQL.AppendLine($"and birthday <= '{birthdayTo.ToString("yyyy-MM-dd 23:59:59")}') ");
            sSQL.AppendLine($"and us.isactive = {Convert.ToBoolean(status)} ");

            if (!string.IsNullOrEmpty(fullName))
            {
                sSQL.AppendLine($"and name like '%{fullName}%' ");
            }
            if (!string.IsNullOrEmpty(address))
            {
                sSQL.AppendLine($"and name like '%{address}%' ");
            }
            if (!string.IsNullOrEmpty(phone))
            {
                sSQL.AppendLine($"and name like '%{phone}%' ");
            }

            sSQL.AppendLine("group by us.id, ");
            sSQL.AppendLine("us.name, ");
            sSQL.AppendLine("us.address, ");
            sSQL.AppendLine("us.phone, ");
            sSQL.AppendLine("us.email, ");
            sSQL.AppendLine("us.isactive, ");
            sSQL.AppendLine("us.point, ");
            sSQL.AppendLine("us.type, ");
            sSQL.AppendLine("us.birthday, ");
            sSQL.AppendLine("r.name ");
            sSQL.AppendLine($"order by point, name ");

            return clsDBConnectionManager.Connection.Query<dynamic>(sSQL.ToString()).ToList();
        }
    }
}
