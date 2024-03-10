using CazamioProgect.Helpers;
using CazamioProject.Objects;
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
        MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();
        Broker broker = new Broker().Generate();
        Agent agent = new Agent().Generate();
        AgentBroker agentBroker = new AgentBroker().Generate();

        [AllureStep("EnterEmailPasswordLogInPgAsSuperAdmin")]
        public LogInLandlord EnterEmailPasswordLogInPgAsSuperAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataForWebSiteAdmin.EMAIL_SUPER_ADMIN);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsMarketplaceAdmin")]
        public LogInLandlord EnterEmailPasswordLogInPgAsMarketplaceAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, marketplaceAdmin.EmailAddressMarketplaceAdmin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsBroker")]
        public LogInLandlord EnterEmailPasswordLogInPgAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, broker.EmailAddressBroker);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsAgent")]
        public LogInLandlord EnterEmailPasswordLogInPgAsAgent()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, agent.EmailAddressAgent);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
           
            return this;
        }

        [AllureStep("EnterEmailPasswordLogInPgAsAgentBroker")]
        public LogInLandlord EnterEmailPasswordLogInPgAsAgentBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, agentBroker.EmailAddressAgentBroker);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

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
            WaitUntil.WaitSomeInterval(2000);
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

        [AllureStep("PasteForEnterPsswrdFromEmailCreateBroker")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateBroker(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPasswordLogInPg.SendKeys(code);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateBroker")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateBroker(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateAdmin")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateAdmin(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateAdmin")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateAdmin(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPasswordLogInPg.SendKeys(code);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateAgent")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateAgent(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateAgent")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateAgent(string code)
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
