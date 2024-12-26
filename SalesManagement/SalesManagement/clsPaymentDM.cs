using Dapper;
using SalesManagement.model;
using System.ComponentModel.Design;
using System.Text;

namespace SalesManagement
{
    public static class clsPaymentDM
    {
        public static void insertPaymentData(mdlPayment payment)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into payment ");
            sSQL.AppendLine("values( ");
            sSQL.AppendLine($"'{payment.id}', ");
            sSQL.AppendLine($"{payment.receiptnumber}, ");
            sSQL.AppendLine($"{payment.amount}, ");
            sSQL.AppendLine($"'{payment.userinfoid}', ");
            sSQL.AppendLine($"{payment.paymentmethod}, ");
            sSQL.AppendLine($"'{payment.paydatetime}', ");
            sSQL.AppendLine($"'{payment.createdatetime}') ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static List<mdlPayment> getListPaymentByReceiptNumber(int receiptNumber)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from payment ");
            sSQL.AppendLine($"where receiptnumber = {receiptNumber} ");

            return clsDBConnectionManager.Connection.Query<mdlPayment>(sSQL.ToString()).ToList();
        }

        public static double getTotalPaymentFor(DateTime timeTo, int? paymentMethod = null)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select coalesce(sum(p.amount)) from bill b   ");
            sSQL.AppendLine("left join payment p on b.receiptnumber = p.receiptnumber  ");
            sSQL.AppendLine($"where b.updatedatetime <= '{timeTo.ToString("yyyy-MM-dd 23:59:59")}' and b.isdeleted = false ");

            if(paymentMethod != null)
            {
                sSQL.AppendLine($"and p.paymentmethod = {paymentMethod} ");
            }

            return clsDBConnectionManager.Connection.Query<double>(sSQL.ToString()).First();
        }
    }
}
