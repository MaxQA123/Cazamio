using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.EmailXitrooPage
{
    public partial class EmailXitroo
    {
        [AllureStep("CopiedForEnterEmail")]
        public EmailXitroo CopiedForEnterEmail(string _email)
        {
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, _email);

            return this;
        }

        [AllureStep("ClickSearchButton")]
        public EmailXitroo ClickSearchButton()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(ButtonSearchEmail);
            Button.Click(ButtonSearchEmail);

            return this;
        }

        [AllureStep("OpenNewlyLetter")]
        public EmailXitroo OpenNewlyLetter()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(SelectLetterNumberOneNew);

            return this;
        }

        [AllureStep("OpenNewlyLetter")]
        public EmailXitroo ClickButtonBackEmail()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonBackEmail);

            return this;
        }

        [AllureStep("ClickLinkForConfirmAccount")]
        public EmailXitroo ClickLinkForConfirmAccountTenant()
        {
            WaitUntil.WaitSomeInterval(3000);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(LinkForConfirmAccountTenant);
            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }

        [AllureStep("ClickLinkForConfirmAccountBroker")]
        public EmailXitroo ClickLinkForConfirmAccountBroker()
        {
            //WaitUntil.WaitSomeInterval(3000);
            //Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(LinkForConfirmAccountLandlordbroker);
            Browser._Driver.SwitchTo().DefaultContent();
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickLinkForResetPasswordBroker")]
        public EmailXitroo ClickLinkForResetPasswordBroker()
        {
            WaitUntil.WaitSomeInterval(3000);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(LinkForResetPassworBroker);
            Browser._Driver.SwitchTo().DefaultContent();
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickLinkForResetPasswordTenant")]
        public EmailXitroo ClickLinkForResetPasswordTenant()
        {
            WaitUntil.WaitSomeInterval(3000);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(LinkForResetPassworTenant);
            Browser._Driver.SwitchTo().DefaultContent();
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("CopyEmailFromXitrooPage")]
        public string CopyEmailFromXitrooPage()
        {
            WaitUntil.WaitSomeInterval(1000);
            string copyEmail = Browser._Driver.FindElement(By.XPath("//input[@id = 'mailInput']")).GetAttribute("value");
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }

        [AllureStep("CopyLinkFromEmailXitroo")]
        public string CopyLinkFromEmailXitroo()
        {
            WaitUntil.WaitSomeInterval(3000);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.WaitSomeInterval(500);
            string copyLink = Browser._Driver.FindElement(By.XPath("//a[contains(@href, 'https://landlord.cazamiodemo.com/account/email-confirm')]")).Text;
            string copyLinkActual = copyLink.ToString();

            return copyLinkActual;
        }

        public string CopyPasswordFromEmailForCreateBroker()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getLastName = PassworForBrokerFromEmail.Text;
            Regex regexGetLastName = new Regex(@"[^\s]+$");
            string lastNameActual = regexGetLastName.Match(getLastName).ToString();

            return lastNameActual;
        }
    }
}
