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
            sSQL.AppendLine("insert into userinfo ");
            sSQL.AppendLine("values(");
            sSQL.AppendLine($"'{userInfo.id}',");
            sSQL.AppendLine($"'{userInfo.name}',");
            sSQL.AppendLine($"'{userInfo.address}',");
            sSQL.AppendLine($"'{userInfo.phone}',");
            sSQL.AppendLine($"'{userInfo.email}',");
            sSQL.AppendLine($"'{Guid.Empty}',");
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

        public static List<mdlUserInfo> getAllUsers(string? name = null, int? type = null)
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

            sSQL.AppendLine("order by name, type");

            return clsDBConnectionManager.Connection.Query<mdlUserInfo>(sSQL.ToString()).ToList();
        }
    }
}
