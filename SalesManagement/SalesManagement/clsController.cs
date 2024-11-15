using SalesManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalesManagement
{
    public static class clsController
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsController));

        public static List<dynamic> getAllAccountInfo(int type, int activation, string text)
        {
            try
            {
                return clsAccountDM.getAllAccountInfo(type, activation, text);
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message, ex);
                return new List<dynamic>();
            }
        }

        public static bool deactiveOrActivateAccount(List<string> listUsername, bool isActivate)
        {
            try
            {
                foreach(var item in listUsername)
                {
                    clsAccountDM.deactiveOrActivateAccount(item.Trim(), isActivate);
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return false;
            }
        }

        public static dynamic getAccountInfoByUsername(string username)
        {
            try
            {
                return clsAccountDM.getAccountInfoByUsername(username);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return DBNull.Value;
            }
        }

        public static void createAccount(mdlAccount account, mdlUserInfo userInfo)
        {
            try
            {
                clsAccountDM.createAccount(account, userInfo);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
            }
        }

        public static void updateAccount(mdlAccount account, mdlUserInfo userInfo)
        {
            try
            {
                clsAccountDM.updateAccount(account, userInfo);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
            }
        }
    }
}
