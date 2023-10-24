﻿using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
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
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            string getUnitAddress = FieldInputUnitAddressModalWndw.Text;
            string getUnitAddressActual = getUnitAddress.ToString();
            //Console.WriteLine($"Unit Address step second: {getUnitAddressActual}");

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

        [AllureStep("GetUnitAddressStepSecond")]
        public string GetShortUnitAddressStepSecond()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FieldInputUnitAddressModalWndw);
            string getUnitAddress = FieldInputUnitAddressModalWndw.Text;
            Regex regexPartUnitAddress = new Regex(@"^...................");
            string regexPartUnitAddressActual = regexPartUnitAddress.Match(getUnitAddress).ToString();
            Console.WriteLine($"Unit Address step second: {regexPartUnitAddressActual}");

            return regexPartUnitAddressActual;
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

        [AllureStep("ClickFieldInputRequestedOfferPriceModalWndw")]
        public ModalWndwCreateAApplication ClickFieldInputRequestedOfferPriceModalWndw()
        {
            WaitUntil.CustomElementIsVisible(FieldInputRequestedOfferPriceModalWndw);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPriceModalWndw, GenerateRandomDataHelper.RandomNumberWithoutZero(3));
            return this;
        }

        [AllureStep("SelectDateAvailableForAprtmntsModalWndw")]
        public ModalWndwCreateAApplication SelectDateAvailableForAprtmntsModalWndw()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMoveInDateModalWndw, 10);
            Button.Click(FieldInputMoveInDateModalWndw);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectDayOnDatePickerFourthLine(DaysFourthLineForDatePiker.FOURTH_LINE_THIRD_NUMBER, " ");

            return this;
        }

        [AllureStep("GetLeasePriceStepThirdFromUi")]
        public string GetLeasePriceStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FieldInputLeasePriceModalWndw);
            string getLeasePrice = FieldInputLeasePriceModalWndw.GetAttribute("value");
            string getLeasePriceActual = getLeasePrice.ToString();
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getLeasePriceActual;
        }

        [AllureStep("GetSecurityDepositStepThirdFromUi")]
        public string GetSecurityDepositStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FieldInputSecurityDepositModalWndw);
            string getSecurityDeposit = FieldInputSecurityDepositModalWndw.GetAttribute("value");
            string getSecurityDepositActual = getSecurityDeposit.ToString();
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getSecurityDepositActual;
        }

        [AllureStep("GetMonthlyRentsPrePaymentStepThirdFromUi")]
        public string GetMonthlyRentsPrePaymentStepThirdFromUi()
        {
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsVisible(FieldInputMonthlyRentsPrePaymentModalWndw);
            string getMonthlyRentsPrePayment = FieldInputMonthlyRentsPrePaymentModalWndw.GetAttribute("value");
            string getMonthlyRentsPrePaymentActual = getMonthlyRentsPrePayment.ToString();
            //Console.WriteLine($"Email step first: {getEmailActual}");

            return getMonthlyRentsPrePaymentActual;
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
    }
}