using Dapper;
using SalesManagement.model;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public static bool createNote(mdlNote note)
        {
            try
            {
                clsNoteDM.createNote(note);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);

                return false;
            }
        }

        public static bool updateNote(mdlNote note)
        {
            try
            {
                clsNoteDM.updateNote(note);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);

                return false;
            }
        }

        public static mdlNote? getNoteEdit(string id)
        {
            try
            {
                var data = clsNoteDM.getNoteEdit(id);

                if (data.Any())
                {
                    return data.First();
                }
                return null;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);

                return null;
            }
        }

        // currency exchange
        public static List<mdlCurrencyExchange> getAllCurrencyExchange()
        {
            try
            {
                return clsCurrencyExchangeDM.getAllCurrencyExchange();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);

                return new List<mdlCurrencyExchange>();
            }
        }

        // ranking
        public static List<mdlRanking> getAllRankingData()
        {
            try
            {
                return clsRankingDM.getAllRankingData();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlRanking>();
            }
        }

        // userinfos
        public static List<mdlUserInfo> getUserByNameAndType(string? name = null, int? type = null)
        {
            try
            {
                return clsUserInfoDM.getAllUsers(name, type);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlUserInfo>();
            }
        }

        public static bool checkExistEmail(string email)
        {
            try
            {
                return clsUserInfoDM.checkExistEmail(email);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static bool createUser(mdlUserInfo userInfo)
        {
            try
            {
                clsUserInfoDM.createUser(userInfo);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static bool updateUser(mdlUserInfo userInfo)
        {
            try
            {
                clsUserInfoDM.updateUser(userInfo);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static bool updateUserPointAndRank(mdlUserInfo userInfo)
        {
            try
            {
                clsUserInfoDM.updateUserPointAndRank(userInfo);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        // category
        public static List<mdlCategories> getAllCategories()
        {
            try
            {
                return clsCategoryDM.getAllCategories();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlCategories>();
            }
        }

        public static bool createNewCategory(mdlCategories category)
        {
            try
            {
                clsCategoryDM.createNewCategory(category);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        // product
        public static List<dynamic> getAllProducts(DateTime importFrom, DateTime importTo, string name, bool isdeleted)
        {
            try
            {
                var data = clsProductsDM.getAllProducts(importFrom, importTo, name, isdeleted);

                if (data.Any())
                    return data;

                return new List<dynamic>();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<dynamic>();
            }
        }

        public static List<mdlProducts> getAllProductsForSales()
        {
            try
            {
                var data = clsProductsDM.getAllProductsForSales();

                if (data.Any())
                    return data;

                return new List<mdlProducts>();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlProducts>();
            }
        }

        public static mdlProducts getProductEdit(string id)
        {
            try
            {
                var data = clsProductsDM.getProductEdit(id);

                if (data.Any())
                    return data.First();

                return new mdlProducts();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new mdlProducts();
            }
        }

        public static bool createNewProduct(mdlProducts product)
        {
            try
            {
                clsProductsDM.createNewProduct(product);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static bool updateProduct(mdlProducts product)
        {
            try
            {
                clsProductsDM.updateProduct(product);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static bool deleteAndRevertProduct(string? id, bool isDeleted)
        {
            try
            {
                clsProductsDM.deleteAndRevertProduct(id, isDeleted);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        // bill
        public static int getNewReceiptNumber()
        {
            try
            {
                return clsBillDM.getNewReceiptNumber();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return 0;
            }
        }

        public static bool insertBill(mdlBill bill)
        {
            try
            {
                clsBillDM.insertBill(bill);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        // product management
        public static bool insertData(List<mdlProductManagement> listOrder)
        {
            try
            {
                foreach(var order in listOrder)
                {
                    clsProductManagementDM.insertData(order);
                }
                
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        // payment
        public static bool insertPaymentData(mdlPayment payment)
        {
            try
            {
                clsPaymentDM.insertPaymentData(payment);

                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        // debt management
        public static List<dynamic> getAllDebtInfo(DateTime processedTimeFrom, DateTime processedTimeTo, int receiptnumber, int type, Guid userinfoID)
        {
            try
            {
                return clsDebtManagementDM.getAllDebtInfo(processedTimeFrom, processedTimeTo, receiptnumber, type, userinfoID);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<dynamic>();
            }
        }

        public static List<dynamic> getListDebtOverview()
        {
            try
            {
                return clsDebtManagementDM.getListDebtOverview();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<dynamic>();
            }
        }

        public static bool insertDebtDetail(mdlDebtManagement debt)
        {
            try
            {
                clsDebtManagementDM.insertDebtDetail(debt);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static bool deleteDebtInfo(string? id)
        {
            try
            {
                clsDebtManagementDM.deleteDebtInfo(id);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }
    }
}
