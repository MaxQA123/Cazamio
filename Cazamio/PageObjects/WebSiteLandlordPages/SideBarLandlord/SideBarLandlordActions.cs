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
            var str = "//ul[@class= 'sidebar-nav']//li";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//a[contains(@href, '{_locationItemSidebar}')]"));
        }

        [AllureStep("SelectItemsOnSidebar")]
        public SideBarLandlord SelectItemsOnSidebar(int item, string locationItemSidebar)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _item = SelectorItemsOnSidebar(locationItemSidebar);

            _item[item].Click();

            return this;
        }
    }
}
