using CazamioProgect.Helpers;
using CazamioProgect.PageObjects.DatePickerModalWindow;
using CazamioProgect.PageObjects.EmailXitrooPage;
using CazamioProgect.PageObjects.GeneralPages.LogInPageCazamioTenant;
using CazamioProgect.PageObjects.GeneralPages.SignUpCazamioTenantPage;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant;
using CazamioProgect.PageObjects.WebSiteLandlordPages.LogInPage;
using CazamioProgect.PageObjects.WebSiteLandlordPages.SideBarLandlord;
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

        #region TenantWebSiteCazamio

        public static HeaderCazamioTenant HeaderCazamioTenant => GetPage<HeaderCazamioTenant>();
        public static SignUpCazamioTenant SignUpCazamioTenant => GetPage<SignUpCazamioTenant>();
        public static LogInCazamioTenant LogInCazamioTenant => GetPage<LogInCazamioTenant>();
        public static MyAccountCazamioTenant MyAccountCazamioTenant => GetPage<MyAccountCazamioTenant>();

        #endregion

        #region LandlordWebSite

        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
        public static SideBarLandlord SideBarLandlord => GetPage<SideBarLandlord>();

        #endregion

    }
}
