using Dapper;
using SalesManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    public static class clsProductsDM
    {
        public static List<mdlProducts> getAllProducts(DateTime importFrom, DateTime importTo, string name, bool isdeleted)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select * from products where isdeleted = {isdeleted} ");

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
            sSQL.AppendLine($"{product.weight})");

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
            sSQL.AppendLine($"providerid = '{product.providerid}', ");
            sSQL.AppendLine($"isdeleted = {product.isdeleted}, ");
            sSQL.AppendLine($"categoryid = '{product.categoryid}', ");
            sSQL.AppendLine($"updatedatetime = '{product.updatedatetime}', ");
            sSQL.AppendLine($"importdatetime = '{product.importdatetime}', ");
            sSQL.AppendLine($"weight = {product.weight}");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }
    }
}
