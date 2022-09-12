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

        #region MessageSuccessfully

        [FindsBy(How = How.XPath, Using = "//span[text()= 'Logo image was changed']")]
        public IWebElement MessageChangeImageLogoLandlordSuccess;

        [FindsBy(How = How.XPath, Using = "//span[text()= 'Profile image was changed']")]
        public IWebElement MessageChangeImageAvatarUserSuccess;

        [FindsBy(How = How.XPath, Using = "//span[text()= 'Profile image was removed']")]
        public IWebElement MessageRemoveImageAvatarUserSuccess;

        #endregion
    }
}
