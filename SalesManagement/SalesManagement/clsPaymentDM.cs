using Dapper;
using SalesManagement.model;
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
            sSQL.AppendLine($"'{payment.debtid}', ");
            sSQL.AppendLine($"{payment.paymentmethod}, ");
            sSQL.AppendLine($"'{payment.paydatetime}', ");
            sSQL.AppendLine($"{payment.paymenttype}, ");
            sSQL.AppendLine($"'{payment.createdatetime}', ");
            sSQL.AppendLine($"'{payment.updatedatetime}') ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }
    }
}
