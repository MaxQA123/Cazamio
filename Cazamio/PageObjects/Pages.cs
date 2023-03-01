using CazamioProgect.Helpers;
using CazamioProgect.PageObjects.DatePickerModalWindow;
using CazamioProgect.PageObjects.EmailXitrooPage;
using CazamioProgect.PageObjects.GeneralPages.LogInPageCazamioTenant;
using CazamioProgect.PageObjects.GeneralPages.SignUpCazamioTenantPage;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.CreateNewPasswordPage;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ForgotPasswordPage;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant;
using CazamioProgect.PageObjects.WebSiteLandlordPages.AgentsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.DashboardPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApartmentsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfApplicationsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfBuildingsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfOwnersPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfTransactionsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.LogInPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.MarketplacePage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ModalsWindowsPages;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewAgentPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowPaymentOptionsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.PaymentSettingsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.PopUpWndowNewAgentCreatedSuccessfully;
using CazamioProgect.PageObjects.WebSiteLandlordPages.PreApprovalsPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.ResetYourPasswordPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.SideBarLandlord;
using CazamioProgect.PageObjects.WebSiteLandlordPages.TemplatesPage;
using CazamioProgect.PageObjects.EmailPutsBox;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HomePageCazamioTenant;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ListOfApartmentsTenantPage;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ApartmentDetailsTenantPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ListOfLandlordsPage;
using CazamioProject.PageObjects.ModalWndwCreateNewLandlordPage;
using CazamioProject.PageObjects.ModalWndwCreateNewOwner;

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
        public static PutsBox PutsBox => GetPage<PutsBox>();
        public static JScriptExecutorHelper JScriptExecutorHelper => GetPage<JScriptExecutorHelper>();

        #region TenantWebSiteCazamio

        public static HeaderCazamioTenant HeaderCazamioTenant => GetPage<HeaderCazamioTenant>();
        public static SignUpCazamioTenant SignUpCazamioTenant => GetPage<SignUpCazamioTenant>();
        public static LogInCazamioTenant LogInCazamioTenant => GetPage<LogInCazamioTenant>();
        public static MyAccountCazamioTenant MyAccountCazamioTenant => GetPage<MyAccountCazamioTenant>();
        public static ForgotPassword ForgotPassword => GetPage<ForgotPassword>();
        public static CreateNewPassword CreateNewPassword => GetPage<CreateNewPassword>();
        public static HomeCazamioTenant HomeCazamioTenant => GetPage<HomeCazamioTenant>();
        public static ListOfApartmentsTenant ListOfApartmentsTenant => GetPage<ListOfApartmentsTenant>();
        public static ApartmentDetailsTenant ApartmentDetailsTenant => GetPage<ApartmentDetailsTenant>();

        #endregion

        #region LandlordWebSite

        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
        public static SideBarLandlord SideBarLandlord => GetPage<SideBarLandlord>();
        public static Dashboard Dashboard => GetPage<Dashboard>();
        public static ListOfBuildings ListOfBuildings => GetPage<ListOfBuildings>();
        public static ListOfApartments ListOfApartments => GetPage<ListOfApartments>();
        public static ListOfApplications ListOfApplications => GetPage<ListOfApplications>();
        public static ListOfLandlords ListOfLandlords => GetPage<ListOfLandlords>();
        public static PreApprovals PreApprovals => GetPage<PreApprovals>();
        public static Templates Templates => GetPage<Templates>();
        public static PaymentSettings PaymentSettings => GetPage<PaymentSettings>();
        public static ListOfTransactions ListOfTransactions => GetPage<ListOfTransactions>();
        public static Agents Agents => GetPage<Agents>();
        public static ListOfOwners ListOfOwners => GetPage<ListOfOwners>();
        public static Marketplace Marketplace => GetPage<Marketplace>();
        public static ModalWindowAreYouSureLogOutLandlordBroker ModalWindowAreYouSureLogOutLandlordBroker => GetPage<ModalWindowAreYouSureLogOutLandlordBroker>();
        public static ModalWindowCreateNewAgent ModalWindowCreateNewAgent => GetPage<ModalWindowCreateNewAgent>();
        public static ModalWndwCreateNewLandlord ModalWndwCreateNewLandlord => GetPage<ModalWndwCreateNewLandlord>();
        public static ResetYourPassword ResetYourPassword => GetPage<ResetYourPassword>();
        public static NewBuilding NewBuilding => GetPage<NewBuilding>();
        public static ModalWindowPaymentOptions ModalWindowPaymentOptions => GetPage<ModalWindowPaymentOptions>();
        public static PopUpWndowNewAgentCreatedSuccessfully PopUpWndowNewAgentCreatedSuccessfully => GetPage<PopUpWndowNewAgentCreatedSuccessfully>();
        public static ModalWndwCreateNewOwner ModalWndwCreateNewOwner => GetPage<ModalWndwCreateNewOwner>();
        #endregion
    }
}
