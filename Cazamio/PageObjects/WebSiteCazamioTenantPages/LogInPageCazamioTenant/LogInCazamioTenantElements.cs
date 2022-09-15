using CazamioProgect.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.GeneralPages.LogInPageCazamioTenant
{
    public partial class LogInCazamioTenant
    {
        public IWebElement FieldInputEmailAddressLgInCazmTnnt => Browser._Driver.FindElement(_FieldInputEmailAddressLgInCazmTnnt);
        public static readonly By _FieldInputEmailAddressLgInCazmTnnt = By.XPath("//input[@id = 'email']");

        public IWebElement FieldInputPasswordLgInCazmTnnt => Browser._Driver.FindElement(_FieldInputPasswordLgInCazmTnnt);
        public static readonly By _FieldInputPasswordLgInCazmTnnt = By.XPath("//input[@id = 'password']");

        public IWebElement IconShowLgInCazmTnnt => Browser._Driver.FindElement(_IconShowLgInCazmTnnt);
        public static readonly By _IconShowLgInCazmTnnt = By.XPath("//div[@class= 'show-password-container']//span[@class = 'ng-star-inserted']");

        public IWebElement CheckBoxRememberMeLgInCazmTnnt => Browser._Driver.FindElement(_CheckBoxRememberMeLgInCazmTnnt);
        public static readonly By _CheckBoxRememberMeLgInCazmTnnt = By.XPath("//label[@for= 'checkbox-remember']//span[@class = 'check-label-box']");

        public IWebElement ButtonLogInLgInCazmTnnt => Browser._Driver.FindElement(_ButtonLogInLgInCazmTnnt);
        public static readonly By _ButtonLogInLgInCazmTnnt = By.XPath("//button[@aria-label= 'button']//span[text() = 'Login']");

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Account was successfully activated']")]
        public IWebElement MessageAccountWasSuccessfullyActivated;
    }
}
