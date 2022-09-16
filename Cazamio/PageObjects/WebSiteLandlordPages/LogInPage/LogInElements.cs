using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.LogInPage
{
    public partial class LogInLandlord
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement FieldInputEmailLogInPg;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']")]
        public IWebElement FieldInputPasswordLogInPg;

        [FindsBy(How = How.XPath, Using = "//span[@class= 'show-password']")]
        public IWebElement IconShowLogInPg;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'btn btn-warning btn-link btn-lg card-footer-btn']")]
        public IWebElement ButtonLetsGoLogInPg;

        [FindsBy(How = How.XPath, Using = "//h4[text() = 'Login']")]
        public IWebElement TitleLogInPg;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/account/forgot-password']")]
        public IWebElement LinkForgotPassword;
    }
}
