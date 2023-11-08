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
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddressMdlWndw);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressMdlWndw, emailTenantOccupant);
            return this;
        }
    }
}
