using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwAddAApplicantPage
{
    public partial class ModalWndwAddAApplicant
    {
        string emailTenantOccupant = TestDataForWebSiteTenant.EMAIL_CURRENT_OCCUPANT_ONE;
        string emailTenantGuarantor = TestDataForWebSiteTenant.EMAIL_GUARANTOR;

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
            WaitUntil.CustomElementIsVisible(SecondCheckTheBoxThisIGuarantorMdlWndwAddAApplicant);
            Button.Click(SecondCheckTheBoxThisIGuarantorMdlWndwAddAApplicant);

            return this;
        }
    }
}
