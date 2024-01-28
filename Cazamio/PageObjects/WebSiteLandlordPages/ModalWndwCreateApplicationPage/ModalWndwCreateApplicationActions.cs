using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using CazamioProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwCreateAApplicationPage
{
    public partial class ModalWndwCreateApplication
    {
        string emailTenantAppOccGuarNotCreated = TestDataForWebSiteTenant.EMAIL_TENANT_CREATOR_NOT_CREATED;
        string emailOnlyTenantAppNotCreated = TestDataForWebSiteTenant.EMAIL_TENANT_NOT_CREATED;
        string unitShortAddress = "2 Washington Square #1";

        TenantApplicant tenantApplicant = new TenantApplicant().Generate();

        [AllureStep("EnterExistEmailInFieldMainApplicantEmailAddressModalWndw")]
        public ModalWndwCreateApplication EnterExistEmailInFieldMainApplicantEmailAddressModalWndw()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddressModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddressModalWndw, tenantApplicant.EmailAddressTenant);
            WaitUntil.CustomElementIsVisible(ItemEmailAddressModalWndw);
            Button.Click(ItemEmailAddressModalWndw);

            return this;
        }

        [AllureStep("EnterUnitShortAddressInFieldUnitAddressModalWndw")]
        public ModalWndwCreateApplication EnterUnitShortAddressInFieldUnitAddressModalWndw()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            Button.Click(FieldInputUnitAddressModalWndw);
            //InputGeneral.InputFunctionWithClear(FieldInputUnitAddressModalWndw, unitShortAddress);
            WaitUntil.CustomElementIsVisible(ItemUnitAddressModalWndw);
            Button.Click(ItemUnitAddressModalWndw);

            return this;
        }

        [AllureStep("EnterNewEmailTenantAppOccGuarInFieldMainApplicantEmailAddressModalWndw")]
        public ModalWndwCreateApplication EnterNewEmailTenantAppOccGuarInFieldMainApplicantEmailAddressModalWndw()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddressModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddressModalWndw, emailTenantAppOccGuarNotCreated);

            return this;
        }

        [AllureStep("EnterNewEmailOnlyTenantAppInFieldMainApplicantEmailAddressModalWndw")]
        public ModalWndwCreateApplication EnterNewEmailOnlyTenantAppInFieldMainApplicantEmailAddressModalWndw()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddressModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddressModalWndw, emailOnlyTenantAppNotCreated);

            return this;
        }

        [AllureStep("ClickButtonNextInFirstStepModalWndw")]
        public ModalWndwCreateApplication ClickButtonNextInFirstStepModalWndw()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonNextInFirstStepModalWndw);
            Button.Click(ButtonNextInFirstStepModalWndw);

            return this;
        }

        [AllureStep("GetUnitAddressStepSecond")]
        public string GetUnitAddressStepSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            string getUnitAddress = FieldInputUnitAddressModalWndw.Text;
            string getUnitAddressActual = getUnitAddress.ToString();

            return getUnitAddressActual;
        }

        [AllureStep("GetEmailStepFirst")]
        public string GetEmailStepFirst()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddressModalWndw);
            string getEmail = FieldInputMainApplicantEmailAddressModalWndw.GetAttribute("value");
            string getEmailActual = getEmail.ToString();
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getEmailActual;
        }

        [AllureStep("GetEmailStepThird")]
        public string GetEmailStepThird()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(ValueFromStringLeadEmailModalWndw);
            string getEmailStepThird = ValueFromStringLeadEmailModalWndw.Text;
            string getEmailStepThirdActual = getEmailStepThird.ToString();
            //Console.WriteLine($"Email step third: {getEmailStepThirdActual}");

            return getEmailStepThirdActual;
        }

        [AllureStep("GetUnitAddressStepThird")]
        public string GetUnitAddressStepThird()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(ValueFromStringUnitAddressModalWndw);
            string getUnitAddress = ValueFromStringUnitAddressModalWndw.Text;
            Regex regexPartUnitAddress = new Regex(@"^......................");
            string regexPartUnitAddressActual = regexPartUnitAddress.Match(getUnitAddress).ToString();

            //Console.WriteLine($"Unit Address step third: {regexPartUnitAddressActual}");

            return regexPartUnitAddressActual;
        }

        [AllureStep("GetShortUnitAddressStepSecond")]
        public string GetShortUnitAddressStepSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            string getUnitAddress = FieldInputUnitAddressModalWndw.Text;
            Regex regex = new Regex(@"\b\w+\b");
            MatchCollection matches = regex.Matches(getUnitAddress);
            string[] firstThreeWords = new string[Math.Min(3, matches.Count)];
            for (int i = 0; i < firstThreeWords.Length; i++)
            {
                firstThreeWords[i] = matches[i].Value;
            }
            string resultPartUnitAddressActual = string.Join(" ", firstThreeWords);

            return resultPartUnitAddressActual;
        }

        [AllureStep("GetUnitNumberStepSecond")]
        public string GetUnitNumberStepSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            string getUnitAddress = FieldInputUnitAddressModalWndw.Text;
            Regex regexUnitNumber = new Regex(@"[0-9]{1}$");
            string regexUnitNumberActual = regexUnitNumber.Match(getUnitAddress).ToString();
            Console.WriteLine($"Unit Address step second: {regexUnitNumberActual}");

            return regexUnitNumberActual;
        }

        [AllureStep("EnterPriceFieldInputRequestedOfferPriceModalWndw")]
        public ModalWndwCreateApplication EnterPriceFieldInputRequestedOfferPriceModalWndw()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputRequestedOfferPriceModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPriceModalWndw, GenerateRandomDataHelper.RandomNumberWithoutZero(3));
            return this;
        }

        [AllureStep("SelectDateAvailableForCreateApplicationModalWndwViaListOfApplication")]
        public ModalWndwCreateApplication SelectDateAvailableForCreateApplicationModalWndwViaListOfApplication()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMoveInDateModalWndwForCreateApplicationModalWndwViaListOfApplication, 10);
            Button.Click(FieldInputMoveInDateModalWndwForCreateApplicationModalWndwViaListOfApplication);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(Pages.DatePicker
                .SelectorDaysPickerDaysSecondLine());

            return this;
        }

        [AllureStep("SelectDateAvailableForCreateApplicationModalWndwViaApartmentView")]
        public ModalWndwCreateApplication SelectDateAvailableForCreateApplicationModalWndwViaApartmentView()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMoveInDateModalWndwForCreateApplicationModalWndwViaApartmentView, 10);
            Button.Click(FieldInputMoveInDateModalWndwForCreateApplicationModalWndwViaApartmentView);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(Pages.DatePicker
                .SelectorDaysPickerDaysSecondLine());

            return this;
        }

        [AllureStep("GetLeasePriceStepThirdFromUi")]
        public int GetLeasePriceStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FieldInputLeasePriceModalWndw);
            int getLeasePrice = int.Parse(FieldInputLeasePriceModalWndw.GetAttribute("value"));
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getLeasePrice;
        }

        [AllureStep("GetSecurityDepositStepThirdFromUi")]
        public int GetSecurityDepositStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FieldInputSecurityDepositModalWndw);
            int getSecurityDeposit = int.Parse(FieldInputSecurityDepositModalWndw.GetAttribute("value"));
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getSecurityDeposit;
        }

        [AllureStep("GetMonthlyRentsPrePaymentStepThirdFromUi")]
        public int GetMonthlyRentsPrePaymentStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FieldInputMonthlyRentsPrePaymentModalWndw);
            int getMonthlyRentsPrePayment = int.Parse(FieldInputMonthlyRentsPrePaymentModalWndw.GetAttribute("value"));
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getMonthlyRentsPrePayment;
        }

        [AllureStep("GetRentalTermsStepThirdFromUi")]
        public string GetRentalTermsStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FieldInputRentalTermsModalWndw);
            string getRentalTerms = FieldInputRentalTermsModalWndw.GetAttribute("value");
            string getRentalTermsActual = getRentalTerms.ToString();
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getRentalTermsActual;
        }

        [AllureStep("ClickButtonCreateStepThreeModalWndw")]
        public ModalWndwCreateApplication ClickButtonCreateStepThreeModalWndw()
        {
            WaitUntil.CustomElementIsVisible(ButtonCreateStepThreeModalWndw);
            Button.Click(ButtonCreateStepThreeModalWndw);

            return this;
        }

        [AllureStep("CopyEmailBeforeDogFromMdlWndwCreateApplicationStepFirst")]
        public string CopyEmailBeforeDogFromMdlWndwCreateApplicationStepFirst()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddressModalWndw);
            string copyPartEmail = FieldInputMainApplicantEmailAddressModalWndw.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^............");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("ClickButtonAddApplicantStepFourModalWndw")]
        public ModalWndwCreateApplication ClickButtonAddApplicantStepFourModalWndw()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddApplicantStepFourModalWndw);
            Button.Click(ButtonAddApplicantStepFourModalWndw);

            return this;
        }

        [AllureStep("AddConcessionForModalWndw")]
        public ModalWndwCreateApplication AddConcessionForModalWndw()
        {
            WaitUntil.CustomElementIsVisible(ButtonPlusAddConcessionModalWndw);
            Button.Click(ButtonPlusAddConcessionModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFreeModalWndw, "0.75");

            return this;
        }

        [AllureStep("GetNetEffectiveStepThirdFromUi")]
        public decimal GetNetEffectiveStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            decimal getNetEffective = decimal.Parse(FieldNetEffectiveRentModalWndw.GetAttribute("value"));

            return getNetEffective;
        }

        [AllureStep("AddRequestedWorkForModalWndw")]
        public ModalWndwCreateApplication AddRequestedWorkForModalWndw()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPlusAddRequestedWorkModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedWorkModalWndw, GeneralTestDataForAllUsers.TEXT_SHORT_LOREM);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickTab();

            return this;
        }

        [AllureStep("EnterTextInFieldRefferalDetailsModalWndw")]
        public ModalWndwCreateApplication EnterTextInFieldRefferalDetailsModalWndw()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CheckBoxIsThereAReferralAgentModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputRefferalDetailsModalWndw, GeneralTestDataForAllUsers.TEXT_SHORT_LOREM);

            return this;
        }

        [AllureStep("ClickButtonCloseStepFourModalWndwModalWndw")]
        public ModalWndwCreateApplication ClickButtonCloseStepFourModalWndwModalWndw()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonCloseStepFourModalWndw);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }
    }
}
