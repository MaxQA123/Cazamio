using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        [AllureStep("VerifyTitleAddApartmentsPage")]
        public AddApartments VerifyTitleAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(TitleAddApartmentsPage);
            Assert.IsTrue(Successfully.IsVisible(TitleAddApartmentsPage));

            return this;
        }

        [AllureStep("VerifyBuildingNameAddApartmentsPage")]
        public AddApartments VerifyBuildingNameAddApartmentsPage(string getBuildingNameFromBuildingView, string getBuildingNameFromAddApartments)
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.AreEqual(getBuildingNameFromBuildingView, getBuildingNameFromAddApartments);
            Console.WriteLine($"{getBuildingNameFromBuildingView} = {getBuildingNameFromAddApartments}");

            return this;
        }

        [AllureStep("GetMonthlyRentsPrePayment")]
        public string GetMonthlyRentsPrePayment()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMonthlyRentsPrePayment);
            string getMonthlyRentsPrePayment = FieldInputMonthlyRentsPrePayment.GetAttribute("value");
            string getMonthlyRentsPrePaymentActual = getMonthlyRentsPrePayment.ToString();

            return getMonthlyRentsPrePaymentActual;
        }

        [AllureStep("VerifyMonthlyRentsPrePayment")]
        public AddApartments VerifyMonthlyRentsPrePayment(string getMonthlyRentsPrePayment)
        {
            Assert.AreEqual(getMonthlyRentsPrePayment, TestDataForWebSiteAdmin.DEFAULT_MONTHLY_RENTS_PREPAYMENT);

            Console.WriteLine($"MonthlyRentsPrePayment AR: {getMonthlyRentsPrePayment} = {TestDataForWebSiteAdmin.DEFAULT_MONTHLY_RENTS_PREPAYMENT} :ER MonthlyRentsPrePayment");

            return this;
        }

        //[AllureStep("GetApartmentTypeAddApartmentsPage")]
        //public string GetApartmentTypeAddApartmentsPage()
        //{
        //    WaitUntil.CustomElementIsVisible(ItemApartmentTypeMultiFamily);
        //    string getApartmentType = ItemApartmentTypeMultiFamily.Text;
        //    string getApartmentTypeActual = getApartmentType.ToString();

        //    return getApartmentTypeActual;
        //}

        [AllureStep("VerifyApartmentTypeAddApartmentsPage")]
        public AddApartments VerifyApartmentTypeAddApartmentsPage(string getApartmentType)
        {
            Assert.AreEqual(getApartmentType, TestDataForWebSiteAdmin.DEFAULT_APARTMENT_TYPE);

            Console.WriteLine($"Apartment Type AR: {getApartmentType} = {TestDataForWebSiteAdmin.DEFAULT_APARTMENT_TYPE} :ER Apartment Type");

            return this;
        }

        [AllureStep("GetApartmentHoldDepositAddApartmentsPage")]
        public string GetApartmentHoldDepositAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputApartmentHoldDeposit);
            string getApartmentHoldDeposit = FieldInputApartmentHoldDeposit.GetAttribute("value");
            string getApartmentHoldDepositActual = getApartmentHoldDeposit.ToString();

            return getApartmentHoldDepositActual;
        }

        [AllureStep("VerifyApartmentHoldDepositAddApartmentsPage")]
        public AddApartments VerifyApartmentHoldDepositAddApartmentsPage(string getApartmentHoldDeposit)
        {
            Assert.AreEqual(getApartmentHoldDeposit, TestDataForWebSiteAdmin.DEFAULT_APARTMENT_HOLD_DEPOSIT);

            Console.WriteLine($"Apartment Hold Deposit AR: {getApartmentHoldDeposit} = {TestDataForWebSiteAdmin.DEFAULT_APARTMENT_HOLD_DEPOSIT} :ER Apartment Hold Deposit");

            return this;
        }

        [AllureStep("GetRentalTermsAddApartmentsPage")]
        public string GetRentalTermsAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemTwelveMonthsRentalTerms);
            string getRentalTerms = ItemTwelveMonthsRentalTerms.Text;
            string getRentalTermsActual = getRentalTerms.ToString();

            return getRentalTermsActual;
        }

        [AllureStep("VerifyRentalTermsAddApartmentsPage")]
        public AddApartments VerifyRentalTermsAddApartmentsPage(string getRentalTerms)
        {
            Assert.AreEqual(getRentalTerms, TestDataForWebSiteAdmin.DEFAULT_RENTAL_TERMS);

            Console.WriteLine($"Rental Terms AR: {getRentalTerms} = {TestDataForWebSiteAdmin.DEFAULT_RENTAL_TERMS} :ER Rental Terms");

            return this;
        }

        #region RequiredDocuments

        [AllureStep("GetRequiredDocumentsThreeRecentPaystubsAddApartmentsPage")]
        public string GetRequiredDocumentsThreeRecentPaystubsAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemThreeRecentPaystubs);
            string getThreeRecentPaystubs = ItemThreeRecentPaystubs.Text;
            string getThreeRecentPaystubsActual = getThreeRecentPaystubs.ToString();

            return getThreeRecentPaystubsActual;
        }

        [AllureStep("GetRequiredDocumentsPhotoIdAddApartmentsPage")]
        public string GetRequiredDocumentsPhotoIdAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemPhotoIdPaystubs);
            string getPhotoId = ItemPhotoIdPaystubs.Text;
            string getPhotoIdActual = getPhotoId.ToString();

            return getPhotoIdActual;
        }

        [AllureStep("GetRequiredDocumentsTwoMostRecentBankStatementsAddApartmentsPage")]
        public string GetRequiredDocumentsTwoMostRecentBankStatementsAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemTwoMostRecentBankStatements);
            string getTwoMostRecentBankStatements = ItemTwoMostRecentBankStatements.Text;
            string getTwoMostRecentBankStatementsActual = getTwoMostRecentBankStatements.ToString();

            return getTwoMostRecentBankStatementsActual;
        }

        [AllureStep("GetRequiredDocumentsMostRecentWTwoOrOneZeroNineNineAddApartmentsPage")]
        public string GetRequiredDocumentsMostRecentWTwoOrOneZeroNineNineAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemrMostRecentWTwoOrOneZeroNineNine);
            string getMostRecentWTwoOrOneZeroNineNine = ItemrMostRecentWTwoOrOneZeroNineNine.Text;
            string getMostRecentWTwoOrOneZeroNineNineActual = getMostRecentWTwoOrOneZeroNineNine.ToString();

            return getMostRecentWTwoOrOneZeroNineNineActual;
        }

        [AllureStep("VerifyRequiredDocumentsByDefaultAddApartmentsPage")]
        public AddApartments VerifyRequiredDocumentsByDefaultAddApartmentsPage(string getThreeRecentPaystubsActual, string getPhotoIdActual, string getTwoMostRecentBankStatementsActual, string getMostRecentWTwoOrOneZeroNineNineActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getThreeRecentPaystubsActual, TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_THREE_RECENT_PAYSTUBS);
                Assert.AreEqual(getPhotoIdActual, TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_PHOTO_ID);
                Assert.AreEqual(getTwoMostRecentBankStatementsActual, TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_TWO_MOST_RECENT_BANK_STATEMENTS);
                Assert.AreEqual(getMostRecentWTwoOrOneZeroNineNineActual, TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_MOST_W_TWO_OR_ONE_ZERO_NINE_NINE);

                Console.WriteLine($"Three Recent Paystubs AR: {getThreeRecentPaystubsActual} = {TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_THREE_RECENT_PAYSTUBS} :ER Three Recent Paystubs");
                Console.WriteLine($"Photo Id AR: {getPhotoIdActual} = {TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_PHOTO_ID} :ER Photo Id");
                Console.WriteLine($"Two Most Recent Bank Statements AR: {getTwoMostRecentBankStatementsActual} = {TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_TWO_MOST_RECENT_BANK_STATEMENTS} :ER Two Most Recent Bank Statements");
                Console.WriteLine($"Most Recent W Two Or One Zero Nine Nine AR: {getMostRecentWTwoOrOneZeroNineNineActual} = {TestDataForWebSiteAdmin.DEFAULT_REQUIRED_DOCUMENT_MOST_W_TWO_OR_ONE_ZERO_NINE_NINE} :ER Most Recent W Two Or One Zero Nine Nine");
            });

            return this;
        }

        #endregion
    }
}
