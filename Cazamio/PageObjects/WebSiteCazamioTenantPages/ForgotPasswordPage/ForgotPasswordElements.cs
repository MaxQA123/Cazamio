using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ForgotPasswordPage
{
    public partial class ForgotPassword
    {
        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement InputFieldEmailFrgtPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement ButtonSendRecoveryLinkFrgtPsswrdPg;
    }
}
