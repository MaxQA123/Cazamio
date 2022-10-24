using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.GeneralPages.LogInPageCazamioTenant
{
    public partial class LogInCazamioTenant
    {
        [AllureStep("EnterEmailPasswordOnLgInAsTenantCzmTnntTW")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsTenantCzmTnntTW()
        {
            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, TestDataForWebSiteCazamio.emailTenantWife);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("EnterEmailPasswordOnLgInAsOccupantCzmTnntTC")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsOccupantCzmTnntTC()
        {
            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, TestDataForWebSiteCazamio.emailCurrentOccupantTomCruz);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("EnterEmailPasswordOnLgInAsOccupantCzmTnntLK")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsOccupantCzmTnntLK()
        {
            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, TestDataForWebSiteCazamio.emailCurrentOccupantTomCruz);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("EnterEmailPasswordOnLgInAsOccupantCzmTnntMA")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsOccupantCzmTnntMA()
        {
            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, TestDataForWebSiteCazamio.emailCurrentOccupantTomCruz);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("EnterEmailPasswordOnLgInAsGuarantorCzmTnntML")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsGuarantorCzmTnntML()
        {
            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, TestDataForWebSiteCazamio.emailCurrentOccupantTomCruz);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("ClickIconShowLgInCazmTnnt")]
        public LogInCazamioTenant ClickIconShowLgInCazmTnnt()
        {
            WaitUntil.WaitSomeInterval(500);
            IconShowLgInCazmTnnt.Click();

            return this;
        }

        [AllureStep("SetCheckBoxRememberMeLgInCazmTnnt")]
        public LogInCazamioTenant SetCheckBoxRememberMeLgInCazmTnnt()
        {
            WaitUntil.WaitSomeInterval(500);
            CheckBoxRememberMeLgInCazmTnnt.Click();

            return this;
        }

        [AllureStep("ClickButtonLogInLgInCazmTnnt")]
        public LogInCazamioTenant ClickButtonLogInLgInCazmTnnt()
        {
            WaitUntil.WaitSomeInterval(500);
            ButtonLogInLgInCazmTnnt.Click();

            return this;
        }

        [AllureStep("CopiedForEnterEmailLogInPg")]
        public LogInCazamioTenant CopiedForEnterEmailLogInPg(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, _email);

            return this;
        }

        [AllureStep("EnterPasswordOnLogInPg")]
        public LogInCazamioTenant EnterPasswordOnLogInPg()
        {
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.passwordGeneral);

            return this;
        }

        [AllureStep("EnterEmailNewPasswordOnLogInPg")]
        public LogInCazamioTenant EnterEmailNewPasswordOnLogInPg()
        {
            WaitUntil.WaitSomeInterval(1000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, TestDataForWebSiteCazamio.emailCurrentOccupantTomCruz);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.passwordNew);

            return this;
        }

        [AllureStep("ClickButtonForgotPasswordLgInCazmTnnt")]
        public LogInCazamioTenant ClickButtonForgotPasswordLgInCazmTnnt()
        {
            Button.Click(ButtonForgotPasswordLgInCazmTnnt);

            return this;
        }
    }
}
