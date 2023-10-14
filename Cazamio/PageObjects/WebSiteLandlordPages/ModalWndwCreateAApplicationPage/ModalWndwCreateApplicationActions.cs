using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        [AllureStep("GetUnitAddressStepSecond")]
        public string GetUnitAddressStepSecond()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            string getUnitAddress = FieldInputUnitAddressModalWndw.Text;
            string getUnitAddressActual = getUnitAddress.ToString();
            //Console.WriteLine($"Unit Address step second: {getUnitAddressActual}");

            return getUnitAddressActual;
        }

        [AllureStep("GetEmailStepFirst")]
        public string GetEmailStepFirst()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddressModalWndw);
            string getEmail = FieldInputMainApplicantEmailAddressModalWndw.GetAttribute("value");
            string getEmailActual = getEmail.ToString();
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getEmailActual;
        }

        [AllureStep("GetEmailStepThird")]
        public string GetEmailStepThird()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ValueFromStringLeadEmailModalWndw);
            string getEmailStepThird = ValueFromStringLeadEmailModalWndw.Text;
            string getEmailStepThirdActual = getEmailStepThird.ToString();
            //Console.WriteLine($"Email step third: {getEmailStepThirdActual}");

            return getEmailStepThirdActual;
        }

        [AllureStep("GetUnitAddressStepThird")]
        public string GetUnitAddressStepThird()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ValueFromStringUnitAddressModalWndw);
            string getUnitAddress = ValueFromStringUnitAddressModalWndw.Text;
            Regex regexPartUnitAddress = new Regex(@"^......................");
            string regexPartUnitAddressActual = regexPartUnitAddress.Match(getUnitAddress).ToString();

            //Console.WriteLine($"Unit Address step third: {regexPartUnitAddressActual}");

            return regexPartUnitAddressActual;
        }
    }
}
