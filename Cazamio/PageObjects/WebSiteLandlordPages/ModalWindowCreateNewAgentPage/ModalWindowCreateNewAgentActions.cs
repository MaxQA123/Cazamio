using CazamioProgect.Helpers;
using CazamioProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewAgentPage
{
    public partial class ModalWindowCreateNewAgent
    {

        Agent agent = new Agent().Generate();

        [AllureStep("EnterFirstLastNameEmailPhnNmbrCellMdlWndw")]
        public ModalWindowCreateNewAgent EnterFirstLastNameEmailPhnNmbrCellMdlWndw()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstNameCrtNwBrkrOnMdlwndw, agent.FirstName);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameCrtNwBrkrOnMdlwndw, agent.LastName);
            InputGeneral.InputFunctionWithClear(FieldInputEmailCrtNwBrkrOnMdlwndw, agent.EmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberCrtNwBrkrOnMdlwndw, agent.PhoneNumber);
            InputGeneral.InputFunctionWithClear(FieldInputCellCrtNwBrkrOnMdlwndw, agent.Cell);

            return this;
        }

        [AllureStep("EnterBrokerAgentCommissionMdlWndw")]
        public ModalWindowCreateNewAgent EnterBrokerAgentCommissionMdlWndw()
        {
            InputGeneral.InputFunctionWithClear(FieldInputBrokerCommissionMdlwndw, agent.AgentCommission);
            InputGeneral.InputFunctionWithClear(FieldInputAgentCommissionMdlwndw, agent.BrokerCommission);

            return this;
        }

        [AllureStep("CopyEmailFromMdlWndwCreateAgent")]
        public string CopyEmailFromMdlWndwCreateAgent()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = Browser._Driver.FindElement(By.XPath("//input[@id = 'email']")).GetAttribute("value");
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }

        [AllureStep("CopyEmailBeforeDogFromModalWindowCreateNewAgent")]
        public string CopyEmailBeforeDogFromModalWindowCreateNewAgent()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmailCrtNwBrkrOnMdlwndw.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^..........");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("ClickButtonSaveCrtNwAgntOnMdlwndw")]
        public ModalWindowCreateNewAgent ClickButtonSaveCrtNwAgntOnMdlwndw()
        {
            Button.Click(ButtonSaveCrtNwAgntOnMdlwndw);

            return this;
        }


    }
}
