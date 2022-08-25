using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.GeneralPages.SignUpCazamioTenantPage
{
    public partial class SignUpCazamioTenant
    {
        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstNameSignUpPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastNameSignUpPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement FieldInputEmailSignUpPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'password']")]
        public IWebElement FieldInputPasswordSignUpPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Show']")]
        public IWebElement IconShowSignUpPg;

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@class = 'large primary-action absolute-loader']")]
        public IWebElement ButtonGetStartedSignUpPg;
    }
}
