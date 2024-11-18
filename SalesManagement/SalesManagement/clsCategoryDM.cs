using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsCategoryDM
    {
        public static List<mdlCategories> getAllCategories()
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from categories where isdeleted = false order by name");

            return clsDBConnectionManager.Connection.Query<mdlCategories>(sSQL.ToString()).ToList();
        }

        public static void createNewCategory(mdlCategories category)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into categories ");
            sSQL.AppendLine("values( ");
            sSQL.AppendLine($"'{category.id}', ");
            sSQL.AppendLine($"'{category.name}', ");
            sSQL.AppendLine($"{category.isdeleted}, ");
            sSQL.AppendLine($"'{category.createdatetime}', ");
            sSQL.AppendLine($"'{category.updatedatetime}')");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }
    }
}
