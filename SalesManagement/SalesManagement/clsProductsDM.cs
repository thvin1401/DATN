using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsProductsDM
    {
        public static List<dynamic> getAllProducts(DateTime importFrom, DateTime importTo, string name, bool isdeleted)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select pd.id, ");
            sSQL.AppendLine("pd.name, ");
            sSQL.AppendLine("pd.quantity, ");
            sSQL.AppendLine("pd.unitprice, ");
            sSQL.AppendLine("us.name as provider, ");
            sSQL.AppendLine("cg.name as category, ");
            sSQL.AppendLine("pd.importdatetime, ");
            sSQL.AppendLine("pd.weight ");
            sSQL.AppendLine("from products pd ");
            sSQL.AppendLine("join userinfo us on pd.providerid = us.id ");
            sSQL.AppendLine("join categories cg on pd.categoryid = cg.id ");
            sSQL.AppendLine($"where pd.isdeleted = {isdeleted} ");

            if(importFrom == importTo)
            {
                sSQL.AppendLine($"and importdatetime <= '{importTo.ToString("yyyy-MM-dd 23:59:59")}' ");
            }
            else
            {
                sSQL.AppendLine($"and importdatetime >= '{importFrom.ToString("yyyy-MM-dd 00:00:00")}' ");
                sSQL.AppendLine($"and importdatetime <= '{importTo.ToString("yyyy-MM-dd 23:59:59")}' ");
            }
            if (!string.IsNullOrEmpty(name))
            {
                sSQL.AppendLine($"and name like '%{name}%' ");
            }

            sSQL.AppendLine("order by importdatetime desc, pd.createdatetime desc");

            return clsDBConnectionManager.Connection.Query<dynamic>(sSQL.ToString()).ToList();
        }

        public static List<mdlProducts> getAllProductsForSales()
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from products where isdeleted = false and quantity > 0 order by name, unitprice");

            return clsDBConnectionManager.Connection.Query<mdlProducts>(sSQL.ToString()).ToList();
        }

        public static List<mdlProducts> getAllProducts()
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from products");

            return clsDBConnectionManager.Connection.Query<mdlProducts>(sSQL.ToString()).ToList();
        }

        public static List<mdlProducts> getProductEdit(string id)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from products where id = '{id}' ");

            return clsDBConnectionManager.Connection.Query<mdlProducts>(sSQL.ToString()).ToList();
        }

        public static void createNewProduct(mdlProducts product)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into products ");
            sSQL.AppendLine("values( ");
            sSQL.AppendLine($"'{product.id}', ");
            sSQL.AppendLine($"'{product.name}', ");
            sSQL.AppendLine($"{product.quantity}, ");
            sSQL.AppendLine($"{product.unitprice}, ");
            sSQL.AppendLine($"'{product.providerid}', ");
            sSQL.AppendLine($"{product.isdeleted}, ");
            sSQL.AppendLine($"'{product.categoryid}', ");
            sSQL.AppendLine($"'{product.createdatetime}', ");
            sSQL.AppendLine($"'{product.updatedatetime}', ");
            sSQL.AppendLine($"'{product.importdatetime}', ");
            sSQL.AppendLine($"{product.weight}, ");
            sSQL.AppendLine($"{product.importprice})");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void updateProduct(mdlProducts product)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update products ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine($"name = '{product.name}', ");
            sSQL.AppendLine($"quantity = {product.quantity}, ");
            sSQL.AppendLine($"unitprice = {product.unitprice}, ");
            sSQL.AppendLine($"importprice = {product.importprice}, ");
            sSQL.AppendLine($"providerid = '{product.providerid}', ");
            sSQL.AppendLine($"isdeleted = {product.isdeleted}, ");
            sSQL.AppendLine($"categoryid = '{product.categoryid}', ");
            sSQL.AppendLine($"updatedatetime = '{product.updatedatetime}', ");
            sSQL.AppendLine($"importdatetime = '{product.importdatetime}', ");
            sSQL.AppendLine($"weight = {product.weight}");
            sSQL.AppendLine($"where id = '{product.id}'");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void deleteAndRevertProduct(string id, bool isDeleted)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update products ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine($"isdeleted = {isDeleted} ");
            sSQL.AppendLine($"where id = '{id}' ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void updateCanceledProductQuantity(string id, int canceledQuantity)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update products ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine($"quantity = quantity + {canceledQuantity} ");
            sSQL.AppendLine($"where id = '{id}' ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static double getTotalAssetTo(DateTime timeTo)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("SELECT ");
            sSQL.AppendLine("SUM(p.importprice * (p.quantity + COALESCE(sp.total_sold_quantity, 0))) AS total_asset ");
            sSQL.AppendLine("FROM products p ");
            sSQL.AppendLine("LEFT JOIN ( ");
            sSQL.AppendLine("SELECT productmanager.productid, ");
            sSQL.AppendLine("SUM(productmanager.quantity) AS total_sold_quantity ");
            sSQL.AppendLine("FROM productmanager ");
            sSQL.AppendLine("GROUP BY productmanager.productid ");
            sSQL.AppendLine($") sp ON p.id = sp.productid and p.importdatetime <= '{timeTo.ToString("yyyy-MM-dd 23:59:59")}' ");

            return clsDBConnectionManager.Connection.Query<double>(sSQL.ToString()).First();
        }
    }
}
