using CazamioProgect.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant
{
    public partial class HeaderCazamioTenant
    {
        [FindsBy(How = How.XPath, Using = "//a[@href = '/account/signup']")]
        public IWebElement ButtonSignUpHdrCzmTnnt;

        public IWebElement ButtonLogInHdrCzmTnnt => Browser._Driver.FindElement(_ButtonLogInHdrCzmTnnt);
        public static readonly By _ButtonLogInHdrCzmTnnt = By.XPath("//a[@href = '/account/signin']");

        public IWebElement ButtonMyPreApprovedApartmentsHdrCzmTnnt => Browser._Driver.FindElement(_ButtonMyPreApprovedApartmentsHdrCzmTnnt);
        public static readonly By _ButtonMyPreApprovedApartmentsHdrCzmTnnt = By.XPath("//a[@href= '/my-pre-approved-apartments']");

        public IWebElement ButtonMyApplicationsHdrCzmTnnt => Browser._Driver.FindElement(_ButtonMyApplicationsHdrCzmTnnt);
        public static readonly By _ButtonMyApplicationsHdrCzmTnnt = By.XPath("//a[@href= '/my-info/applications']");
    }
}
