using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsProductManagementDM
    {
        public static void insertData(mdlProductManagement order)
        {
            // insert data into product manager
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into productmanager ");
            sSQL.AppendLine("values( ");
            sSQL.AppendLine($"'{order.id}', ");
            sSQL.AppendLine($"{order.receiptnumber}, ");
            sSQL.AppendLine($"'{order.productid}', ");
            sSQL.AppendLine($"{order.quantity}, ");
            sSQL.AppendLine($"{order.unitprice}, ");
            sSQL.AppendLine($"{order.discount}, ");
            sSQL.AppendLine($"'{order.createdatetime}', ");
            sSQL.AppendLine($"'{order.updatedatetime}')");

            clsDBConnectionManager.Connection.Query<mdlCurrencyExchange>(sSQL.ToString());

            // update product quantity

            sSQL = new StringBuilder();
            sSQL.AppendLine("update products ");
            sSQL.AppendLine($"set quantity = quantity - {order.quantity}, ");
            sSQL.AppendLine($"updatedatetime = '{order.updatedatetime}' ");
            sSQL.AppendLine($"where id = '{order.productid}'");

            clsDBConnectionManager.Connection.Query<mdlCurrencyExchange>(sSQL.ToString());
        }

        public static List<mdlProductManagement> getListProductManagementByReceiptNumber(int receiptNumber)
        {
            // insert data into product manager
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from productmanager ");
            sSQL.AppendLine($"where receiptnumber = {receiptNumber} ");

            return clsDBConnectionManager.Connection.Query<mdlProductManagement>(sSQL.ToString()).ToList();
        }
    }
}
