using SalesManagement.model;
using System.Xml.Linq;

namespace SalesManagement
{
    public static class clsController
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsController));

        // systemproperty
        public static List<mdlSystemProperty> getAllSystemProperties()
        {
            try
            {
                return clsSystemPropertyDM.getAllSystemProperties();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                return new List<mdlSystemProperty>();
            }
        }

        // Account

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

        public static void createAccount(mdlAccount account, mdlUserInfo userInfo, bool isNewUser)
        {
            try
            {
                clsAccountDM.createAccount(account, userInfo, isNewUser);
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
        public static List<mdlUserInfo> getUserByNameAndType(string? name = null, int? type = null, int? typeExcept = null)
        {
            try
            {
                return clsUserInfoDM.getAllUsers(name, type, typeExcept);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlUserInfo>();
            }
        }

        public static List<mdlUserInfo> getAllUsersNoCondition()
        {
            try
            {
                return clsUserInfoDM.getAllUsersNoCondition();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlUserInfo>();
            }
        }

        public static bool checkExistEmail(string email, string? exceptId = null)
        {
            try
            {
                return clsUserInfoDM.checkExistEmail(email, exceptId);
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

        public static List<mdlUserInfo> getAllUserCanCreateAccount()
        {
            try
            {
                return clsUserInfoDM.getAllUserCanCreateAccount();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlUserInfo>();
            }
        }

        public static mdlUserInfo getUserInfoByBillReceiptNumber(int receiptNumber)
        {
            try
            {
                return clsUserInfoDM.getUserInfoByBillReceiptNumber(receiptNumber);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new mdlUserInfo();
            }
        }

        public static mdlUserInfo getUserInfoById(string userId)
        {
            try
            {
                return clsUserInfoDM.getUserInfoById(userId);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new mdlUserInfo();
            }
        }

        public static List<dynamic> getListUserInfoByFullCondition(DateTime birthdayFrom, DateTime birthdayTo, int status, string? fullName = null, string? address = null, string? phone = null)
        {
            try
            {
                return clsUserInfoDM.getListUserInfoByFullCondition(birthdayFrom, birthdayTo, status, fullName, address, phone);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<dynamic>();
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

        public static bool deactiveOrActivateUser(List<string> listUserId, bool isActivate)
        {
            try
            {
                foreach (var item in listUserId)
                {
                    clsUserInfoDM.deactiveOrActivateUser(item.Trim(), isActivate);
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
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
                return clsProductsDM.getAllProductsForSales();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlProducts>();
            }
        }

        public static List<mdlProducts> getAllProducts()
        {
            try
            {
                return clsProductsDM.getAllProducts();
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

        public static bool updateCanceledProductQuantity(List<mdlProductManagement> listCanceledProduct)
        {
            try
            {
                foreach(var product in listCanceledProduct)
                {
                    clsProductsDM.updateCanceledProductQuantity(product.productid.ToString(), product.quantity);
                }
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

        public static bool updateBillTypeByReceiptNumber(int receiptNumber, int type)
        {
            try
            {
                clsBillDM.updateBillTypeByReceiptNumber(receiptNumber, type);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static mdlBill? getBillByReceiptNumberAndType(int receiptNumber, int billType)
        {
            try
            {
                return clsBillDM.getBillByReceiptNumberAndType(receiptNumber, billType);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }

        public static List<mdlBill> getAllBills(DateTime billFrom, DateTime billTo, int? costFrom = null, int? costTo = null, int? receiptnumber = null, int? type = null)
        {
            try
            {
                return clsBillDM.getAllBills(billFrom, billTo, costFrom,costTo, receiptnumber, type);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlBill>();
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

        public static List<mdlProductManagement> getListProductManagementByReceiptNumber(int receiptNumber)
        {
            try
            {
                return clsProductManagementDM.getListProductManagementByReceiptNumber(receiptNumber);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlProductManagement>();
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

        public static List<mdlPayment> getListPaymentByReceiptNumber(int receiptNumber)
        {
            try
            {
                return clsPaymentDM.getListPaymentByReceiptNumber(receiptNumber);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<mdlPayment>();
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

        public static dynamic? getDebtInfoById(string id)
        {
            try
            {
                return clsDebtManagementDM.getDebtInfoById(id);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }

        public static bool changeDebtStatus(mdlDebtManagement debt)
        {
            try
            {
                clsDebtManagementDM.changeDebtStatus(debt);

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
