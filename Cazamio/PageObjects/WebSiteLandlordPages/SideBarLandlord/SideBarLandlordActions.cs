using CazamioProgect.Helpers;
using CazamioProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.SideBarLandlord
{
    public partial class SideBarLandlord
    {
        MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();
        Broker broker = new Broker().Generate();
        Agent agent = new Agent().Generate();
        AgentBroker agentBroker = new AgentBroker().Generate();

        #region UploadImage

        [AllureStep("UploadImageLogoLandlordFirst")]
        public SideBarLandlord UploadImageLogoLandlordFirst()
        {
            WaitUntil.WaitSomeInterval(3000);
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.LOGO_IMG_ADMIN_FIRST));
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            return this;
        }

        [AllureStep("UploadImageLogoLandlordSecond")]
        public SideBarLandlord UploadImageLogoLandlordSecond()
        {
            WaitUntil.WaitSomeInterval(3000);
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.LOGO_IMG_ADMIN_SECOND));
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            return this;
        }

        [AllureStep("UploadImageAvatarUserLandlordFirst")]
        public SideBarLandlord UploadImageAvatarUserLandlordFirst()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            WaitUntil.CustomElementIsVisible(MessageChangeImageAvatarUserSuccess);
            return this;
        }

        [AllureStep("UploadImageAvatarUserLandlordSecond")]
        public SideBarLandlord UploadImageAvatarUserLandlordSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_SECOND));
            WaitUntil.CustomElementIsVisible(MessageChangeImageAvatarUserSuccess);
            return this;
        }

        [AllureStep("ClicklinkRemovePhotoOfLandlord")]
        public SideBarLandlord ClicklinkRemovePhotoOfLandlord()
        {
            Button.Click(linkRemovePhotoOfLandlord);
            WaitUntil.CustomElementIsVisible(MessageRemoveImageAvatarUserSuccess);

            return this;
        }

        private static IWebElement _element;

        [AllureStep("SelectorItemsOnSidebar")]
        public static IList<IWebElement> SelectorItemsOnSidebar(string _locationItemSidebar)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//aside[@class= 'aside-container']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//ul[@class= 'sidebar-nav']//li//a[contains(@href, '{_locationItemSidebar}')]"));
        }

        [AllureStep("SelectItemsOnSidebar")]
        public SideBarLandlord SelectItemsOnSidebar(int item, string locationItemSidebar)
        {
            WaitUntil.WaitSomeInterval(1000);
            IList<IWebElement> _item = SelectorItemsOnSidebar(locationItemSidebar);

            _item[item].Click();

            return this;
        }

        #endregion

        [AllureStep("ClickButtonDashboard")]
        public SideBarLandlord ClickButtonDashboard()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonDashboardSidebar);

            return this;
        }

        [AllureStep("ClickButtonBuildings")]
        public SideBarLandlord ClickButtonBuildings()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonBuildingsSidebar);

            return this;
        }

        [AllureStep("ClickButtonApartments")]
        public SideBarLandlord ClickButtonApartments()
        {
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonApartmentsSidebar);

            return this;
        }

        [AllureStep("ClickButtonApplications")]
        public SideBarLandlord ClickButtonApplications()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonApplicationsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonBrokers")]
        public SideBarLandlord ClickButtonBrokers()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonBrokersSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }
        //Hiddedn this element
        //[AllureStep("ClickButtonPreApprovalsSidebar")]
        //public SideBarLandlord ClickButtonPreApprovalsSidebar()
        //{
        //    WaitUntil.WaitSomeInterval(1000);
        //    Button.Click(ButtonPreApprovalsSidebar);
        //    WaitUntil.WaitSomeInterval(1000);

        //    return this;
        //}

        [AllureStep("ClickButtonMarketplaceAdmins")]
        public SideBarLandlord ClickButtonMarketplaceAdmins()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonMarketplaceAdminsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonLeaseSignDocuments")]
        public SideBarLandlord ClickButtonLeaseSignDocuments()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonLeaseSignDocumentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonLeaseSignDocumentsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonPaymentSettings")]
        public SideBarLandlord ClickButtonPaymentSettings()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonPaymentSettingsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonPaymentSettingsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonTransactions")]
        public SideBarLandlord ClickButtonTransactions()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonTransactionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonTransactionsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonCommissions")]
        public SideBarLandlord ClickButtonCommissions()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonCommissionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonCommissionsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonAgents")]
        public SideBarLandlord ClickButtonAgents()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonAgentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonAgentsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("SwitchTabClickButtonBrokers")]
        public SideBarLandlord SwitchTabClickButtonBrokers()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonAgentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonAgentsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonOwners")]
        public SideBarLandlord ClickButtonOwners()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonOwnersSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonOwnersSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonMarketplace")]
        public SideBarLandlord ClickButtonMarketplace()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonMarketplaceSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonMarketplaceSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonReports")]
        public SideBarLandlord ClickButtonReports()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonReportsAdminsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonLogOut")]
        public SideBarLandlord ClickButtonLogOut()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonLogOutSidebar);
            WaitUntil.WaitSomeInterval(1000);

            Pages.ModalWindowAreYouSureLogOutLandlordBroker
                .ClickButtonYesIAmSureOnMdlwndw();

            return this;
        }
    }
}
