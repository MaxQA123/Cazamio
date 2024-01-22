using CazamioProgect.Helpers;
using CazamioProject.Objects;
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
        Broker broker = new Broker().Generate();

        [AllureStep("Enter first, last names, email broker's")]
        public ModalWindowCreateNewBroker EnterFirstLastNamesEmail()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, broker.FirstName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, broker.LastName);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, broker.EmailAddress);

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
