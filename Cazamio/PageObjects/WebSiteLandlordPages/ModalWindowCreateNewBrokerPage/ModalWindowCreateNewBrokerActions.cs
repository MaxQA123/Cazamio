using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage
{
    public partial class ModalWindowCreateNewBroker
    {
        [AllureStep("EnterFirstLastNamesEmail")]
        public ModalWindowCreateNewBroker EnterFirstLastNamesEmail()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, Name.FirstName());
            InputGeneral.InputFunctionWithClear(FieldInputLastName, Name.LastName());
            InputGeneral.InputFunctionWithClear(FieldInputEmail, GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumberWithoutZero(3) + GenerateRandomDataHelper.RandomEmail(2) + NameDomen.PUTS_BOX);

            return this;
        }

        [AllureStep("ClickButtonCreateMdlWndwCrtNwBrkr")]
        public ModalWindowCreateNewBroker ClickButtonCreateMdlWndwCrtNwBrkr()
        {
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("CopyEmailFromModalWindowCreateNewBroker")]
        public string CopyEmailFromModalWindowCreateNewBroker()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = FieldInputEmail.GetAttribute("value");
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }

        [AllureStep("CopyEmailBeforeDogFromModalWindowCreateNewBroker")]
        public string CopyEmailBeforeDogFromModalWindowCreateNewBroker()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmail.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^..........");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }
    }
}
