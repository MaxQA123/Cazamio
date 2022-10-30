using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage
{
    public partial class ModalWindowCreateNewBroker
    {
        [AllureStep("EnterFirstLastNameEmailPhnNmbrCellMdlWndw")]
        public ModalWindowCreateNewBroker EnterFirstLastNameEmailPhnNmbrCellMdlWndw()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstNameCrtNwBrkrOnMdlwndw, Name.FirstName());
            InputGeneral.InputFunctionWithClear(FieldInputLastNameCrtNwBrkrOnMdlwndw, Name.LastName());
            //FieldInputEmailCrtNwBrkrOnMdlwndw.SendKeys("jhfhgfh");
            InputGeneral.InputFunctionWithClear(FieldInputEmailCrtNwBrkrOnMdlwndw, GenerateRandomDataHelper.RandomEmail(5) + NameDomen.XITROO);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberCrtNwBrkrOnMdlwndw, GenerateRandomDataHelper.RandomPhoneNumber(10));
            InputGeneral.InputFunctionWithClear(FieldInputCellCrtNwBrkrOnMdlwndw, GenerateRandomDataHelper.RandomPhoneNumber(10));

            return this;
        }

        [AllureStep("CopyEmailFromMdlWndwCreateBroker")]
        public string CopyEmailFromMdlWndwCreateBroker()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = Browser._Driver.FindElement(By.XPath("//input[@id = 'email']")).GetAttribute("value");
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }

        [AllureStep("CopyFirstNameFromMdlWndwCreateBroker")]
        public string CopyFirstNameFromMdlWndwCreateBroker()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyFirstName = Browser._Driver.FindElement(By.XPath("//input[@id = 'first-name']")).GetAttribute("value");
            string copyFirstNameActual = copyFirstName.ToString();

            return copyFirstNameActual;
        }

        [AllureStep("ClickButtonSaveCrtNwBrkrOnMdlwndw")]
        public ModalWindowCreateNewBroker ClickButtonSaveCrtNwBrkrOnMdlwndw()
        {
            Button.Click(ButtonSaveCrtNwBrkrOnMdlwndw);

            return this;
        }


    }
}
