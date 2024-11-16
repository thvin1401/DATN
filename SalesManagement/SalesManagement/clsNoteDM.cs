using Dapper;
using SalesManagement.model;
using System.Text;

namespace SalesManagement
{
    public static class clsNoteDM
    {
        public static List<mdlNote> getNotes(DateTime remindDateFrom, DateTime remindDateTo, bool getAll)
        {
            StringBuilder sSQL = new StringBuilder();
            if (getAll)
            {
                sSQL.AppendLine($"select * from note");
            }
            else
            {
                if(remindDateFrom == remindDateTo)
                {
                    sSQL.AppendLine($"select * from note where reminddatetime <= '{remindDateTo.ToString("yyyy-MM-dd")}' ");
                }
                else
                {
                    sSQL.AppendLine($"select * from note where reminddatetime >= '{remindDateFrom.ToString("yyyy-MM-dd")}' ");
                    sSQL.AppendLine($"and reminddatetime <= '{remindDateTo.ToString("yyyy-MM-dd")}' ");
                }

                sSQL.AppendLine("and isdone = false and isdeleted = false ");
            }

            sSQL.AppendLine("order by reminddatetime desc");

            return clsDBConnectionManager.Connection.Query<mdlNote>(sSQL.ToString()).ToList();
        }

        public static void markNoteDone(string id)
        {
            StringBuilder sSQL = new StringBuilder();
            
            sSQL.AppendLine($"update note set isdone = true, updatedatetime = '{DateTime.Now.ToString("yyyy-MM-dd")}' where id = '{id}'");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }

        public static void markNoteDeleted(string id)
        {
            StringBuilder sSQL = new StringBuilder();

            sSQL.AppendLine($"update note set isdeleted = true, updatedatetime = '{DateTime.Now.ToString("yyyy-MM-dd")}' where id = '{id}'");

            clsDBConnectionManager.Connection.Query(sSQL.ToString());
        }
    }
}
