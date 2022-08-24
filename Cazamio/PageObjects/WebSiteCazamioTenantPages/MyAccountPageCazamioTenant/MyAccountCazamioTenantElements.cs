using CazamioProgect.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant
{
    public partial class MyAccountCazamioTenant
    {
        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/profile']")]
        public IWebElement TabAccount;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/applications']")]
        public IWebElement TabApplications;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/favorites']")]
        public IWebElement TabFavorites;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/history']")]
        public IWebElement TabHistory;

        #region TabAccount

        //public static readonly By _Tab

        #endregion

        #region SectionAccount



        #endregion
    }
}
