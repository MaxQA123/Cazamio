using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.LogInPage
{
    public partial class LogInLandlord
    {
        [AllureStep("EnterEmailPasswordLogInPgAsLandlord")]
        public LogInLandlord EnterEmailPasswordLogInPgAsLandlord()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteLandlord.emailLandlordMartin);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataForWebSiteLandlord.passwordLandlordMartin);

            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsBroker")]
        public LogInLandlord EnterEmailPasswordLogInPgAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteLandlord.emailBrokerLiluDalas);
            WaitUntil.WaitSomeInterval(500);
            //InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataForWebSiteLandlord.newPasswordBrokerLiluDalasBroker);

            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.passwordGeneral);
           
            return this;
        }

        [AllureStep("EnterChangingEmailPasswordLogInPgAsLandlord")]
        public LogInLandlord EnterChangingEmailPasswordLogInPgAsLandlord()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteLandlord.emailLandlordTest);
            WaitUntil.WaitSomeInterval(500);
            //InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataForWebSiteLandlord.newPasswordBrokerLiluDalasBroker);

            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("ClickIconShowLogInPg")]
        public LogInLandlord ClickIconShowLogInPg()
        {
            Button.Click(IconShowLogInPg);

            return this;
        }

        [AllureStep("ClickButtonLetsGoLogInPg")]
        public LogInLandlord ClickButtonLetsGoLogInPg()
        {
            Button.Click(ButtonLetsGoLogInPg);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("CopiedForEnterEmailLogInPg")]
        public LogInLandlord CopiedForEnterEmailLogInPg(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, _email);

            return this;
        }

        [AllureStep("EnterPasswordLogInPgAsBroker")]
        public LogInLandlord EnterPasswordLogInPgAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("ClickLogInLandlord")]
        public LogInLandlord ClickLinkForgotPassword()
        {
            Button.Click(LinkForgotPassword);

            return this;
        }

        [AllureStep("CopiedForEnterPsswrdFromEmailCreateBroker")]
        public LogInLandlord CopiedForEnterPsswrdFromEmailCreateBroker(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPasswordLogInPg.SendKeys(code);

            return this;
        }

        [AllureStep("CopiedForEnterEmailFromEmailCreateBroker")]
        public LogInLandlord CopiedForEnterEmailFromEmailCreateBroker(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }
    }
}
