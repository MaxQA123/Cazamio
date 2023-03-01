using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.SideBarLandlord
{
    public partial class SideBarLandlord
    {
        [FindsBy(How = How.XPath, Using = "//div[@class= 'edit-btns']//input[@id = 'logo']")]
        public IWebElement ButtonUploadLogoOfLandlord;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'upload-account-photo']//input[@id = 'avatar']")]
        public IWebElement ButtonUploadPhotoOfAvatarLandlord;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'remove-account-photo']")]
        public IWebElement linkRemovePhotoOfLandlord;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'user-name']")]
        public IWebElement UserNameOfSidebarLandlordWebSite;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'user-role']")]
        public IWebElement UserNameRoleOfSidebarLandlordWebSite;

        #region MessageSuccessfully

        [FindsBy(How = How.XPath, Using = "//span[text()= 'Logo image was changed']")]
        public IWebElement MessageChangeImageLogoLandlordSuccess;

        [FindsBy(How = How.XPath, Using = "//span[text()= 'Profile image was changed']")]
        public IWebElement MessageChangeImageAvatarUserSuccess;

        [FindsBy(How = How.XPath, Using = "//span[text()= 'Profile image was removed']")]
        public IWebElement MessageRemoveImageAvatarUserSuccess;

        #endregion

        [FindsBy(How = How.XPath, Using = "//a[@href= '/dashboard']")]
        public IWebElement ButtonDashboardSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/buildings']")]
        public IWebElement ButtonBuildingsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/apartments']")]
        public IWebElement ButtonApartmentsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/applications']")]
        public IWebElement ButtonApplicationsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/pre-approvals']")]
        public IWebElement ButtonPreApprovalsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/lease-sign-documents']")]
        public IWebElement ButtonLeaseSignDocumentsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/payment-settings/payment-view']")]
        public IWebElement ButtonPaymentSettingsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/transactions']")]
        public IWebElement ButtonTransactionsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/agents']")]
        public IWebElement ButtonAgentsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/owners']")]
        public IWebElement ButtonOwnersSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/marketplace']")]
        public IWebElement ButtonMarketplaceSidebar;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'sidebar-layout']")]
        public IWebElement ButtonLogOutSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/landlords-list']")]
        public IWebElement ButtonLandlordsSidebar;
    }
}
