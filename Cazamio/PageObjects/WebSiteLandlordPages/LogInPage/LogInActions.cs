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
        [AllureStep("EnterEmailPasswordLogInPgAsSuperAdmin")]
        public LogInLandlord EnterEmailPasswordLogInPgAsSuperAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteAdmin.EMAIL_SUPER_ADMIN_SUPER);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsMarketplaceAdmin")]
        public LogInLandlord EnterEmailPasswordLogInPgAsMarketplaceAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteAdmin.EMAIL_MARKETPLACE_ADMIN_CHUI_CHUBAKA);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsBroker")]
        public LogInLandlord EnterEmailPasswordLogInPgAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsAgent")]
        public LogInLandlord EnterEmailPasswordLogInPgAsAgent()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteAdmin.EMAIL_AGENT_TEST);
            WaitUntil.WaitSomeInterval(500);

            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
           
            return this;
        }

        [AllureStep("EnterChangingEmailPasswordLogInPgAsBroker")]
        public LogInLandlord EnterChangingEmailPasswordLogInPgAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            WaitUntil.WaitSomeInterval(500);

            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_NEW_GENEREAL);

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
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("ClickLinkForgotPassword")]
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
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("CopiedForEnterEmailFromEmailCreateAdmin")]
        public LogInLandlord CopiedForEnterEmailFromEmailCreateAdmin(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("CopiedForEnterPsswrdFromEmailCreateAdmin")]
        public LogInLandlord CopiedForEnterPsswrdFromEmailCreateAdmin(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPasswordLogInPg.SendKeys(code);

            return this;
        }
    }
}
