using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ResetYourPasswordPage
{
    public partial class ResetYourPassword
    {
        [FindsBy(How = How.XPath, Using = "//input[@id= 'email']")]
        public IWebElement FieldInputEmailRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'large primary-action absolute-loader']")]
        public IWebElement ButtonSendInstructionsRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//h3[text() = 'Your password was successfully sent']")]
        public IWebElement MessageYourPasswordWasSuccessfullySentRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'password1']")]
        public IWebElement FieldInputNewPasswordRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'password2']")]
        public IWebElement FieldInputConfirmPasswordRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//img[@src = 'assets/img/account/eye.svg ']")]
        public IWebElement IconForFieldNewPsswrdRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//form[@class= 'ng-dirty ng-touched ng-valid']//div[2]//img[@src = 'assets/img/account/eye.svg ']")]
        public IWebElement IconForFieldConfirmPsswrdRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'btn btn-warning btn-link btn-lg card-footer-btn']")]
        public IWebElement ButtonResetPasswordlRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/account/signin']")]
        public IWebElement ButtonSiginPageRstPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//button//a[@href = '/account/signin']")]
        public IWebElement ButtonBackToLoginPageRstPsswrdPg;
    }
}
