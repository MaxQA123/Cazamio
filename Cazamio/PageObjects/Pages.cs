using CazamioProgect.Helpers;
using CazamioProgect.PageObjects.DatePickerModalWindow;
using CazamioProgect.PageObjects.EmailXitrooPage;
using CazamioProgect.PageObjects.GeneralPages.LogInPageCazamioTenant;
using CazamioProgect.PageObjects.GeneralPages.SignUpCazamioTenantPage;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant;
using CazamioProgect.PageObjects.WebSiteLandlordPages.BrokersPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.DashboardPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApartmentsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApplicationsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfBuildingsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfOwnersPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfTransactionsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.LogInPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.MarketplacePage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ModalsWindowsPages;
using CazamioProgect.PageObjects.WebSiteLandlordPages.PaymentSettingsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.PreApprovalsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.SideBarLandlord;
using CazamioProgect.PageObjects.WebSiteLandlordPages.TemplatesPage;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static DatePicker DatePicker => GetPage<DatePicker>();
        public static EmailXitroo EmailXitroo => GetPage< EmailXitroo >();
        public static JScriptExecutorHelper JScriptExecutorHelper => GetPage<JScriptExecutorHelper>();

        #region TenantWebSiteCazamio

        public static HeaderCazamioTenant HeaderCazamioTenant => GetPage<HeaderCazamioTenant>();
        public static SignUpCazamioTenant SignUpCazamioTenant => GetPage<SignUpCazamioTenant>();
        public static LogInCazamioTenant LogInCazamioTenant => GetPage<LogInCazamioTenant>();
        public static MyAccountCazamioTenant MyAccountCazamioTenant => GetPage<MyAccountCazamioTenant>();

        #endregion

        #region LandlordWebSite

        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
        public static SideBarLandlord SideBarLandlord => GetPage<SideBarLandlord>();
        public static Dashboard Dashboard => GetPage<Dashboard>();
        public static ListOfBuildings ListOfBuildings => GetPage<ListOfBuildings>();
        public static ListOfApartments ListOfApartments => GetPage<ListOfApartments>();
        public static ListOfApplications ListOfApplications => GetPage<ListOfApplications>();
        public static PreApprovals PreApprovals => GetPage<PreApprovals>();
        public static Templates Templates => GetPage<Templates>();
        public static PaymentSettings PaymentSettings => GetPage<PaymentSettings>();
        public static ListOfTransactions ListOfTransactions => GetPage<ListOfTransactions>();
        public static Brokers Brokers => GetPage<Brokers>();
        public static ListOfOwners ListOfOwners => GetPage<ListOfOwners>();
        public static Marketplace Marketplace => GetPage<Marketplace>();
        public static ModalsWindowsLandlordBroker ModalsWindowsLandlordBroker => GetPage<ModalsWindowsLandlordBroker>();

        #endregion

    }
}
