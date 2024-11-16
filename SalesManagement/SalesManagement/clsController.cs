using SalesManagement.model;

namespace SalesManagement
{
    public static class clsController
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsController));

        public static bool getAccountLoggedIn(string username, string password)
        {
            try
            {
                return clsAccountDM.getAccountLoggedIn(username, password);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return false;
            }
        }

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

        public static void updateAccount(mdlAccount account, mdlUserInfo userInfo, bool isUpdatePassword)
        {
            try
            {
                clsAccountDM.updateAccount(account, userInfo, isUpdatePassword);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
            }
        }

        public static bool checkEmailUsernameConsistency(string username, string email)
        {
            try
            {
                return clsAccountDM.checkEmailUsernameConsistency(username, email);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return false;
            }
        }

        public static bool changePassword(string username, string password)
        {
            try
            {
                clsAccountDM.changePassword(username, password);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return false;
            }
        }

        // note

        public static List<mdlNote> getNotes(DateTime remindDateFrom, DateTime remindDateTo, bool getAll)
        {
            try
            {
                return clsNoteDM.getNotes(remindDateFrom, remindDateTo, getAll);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);

                return new List<mdlNote>();
            }
        }

        public static bool markNoteDone(string id)
        {
            try
            {
                clsNoteDM.markNoteDone(id);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);

                return false;
            }
        }

        public static bool markNoteDeleted(string id)
        {
            try
            {
                clsNoteDM.markNoteDeleted(id);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);

                return false;
            }
        }
    }
}
