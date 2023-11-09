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
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddressMdlWndw);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddressMdlWndw, emailTenantOccupant);
            return this;
        }

        [AllureStep("ClickButtonPlusAnotherApplicantMdlWndw")]
        public ModalWndwAddAApplicant ClickButtonPlusAnotherApplicantMdlWndw()
        {
            WaitUntil.CustomElementIsVisible(ButtonPlusAnotherApplicantMdlWndw);
            Button.Click(ButtonPlusAnotherApplicantMdlWndw);

            return this;
        }

        [AllureStep("EnterEmailTenantGuarantor")]
        public ModalWndwAddAApplicant EnterEmailTenantGuarantor()
        {
            WaitUntil.CustomElementIsVisible(SecondFieldInputEmailAddressMdlWndw);
            InputGeneral.InputFunctionWithClear(SecondFieldInputEmailAddressMdlWndw, emailTenantGuarantor);
            return this;
        }
    }
}
