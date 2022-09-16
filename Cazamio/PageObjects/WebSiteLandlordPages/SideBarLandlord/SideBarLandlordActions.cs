using CazamioProgect.Helpers;
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
        #region UploadImage

        [AllureStep("UploadImageLogoLandlordFirst")]
        public SideBarLandlord UploadImageLogoLandlordFirst()
        {
            WaitUntil.WaitSomeInterval(3000);
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.logoImgLandlordFirst));
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            return this;
        }

        [AllureStep("UploadImageLogoLandlordSecond")]
        public SideBarLandlord UploadImageLogoLandlordSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.logoImgLandlordSecond));
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            return this;
        }

        [AllureStep("UploadImageAvatarUserLandlordFirst")]
        public SideBarLandlord UploadImageAvatarUserLandlordFirst()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.avatarImgLandlordFirst));
            WaitUntil.CustomElementIsVisible(MessageChangeImageAvatarUserSuccess);
            return this;
        }

        [AllureStep("UploadImageAvatarUserLandlordSecond")]
        public SideBarLandlord UploadImageAvatarUserLandlordSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.avatarImgLandlordSecond));
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

        [AllureStep("ClickButtonDashboardSidebar")]
        public SideBarLandlord ClickButtonDashboardSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonDashboardSidebar);

            return this;
        }

        [AllureStep("ClickButtonBuildingsSidebar")]
        public SideBarLandlord ClickButtonBuildingsSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonBuildingsSidebar);

            return this;
        }

        [AllureStep("ClickButtonApartmentsSidebar")]
        public SideBarLandlord ClickButtonApartmentsSidebar()
        {
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonApartmentsSidebar);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickButtonApplicationsSidebar")]
        public SideBarLandlord ClickButtonApplicationsSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonApplicationsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonPreApprovalsSidebar")]
        public SideBarLandlord ClickButtonPreApprovalsSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonPreApprovalsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonLeaseSignDocumentsSidebar")]
        public SideBarLandlord ClickButtonLeaseSignDocumentsSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonLeaseSignDocumentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonLeaseSignDocumentsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonPaymentSettingsSidebar")]
        public SideBarLandlord ClickButtonPaymentSettingsSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonPaymentSettingsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonPaymentSettingsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonTransactionsSidebar")]
        public SideBarLandlord ClickButtonTransactionsSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonTransactionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonTransactionsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonBrokersSidebar")]
        public SideBarLandlord ClickButtonBrokersSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonBrokersSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonBrokersSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("SwitchTabClickButtonBrokersSidebar")]
        public SideBarLandlord SwitchTabClickButtonBrokersSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonBrokersSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonBrokersSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonOwnersSidebar")]
        public SideBarLandlord ClickButtonOwnersSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonOwnersSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonOwnersSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonMarketplaceSidebar")]
        public SideBarLandlord ClickButtonMarketplaceSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonMarketplaceSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonMarketplaceSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonLogOutSidebar")]
        public SideBarLandlord ClickButtonLogOutSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonLogOutSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }
    }
}
