using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwAddAApplicantPage
{
    public partial class ModalWndwAddAApplicant
    {
        string emailTenantOccupant = TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_ONE;
        string emailTenantGuarantor = TestDataForWebSiteTenant.EMAIL_GUARANTOR;
        string emailTenantOccupantNotCreated = TestDataForWebSiteTenant.EMAIL_TENANT_OCCUPANT_NOT_CREATED;
        string emailTenantGuarantorNotCreated = TestDataForWebSiteTenant.EMAIL_TENANT_GUARANTOR_NOT_CREATED;

        [AllureStep("EnterEmailTenantOccupant")]
        public ModalWndwAddAApplicant EnterEmailTenantOccupantNotCreated()
        {
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddressMdlWndwAddAApplicant);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddressMdlWndwAddAApplicant, emailTenantOccupantNotCreated);
            return this;
        }

        [AllureStep("EnterEmailTenantGuarantorNotCreated")]
        public ModalWndwAddAApplicant EnterEmailTenantGuarantorNotCreated()
        {
            WaitUntil.CustomElementIsVisible(SecondFieldInputEmailAddressMdlWndwAddAApplicant);
            InputGeneral.InputFunctionWithClear(SecondFieldInputEmailAddressMdlWndwAddAApplicant, emailTenantGuarantorNotCreated);
            return this;
        }

        [AllureStep("EnterEmailTenantOccupant")]
        public ModalWndwAddAApplicant EnterEmailTenantOccupant()
        {
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddressMdlWndwAddAApplicant);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddressMdlWndwAddAApplicant, emailTenantOccupant);
            return this;
        }

        [AllureStep("ClickButtonPlusAnotherApplicant")]
        public ModalWndwAddAApplicant ClickButtonPlusAnotherApplicant()
        {
            WaitUntil.CustomElementIsVisible(ButtonPlusAnotherApplicantMdlWndwAddAApplicant);
            Button.Click(ButtonPlusAnotherApplicantMdlWndwAddAApplicant);

            return this;
        }

        [AllureStep("EnterEmailTenantGuarantor")]
        public ModalWndwAddAApplicant EnterEmailTenantGuarantor()
        {
            WaitUntil.CustomElementIsVisible(SecondFieldInputEmailAddressMdlWndwAddAApplicant);
            InputGeneral.InputFunctionWithClear(SecondFieldInputEmailAddressMdlWndwAddAApplicant, emailTenantGuarantor);
            return this;
        }

        [AllureStep("ClickSecondCheckTheBoxThisIGuarantor")]
        public ModalWndwAddAApplicant ClickSecondCheckTheBoxThisIGuarantor()
        {
            WaitUntil.CustomElementIsVisible(SecondCheckTheBoxThisIGuarantorMdlWndwAddAApplicant);
            Button.Click(SecondCheckTheBoxThisIGuarantorMdlWndwAddAApplicant);

            return this;
        }

        [AllureStep("ClickButtonAdd")]
        public ModalWndwAddAApplicant ClickButtonAdd()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddMdlWndwAddAApplicant);
            Button.Click(ButtonAddMdlWndwAddAApplicant);

            return this;
        }

        [AllureStep("GetPartEmailAddressOccupant")]
        public string GetPartEmailAddressOccupant()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddressMdlWndwAddAApplicant);
            string getEmailOccupant = FirstFieldInputEmailAddressMdlWndwAddAApplicant.GetAttribute("value");
            Regex regexEmailOccupant = new Regex(@"^............");
            string partEmail = regexEmailOccupant.Match(getEmailOccupant).ToString();
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return partEmail;
        }
    }
}
