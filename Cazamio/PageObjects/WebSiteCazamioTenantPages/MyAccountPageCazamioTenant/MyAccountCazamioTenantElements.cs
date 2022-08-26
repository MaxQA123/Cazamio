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

        [FindsBy(How = How.XPath, Using = "//div[@class = 'profile-loadable-wrapper']//div[@class = 'cazamio-button-content']")]
        public IWebElement ButtonEditMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirsNameMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastNameMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'account-email']")]
        public IWebElement FieldInputEmailMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'phone-number']")]
        public IWebElement FieldInputPhoneNumberMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'birtday']")]
        public IWebElement FieldInputDateOfBirthMyAccntPgTabAccnt;

        #endregion

        #region SectionAccount



        #endregion
    }
}
