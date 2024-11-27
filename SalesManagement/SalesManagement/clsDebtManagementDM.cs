using Dapper;
using SalesManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesManagement
{
    public static class clsDebtManagementDM
    {
        public static List<dynamic> getAllDebtInfo(DateTime processedTimeFrom, DateTime processedTimeTo, int status, int receiptnumber)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select ");
            sSQL.AppendLine("dm.id, ");
            sSQL.AppendLine("us.name, ");
            sSQL.AppendLine("dm.receiptnumber, ");
            sSQL.AppendLine("b.amount, ");
            sSQL.AppendLine("dm.interest, ");
            sSQL.AppendLine("dm.circle, ");
            sSQL.AppendLine("b.payamount, ");
            sSQL.AppendLine("dm.status, ");
            sSQL.AppendLine("dm.processeddatetime, ");
            sSQL.AppendLine("dm.paiddatetime, ");
            sSQL.AppendLine("dm.type ");
            sSQL.AppendLine("from debtmanager dm ");
            sSQL.AppendLine("join bill b where dm.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine("join userinfo us on b.userinfoid = us.id ");
            sSQL.AppendLine($"where dm.status = {status} ");

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
            sSQL.AppendLine($"'{debt.updatedatetime}')");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }
    }
}
