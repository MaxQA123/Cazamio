using CazamioProgect.Helpers;
using CazamioProject.Objects;
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
        TenantApplicant tenantApplicant = new TenantApplicant().Generate();
        TenantGuarantor tenantGuarantor = new TenantGuarantor().Generate();
        TenantOccupant tenantOccupant = new TenantOccupant().Generate();

        [AllureStep("EnterEmailPasswordOnLgInAsTenantApplicant")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsTenantApplicant()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddressLgInCazmTnnt);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, tenantApplicant.EmailAddressTenant);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordOnLgInAsOccupant")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsOccupant()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddressLgInCazmTnnt);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, tenantOccupant.EmailAddressTenant);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordOnLgInAsOccupantAlfred")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsOccupantAlfred()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddressLgInCazmTnnt);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_SECOND);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordOnLgInAsGuarantorJimmy")]
        public LogInCazamioTenant EnterEmailPasswordOnLgInAsGuarantorJimmy()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddressLgInCazmTnnt);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, tenantGuarantor.EmailAddressTenant);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

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
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailNewPasswordOnLogInPg")]
        public LogInCazamioTenant EnterEmailNewPasswordOnLogInPg()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddressLgInCazmTnnt);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressLgInCazmTnnt, tenantApplicant.EmailAddressTenant);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLgInCazmTnnt, GeneralTestDataForAllUsers.PASSWORD_NEW_GENEREAL);

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
