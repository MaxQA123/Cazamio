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
using CazamioProject.PageObjects.ModalWndwCreateNewOwner;
using CazamioProject.PageObjects.PaginationPickerPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ListOfMarketplaceAdmins;
using CazamioProject.PageObjects.ModalWndwCreateANewMarketplaceAdminPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ListOfCommissionsPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ListOfBrokersPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowPetPolicies;
using CazamioProject.PageObjects.WebSiteLandlordPages.BuildingViewPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.AddApartmentsPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ReportsPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwCreateAApplicationPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ApartmentViewPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwAddAApplicantPage;
using CazamioProject.PageObjects.WebSiteCazamioTenantPages.ModalWindowPleaseTellUsYourName;
using CazamioProject.PageObjects.WebSiteCazamioTenantPages.MdlWndwAreYouSureLogOut;
using CazamioProject.PageObjects.WebSiteLandlordPages.ApplicationDetailPage;
using CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowEditApplication;
using CazamioProject.Objects;

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

        public static TenantApplicant TenantApplicant { get { return GetPage<TenantApplicant>(); } }
        public static TenantOccupant TenantOccupant { get { return GetPage<TenantOccupant>(); } }
        public static TenantGuarantor TenantGuarantor { get { return GetPage<TenantGuarantor>(); } }
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

        public static MarketplaceAdmin MarketplaceAdmin { get { return GetPage<MarketplaceAdmin>(); } }
        public static Broker Broker { get { return GetPage<Broker>(); } }
        public static Agent Agent { get { return GetPage<Agent>(); } }
        public static AgentBroker AgentBroker { get { return GetPage<AgentBroker>(); } }
        public static Owner Owner { get { return GetPage<Owner>(); } }
        public static Building Building { get { return GetPage<Building>(); } }
        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
        public static SideBarLandlord SideBarLandlord => GetPage<SideBarLandlord>();
        public static Dashboard Dashboard => GetPage<Dashboard>();
        public static ListOfBuildings ListOfBuildings => GetPage<ListOfBuildings>();
        public static ListOfApartments ListOfApartments => GetPage<ListOfApartments>();
        public static ListOfApplications ListOfApplications => GetPage<ListOfApplications>();
        public static ListOfMarketplaceAdmins ListOfMarketplaceAdmins => GetPage<ListOfMarketplaceAdmins>();
        public static PreApprovals PreApprovals => GetPage<PreApprovals>();
        public static Templates Templates => GetPage<Templates>();
        public static PaymentSettings PaymentSettings => GetPage<PaymentSettings>();
        public static ListOfTransactions ListOfTransactions => GetPage<ListOfTransactions>();
        public static Agents Agents => GetPage<Agents>();
        public static ListOfOwners ListOfOwners => GetPage<ListOfOwners>();
        public static Marketplace Marketplace => GetPage<Marketplace>();
        public static ModalWindowAreYouSureLogOutLandlordBroker ModalWindowAreYouSureLogOutLandlordBroker => GetPage<ModalWindowAreYouSureLogOutLandlordBroker>();
        public static ModalWindowCreateNewAgent ModalWindowCreateNewAgent => GetPage<ModalWindowCreateNewAgent>();
        public static ResetYourPassword ResetYourPassword => GetPage<ResetYourPassword>();
        public static NewBuilding NewBuilding => GetPage<NewBuilding>();
        public static ModalWindowPaymentOptions ModalWindowPaymentOptions => GetPage<ModalWindowPaymentOptions>();
        public static PopUpWndowNewAgentCreatedSuccessfully PopUpWndowNewAgentCreatedSuccessfully => GetPage<PopUpWndowNewAgentCreatedSuccessfully>();
        public static ModalWndwCreateNewOwner ModalWndwCreateNewOwner => GetPage<ModalWndwCreateNewOwner>();
        public static PaginationPicker PaginationPicker => GetPage<PaginationPicker>();
        public static MdlWndwCreateANewMarketplaceAdmin MdlWndwCreateANewMarketplaceAdmin => GetPage<MdlWndwCreateANewMarketplaceAdmin>();
        public static ListOfCommissions ListOfCommissions => GetPage<ListOfCommissions>();
        public static ListOfBrokers ListOfBrokers => GetPage<ListOfBrokers>();
        public static ModalWindowCreateNewBroker ModalWindowCreateNewBroker => GetPage<ModalWindowCreateNewBroker>();
        public static ModalWindowPetPolicies ModalWindowPetPolicies => GetPage<ModalWindowPetPolicies>();
        public static BuildingView BuildingView => GetPage<BuildingView>();
        public static AddApartments AddApartments => GetPage<AddApartments>();
        public static Reports Reports => GetPage<Reports>();
        public static ModalWndwCreateApplication ModalWndwCreateApplication => GetPage<ModalWndwCreateApplication>();
        public static ApartmentView ApartmentView => GetPage<ApartmentView>();
        public static ModalWndwAddAApplicant ModalWndwAddAApplicant => GetPage<ModalWndwAddAApplicant>();
        public static ModalWindowPleaseTellUsYourName ModalWindowPleaseTellUsYourName => GetPage<ModalWindowPleaseTellUsYourName>();
        public static MdlWndwAreYouSureLogOut MdlWndwAreYouSureLogOut => GetPage<MdlWndwAreYouSureLogOut>();
        public static ApplicationDetail ApplicationDetail => GetPage<ApplicationDetail>();
        public static ModalWindowEditApplication ModalWindowEditApplication => GetPage<ModalWindowEditApplication>();

        #endregion
    }
}
