using CazamioProgect.Helpers;
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
        [AllureStep("EnterFirstLastNameEmailPhnNmbrCellMdlWndw")]
        public ModalWindowCreateNewAgent EnterFirstLastNameEmailPhnNmbrCellMdlWndw()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstNameCrtNwBrkrOnMdlwndw, Name.FirstName());
            InputGeneral.InputFunctionWithClear(FieldInputLastNameCrtNwBrkrOnMdlwndw, Name.LastName());
            InputGeneral.InputFunctionWithClear(FieldInputEmailCrtNwBrkrOnMdlwndw, GenerateRandomDataHelper.RandomEmail(7) + NameDomen.PUTS_BOX);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberCrtNwBrkrOnMdlwndw, GenerateRandomDataHelper.RandomPhoneNumber(10));
            InputGeneral.InputFunctionWithClear(FieldInputCellCrtNwBrkrOnMdlwndw, GenerateRandomDataHelper.RandomPhoneNumber(10));

            return this;
        }

        [AllureStep("EnterBrokerAgentCommissionMdlWndw")]
        public ModalWindowCreateNewAgent EnterBrokerAgentCommissionMdlWndw()
        {
            InputGeneral.InputFunctionWithClear(FieldInputBrokerCommissionMdlwndw, GenerateRandomDataHelper.RandomNumberWithoutZero(12));
            InputGeneral.InputFunctionWithClear(FieldInputAgentCommissionMdlwndw, GenerateRandomDataHelper.RandomNumberWithoutZero(12));

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
            Regex regexPartEmail = new Regex(@"^.......");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("ClickButtonSaveCrtNwAgntOnMdlwndw")]
        public ModalWindowCreateNewAgent ClickButtonSaveCrtNwAgntOnMdlwndw()
        {
            Button.Click(ButtonSaveCrtNwBrkrOnMdlwndw);

            return this;
        }


    }
}
