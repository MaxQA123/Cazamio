using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.HowShallWeCallYouPage
{
    public partial class ModalWindowHowShallWeCallYou
    {
        [AllureStep("EnterFirstName")]
        public ModalWindowHowShallWeCallYou EnterFirstName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstNameMdlWndw);
            InputGeneral.InputFunctionWithClear(FieldInputFirstNameMdlWndw, Name.FirstName());
            return this;
        }

        [AllureStep("EnterLastName")]
        public ModalWindowHowShallWeCallYou EnterLastName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLastNameMdlWndw);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameMdlWndw, Name.LastName());
            return this;
        }

        [AllureStep("ClickButtonSaveMdlWndw")]
        public ModalWindowHowShallWeCallYou ClickButtonSaveMdlWndw()
        {
            WaitUntil.CustomElementIsVisible(ButtonSaveMdlWndw);
            Button.Click(ButtonSaveMdlWndw);
            return this;
        }

        [AllureStep("GetFirstNameFromModalWindowHowShallWeCallYou")]
        public string GetFirstNameFromModalWindowHowShallWeCallYou()
        {
            WaitUntil.WaitSomeInterval(100);
            string getFirstName = FieldInputFirstNameMdlWndw.GetAttribute("value");
            string getFirstNameActual = getFirstName.ToString();

            return getFirstNameActual;
        }

        [AllureStep("GetLastNameFromModalWindowHowShallWeCallYou")]
        public string GetLastNameFromModalWindowHowShallWeCallYou()
        {
            WaitUntil.WaitSomeInterval(100);
            string getLastName = FieldInputFirstNameMdlWndw.GetAttribute("value");
            string getLastNameActual = getLastName.ToString();

            return getLastNameActual;
        }
    }
}
