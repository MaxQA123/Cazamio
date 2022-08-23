using CazamioProgect.Helpers;
using CazamioProgect.PageObjects.GeneralPages.LogInPageCazamioTenant;
using CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant;
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

        #region TenantWebSiteCazamio

        public static HeaderCazamioTenant HeaderCazamioTenant => GetPage<HeaderCazamioTenant>();
        public static LogInCazamioTenant LogInCazamioTenant => GetPage<LogInCazamioTenant>();

        #endregion

    }
}
