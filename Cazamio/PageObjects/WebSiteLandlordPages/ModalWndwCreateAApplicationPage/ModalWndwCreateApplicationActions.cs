using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwCreateAApplicationPage
{
    public partial class ModalWndwCreateAApplication
    {
        [AllureStep("EnterEmailInFieldMainApplicantEmailAddressModalWndw")]
        public ModalWndwCreateAApplication EnterEmailInFieldMainApplicantEmailAddressModalWndw()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddressModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddressModalWndw, TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT);
            WaitUntil.CustomElementIsVisible(ItemEmailAddressModalWndw);
            Button.Click(ItemEmailAddressModalWndw);

            return this;
        }

        [AllureStep("ClickButtonNextModalWndw")]
        public ModalWndwCreateAApplication ClickButtonNextModalWndw()
        {
            WaitUntil.CustomElementIsVisible(ButtonNextModalWndw);
            Button.Click(ButtonNextModalWndw);

            return this;
        }

        [AllureStep("GetUnitAddress")]
        public string GetUnitAddress()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            string getUnitAddress = FieldInputUnitAddressModalWndw.Text;
            string getUnitAddressActual = getUnitAddress.ToString();
            Console.WriteLine($"Unit Address: {getUnitAddressActual}");

            return getUnitAddressActual;
        }
    }
}
