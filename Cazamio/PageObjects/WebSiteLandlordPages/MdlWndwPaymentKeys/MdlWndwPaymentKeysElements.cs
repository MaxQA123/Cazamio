using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.MdlWndwPaymentKeys
{
    public partial class MdlWndwPaymentKeys
    {
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Cardknox']")]
        public IWebElement ItemCardknox;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'czmodev359376936c0543b58126c97f9ff55c68']")]
        public IWebElement ItemApiKeyCardknox;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'AuthorizeNet']")]
        public IWebElement ItemAuthorizeNet;

        [FindsBy(How = How.XPath, Using = "//span[text() = '2L7uB4UzeA9gf366']")]
        public IWebElement ItemApiKeyAuthorizeNet;
        
        [FindsBy(How = How.XPath, Using = "//ng-select[@placeholder = 'Search payment system']//input")]
        public IWebElement ButtonSearchPaymentSystem;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Save']")]
        public IWebElement ButtonSave;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'btn-close-popup']")]
        public IWebElement ButtonCross;
    }
}
