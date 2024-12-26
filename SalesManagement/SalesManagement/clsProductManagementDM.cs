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

        public static double getTotalSalesAsset(DateTime timeTo)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("SELECT ");
            sSQL.AppendLine("SUM(p.importprice * COALESCE(sp.total_sold_quantity, 0)) AS total_asset ");
            sSQL.AppendLine("FROM products p ");
            sSQL.AppendLine("JOIN ( ");
            sSQL.AppendLine("SELECT pm.productid,  ");
            sSQL.AppendLine("SUM(pm.quantity) AS total_sold_quantity ");
            sSQL.AppendLine("FROM productmanager pm ");
            sSQL.AppendLine("JOIN bill b on pm.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine($"WHERE b.updatedatetime <= '{timeTo.ToString("yyyy-MM-dd 23:59:59")}' AND b.isdeleted = false ");
            sSQL.AppendLine("GROUP BY pm.productid ");
            sSQL.AppendLine(") sp ON p.id = sp.productid; ");

            return clsDBConnectionManager.Connection.Query<double>(sSQL.ToString()).First();
        }

        public static double getTotalSales(DateTime timeTo)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select coalesce(sum(quantity * unitprice), 0) from bill b ");
            sSQL.AppendLine("join productmanager pm on pm.receiptnumber = b.receiptnumber ");
            sSQL.AppendLine($"where b.updatedatetime <= '{timeTo.ToString("yyyy-MM-dd 23:59:59")}' and b.isdeleted = false ");

            return clsDBConnectionManager.Connection.Query<double>(sSQL.ToString()).First();
        }
    }
}
