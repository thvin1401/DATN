using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsCurrencyExchangeDM
    {
        public static List<mdlCurrencyExchange> getAllCurrencyExchange()
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from currencyexchange order by type");

            return clsDBConnectionManager.Connection.Query<mdlCurrencyExchange>(sSQL.ToString()).ToList();
        }
    }
}
