using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsBillDM
    {
        public static int getNewReceiptNumber()
        {
            int receiptNumber = 0;

            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("SELECT nextval('receipt_number')");

            receiptNumber = clsDBConnectionManager.Connection.Query<int>(sSQL.ToString()).FirstOrDefault();

            while (isExistReceiptNumber(receiptNumber))
            {
                receiptNumber = clsDBConnectionManager.Connection.Query<int>(sSQL.ToString()).FirstOrDefault();
            }

            return receiptNumber;
        }

        public static bool isExistReceiptNumber(int receiptNumber)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine($"select receiptnumber from bill where receiptnumber = {receiptNumber}");

            return clsDBConnectionManager.Connection.Query(sSQL.ToString()).Any();
        }

        public static void insertBill(mdlBill bill)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("insert into bill ");
            sSQL.AppendLine("values( ");
            sSQL.AppendLine($"{bill.receiptnumber}, ");
            sSQL.AppendLine($"{bill.amount}, ");
            sSQL.AppendLine($"{bill.discount}, ");
            sSQL.AppendLine($"{bill.payamount}, ");
            sSQL.AppendLine($"{bill.isdeleted}, ");
            sSQL.AppendLine($"'{bill.createdatetime}', ");
            sSQL.AppendLine($"'{bill.updatedatetime}', ");
            sSQL.AppendLine($"'{bill.userinfoid}', ");
            sSQL.AppendLine($"{bill.billtype}, ");
            sSQL.AppendLine($"{bill.ispaid})");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void updateBillTypeByReceiptNumber(int receiptNumber, int type)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("update bill ");
            sSQL.AppendLine("set ");
            sSQL.AppendLine($"billtype = {type} ");
            sSQL.AppendLine($"where receiptnumber = {receiptNumber} ");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static mdlBill? getBillByReceiptNumberAndType(int receiptNumber, int billType)
        {
            StringBuilder sSQL = new StringBuilder();
            sSQL.AppendLine("select * from bill ");
            sSQL.AppendLine($"where receiptnumber = {receiptNumber} ");
            sSQL.AppendLine($"and isdeleted = false and billtype = {billType} ");

            return clsDBConnectionManager.Connection.Query<mdlBill>(sSQL.ToString()).FirstOrDefault();
        }
    }
}
