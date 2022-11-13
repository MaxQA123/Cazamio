using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.EmailXitrooPage
{
    public partial class EmailXitroo
    {
        [FindsBy(How = How.XPath, Using = "//iframe[@id = 'mailContentFrame']")]
        public IWebElement IframeXitrooLetter;

        [FindsBy(How = How.XPath, Using = "//tbody[@id = 'mailList']//th[text() = '1']")]
        public IWebElement SelectLetterNumberOneNew;

        [FindsBy(How = How.XPath, Using = "//button[@id = 'backButton']")]
        public IWebElement ButtonBackEmail;

        [FindsBy(How = How.XPath, Using = "//button[@id = 'requestButton']")]
        public IWebElement ButtonSearchEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'mailInput']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://testlanlord.cazamiodemo.com/account/email-confirm')]")]
        public IWebElement LinkForConfirmAccountTenant;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://landlord.cazamiodemo.com/account/email-confirm')]")]
        public IWebElement LinkForConfirmAccountLandlordbroker;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://landlord.cazamiodemo.com/account/reset-password')]")]
        public IWebElement LinkForResetPassworBroker;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://abodebyreside.cazamiodemo.com/account/reset-password')]")]
        public IWebElement LinkForResetPassworTenant;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'Use this this password to access the site:')]")]
        public IWebElement PassworForBrokerFromEmail;
    }
}
