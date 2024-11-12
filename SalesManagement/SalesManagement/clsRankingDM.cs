using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsRankingDM
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsRankingDM));
        public static void createRankingData(mdlRanking rank)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into ranking ");
            sSQL.AppendLine("values( ");
            sSQL.AppendLine($"'{rank.id}', ");
            sSQL.AppendLine($"'{rank.name}', ");
            sSQL.AppendLine($"{rank.isactive}, ");
            sSQL.AppendLine($"{rank.discount}, ");
            sSQL.AppendLine($"'{rank.createdatetime}', ");
            sSQL.AppendLine($"'{rank.updatedatetime}')");

            try
            {
                clsDBConnectionManager.Connection.Query(sSQL.ToString());
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static List<mdlRanking> getAllRankingData()
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from ranking where isactive = true");

            try
            {
                return clsDBConnectionManager.Connection.Query<mdlRanking>(sSQL.ToString()).ToList();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlRanking>();
            }
        }
    }
}
