using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsDebtManagementDM
    {
        public static List<dynamic> getAllDebtInfo(DateTime processedTimeFrom, DateTime processedTimeTo, int receiptnumber, int type, Guid userinfoID)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select ");
            sSQL.AppendLine("dm.id, ");
            sSQL.AppendLine("b.payamount, ");
            sSQL.AppendLine("COALESCE(sum(p.amount), 0) as paidamount, ");
            sSQL.AppendLine("dm.interest, ");
            sSQL.AppendLine("dm.circle, ");
            sSQL.AppendLine("dm.processeddatetime, ");
            sSQL.AppendLine("dm.paidbeforetime, ");
            sSQL.AppendLine("dm.paiddatetime, ");
            sSQL.AppendLine("dm.status ");
            sSQL.AppendLine("from debtmanager dm ");
            sSQL.AppendLine("join bill b on dm.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine("join userinfo us on b.userinfoid = us.id ");
            sSQL.AppendLine("left join payment p on b.receiptnumber = p.receiptnumber ");
            sSQL.AppendLine($"where dm.status != 3 and us.id = '{userinfoID}' and dm.type = {type} and b.isdeleted = false ");

            if(processedTimeFrom == processedTimeTo)
            {
                sSQL.AppendLine($"and dm.processeddatetime <= '{processedTimeTo.ToString("yyyy-MM-dd 23:59:59")}' ");
            }
            else
            {
                sSQL.AppendLine($"and dm.processeddatetime >= '{processedTimeFrom.ToString("yyyy-MM-dd 00:00:00")}' ");
                sSQL.AppendLine($"and dm.processeddatetime <= '{processedTimeTo.ToString("yyyy-MM-dd 23:59:59")}' ");
            }
            if(receiptnumber != 0)
            {
                sSQL.AppendLine($"and dm.receiptnumber = {receiptnumber} ");
            }

            sSQL.AppendLine("group by dm.id, ");
            sSQL.AppendLine("b.payamount, ");
            sSQL.AppendLine("dm.interest, ");
            sSQL.AppendLine("dm.circle, ");
            sSQL.AppendLine("dm.processeddatetime, ");
            sSQL.AppendLine("dm.paidbeforetime, ");
            sSQL.AppendLine("dm.paiddatetime, ");
            sSQL.AppendLine("dm.status ");

            return clsDBConnectionManager.Connection.Query<dynamic>(sSQL.ToString()).ToList();
        }

        public static List<dynamic> getListDebtOverview()
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select ");
            sSQL.AppendLine("us.id, ");
            sSQL.AppendLine("us.name, ");
            sSQL.AppendLine("dm.type, ");
            sSQL.AppendLine("sum(b.payamount) as totalamount, ");
            sSQL.AppendLine("coalesce(sum(p.amount), 0) as paidamount ");
            sSQL.AppendLine("from userinfo us ");
            sSQL.AppendLine("join bill b on us.id = b.userinfoid ");
            sSQL.AppendLine("left join payment p on p.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine("join debtmanager dm on b.receiptnumber = dm.receiptnumber ");
            sSQL.AppendLine("where b.isdeleted = false and dm.status != 3");
            sSQL.AppendLine("group by us.id, us.name, dm.type ");

            return clsDBConnectionManager.Connection.Query<dynamic>(sSQL.ToString()).ToList();
        }

        public static void insertDebtDetail(mdlDebtManagement debt)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into debtmanager ");
            sSQL.AppendLine("values( ");
            sSQL.AppendLine($"'{debt.id}', ");
            sSQL.AppendLine($"{debt.receiptnumber}, ");
            sSQL.AppendLine($"{debt.interest}, ");
            sSQL.AppendLine($"{debt.circle}, ");
            sSQL.AppendLine($"{debt.status}, ");
            sSQL.AppendLine($"'{debt.processeddatetime}', ");

            if(debt.status == 3)
            {
                sSQL.AppendLine($"'{debt.paiddatetime}', ");
            }
            else
            {
                sSQL.AppendLine($"null, ");
            }

            sSQL.AppendLine($"{debt.type}, ");
            sSQL.AppendLine($"'{debt.createdatetime}', ");
            sSQL.AppendLine($"'{debt.updatedatetime}', ");
            sSQL.AppendLine($"'{debt.paidbeforetime}') ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void deleteDebtInfo(string? id)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update debtmanager ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine("status = 3 ");
            sSQL.AppendLine($"where id = '{id}' ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static dynamic getDebtInfoById(string id)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select dm.id, ");
            sSQL.AppendLine("dm.receiptnumber, ");
            sSQL.AppendLine("dm.type, ");
            sSQL.AppendLine("dm.status, ");
            sSQL.AppendLine("sum(b.payamount) as totalamount, ");
            sSQL.AppendLine("coalesce(sum(p.amount), 0) as paidamount ");
            sSQL.AppendLine("from debtmanager dm ");
            sSQL.AppendLine("join bill b on dm.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine("left join payment p on b.receiptnumber = p.receiptnumber ");
            sSQL.AppendLine($"where dm.id = '{id}' ");
            sSQL.AppendLine("group by dm.id, dm.receiptnumber, dm.type, dm.status");

            return clsDBConnectionManager.Connection.Query<dynamic>(sSQL.ToString()).First();
        }

        public static void changeDebtStatus(mdlDebtManagement debt)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update debtmanager ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine($"status = {debt.status}, ");

            if(debt.status == 2)
            {
                sSQL.AppendLine($"paiddatetime = '{debt.paiddatetime}', ");
            }

            sSQL.AppendLine($"updatedatetime = '{debt.updatedatetime}' ");
            sSQL.AppendLine($"where id = '{debt.id}' ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }
    }
}
