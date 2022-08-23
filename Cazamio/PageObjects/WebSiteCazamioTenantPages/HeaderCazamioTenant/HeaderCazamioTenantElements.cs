using CazamioProgect.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant
{
    public partial class HeaderCazamioTenant
    {
        public IWebElement ButtonSignUpHdrCzmTnnt => Browser._Driver.FindElement(_ButtonSignUpHdrCzmTnnt);
        public static readonly By _ButtonSignUpHdrCzmTnnt = By.XPath("");

        public IWebElement ButtonLogInHdrCzmTnnt => Browser._Driver.FindElement(_ButtonLogInHdrCzmTnnt);
        public static readonly By _ButtonLogInHdrCzmTnnt = By.XPath("//a[@href = '/account/signin']");

        public IWebElement ButtonMyPreApprovedApartmentsHdrCzmTnnt => Browser._Driver.FindElement(_ButtonMyPreApprovedApartmentsHdrCzmTnnt);
        public static readonly By _ButtonMyPreApprovedApartmentsHdrCzmTnnt = By.XPath("//a[@href= '/my-pre-approved-apartments']");

        public IWebElement ButtonMyApplicationsHdrCzmTnnt => Browser._Driver.FindElement(_ButtonMyApplicationsHdrCzmTnnt);
        public static readonly By _ButtonMyApplicationsHdrCzmTnnt = By.XPath("//a[@href= '/my-info/applications']");
    }
}
