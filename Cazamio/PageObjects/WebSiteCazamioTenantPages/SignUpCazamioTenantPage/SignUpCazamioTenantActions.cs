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

namespace CazamioProgect.PageObjects.GeneralPages.SignUpCazamioTenantPage
{
    public partial class SignUpCazamioTenant
    {
        //string 
        [AllureStep("EnterFirstLastNameEmailPasswordSignUpPg")]
        public SignUpCazamioTenant EnterFirstLastNameEmailPasswordSignUpPg()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFirstNameSignUpPg, Name.FirstName());
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameSignUpPg, Name.LastName());
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputEmailSignUpPg, GenerateRandomDataHelper.RandomEmail(5) + NameDomen.PUTS_BOX);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordSignUpPg, "Qwerty123!");
            WaitUntil.WaitSomeInterval(100);
            Button.Click(IconShowSignUpPg);

            return this;
        }

        [AllureStep("ClickIconShowSignUpPg")]
        public SignUpCazamioTenant ClickIconShowSignUpPg()
        {
            Button.Click(IconShowSignUpPg);

            return this;
        }

        [AllureStep("ClickButtonGetStartedSignUpPg")]
        public SignUpCazamioTenant ClickButtonGetStartedSignUpPg()
        {
            Button.Click(ButtonGetStartedSignUpPg);

            return this;
        }

        [AllureStep("CopyEmailFromSignUpPg")]
        public string CopyEmailFromSignUpPg()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = FieldInputEmailSignUpPg.GetAttribute("value");
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }

        [AllureStep("CopyEmailBeforeDogFromSignUpPg")]
        public string CopyEmailBeforeDogFromSignUpPg()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmailSignUpPg.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.....");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        //public SignUpCazamioTenant EnterFirstLastNameEmailPasswordSignUpPg()
        //{
        //    WaitUntil.WaitSomeInterval(500);
        //    InputGeneral.InputFunctionWithClear(FieldInputFirstNameSignUpPg, Name.FirstName());
        //    WaitUntil.WaitSomeInterval(500);
        //    InputGeneral.InputFunctionWithClear(FieldInputLastNameSignUpPg, Name.LastName());
        //    WaitUntil.WaitSomeInterval(500);
        //    InputGeneral.InputFunctionWithClear(FieldInputEmailSignUpPg, GenerateRandomDataHelper.RandomEmail(5) + NameDomen.PUTS_BOX);
        //    WaitUntil.WaitSomeInterval(500);
        //    InputGeneral.InputFunctionWithClear(FieldInputPasswordSignUpPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

        //    return this;
        //}
    }
}
