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
            WaitUntil.CustomElementIsVisible(TitleAddApartmentsPage, 10);
            Assert.IsTrue(Successfully.IsVisible(TitleAddApartmentsPage));

            return this;
        }

        [AllureStep("GetBuildingNameAddApartmentsPage")]
        public string GetBuildingNameAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ButtonBuildingNameAddApartmentsUnitsPage, 10);
            string getBuildingName = ButtonBuildingNameAddApartmentsUnitsPage.Text;
            string getBuildingNameActual = getBuildingName.ToString();

            return getBuildingNameActual;
        }

        [AllureStep("VerifyBuildingNameAddApartmentsPage")]
        public AddApartments VerifyBuildingNameAddApartmentsPage(string getBuildingNameAddApartmentsPage)
        {
            WaitUntil.WaitSomeInterval(5000);
            Assert.AreEqual(getBuildingNameAddApartmentsPage, building.BuildingName);

            return this;
        }

        [AllureStep("GetLeasePriceAddApartmentsPage")]
        public string GetLeasePriceAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLeasePriceAddAprtmntsUnitsPage, 10);
            string getLeasePrice = FieldInputLeasePriceAddAprtmntsUnitsPage.GetAttribute("value");
            string getLeasePriceActual = getLeasePrice.ToString();

            return getLeasePriceActual;
        }

        [AllureStep("GetSecurityDepositAddApartmentsPage")]
        public string GetSecurityDepositAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputSecurityDepositAddAprtmntsUnitsPage, 10);
            string getSecurityDeposit = FieldInputSecurityDepositAddAprtmntsUnitsPage.GetAttribute("value");
            string getSecurityDepositActual = getSecurityDeposit.ToString();

            return getSecurityDepositActual;
        }

        [AllureStep("VerifySecurityDepositAddApartmentsPage")]
        public AddApartments VerifySecurityDepositAddApartmentsPage(string getLeasePrice, string getSecurityDeposit)
        {
            Assert.AreEqual(getLeasePrice, getSecurityDeposit);

            Console.WriteLine($"Lease Price = {getLeasePrice} = {getSecurityDeposit} = Security Deposit");

            return this;
        }

        [AllureStep("GetMonthlyRentsPrePaymentAddApartmentsPage")]
        public string GetMonthlyRentsPrePaymentAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMonthlyRentsPrePaymentAddAprtmntsUnitsPage, 10);
            string getMonthlyRentsPrePayment = FieldInputMonthlyRentsPrePaymentAddAprtmntsUnitsPage.GetAttribute("value");
            string getMonthlyRentsPrePaymentActual = getMonthlyRentsPrePayment.ToString();

            return getMonthlyRentsPrePaymentActual;
        }

        [AllureStep("VerifyMonthlyRentsPrePaymentAddApartmentsPage")]
        public AddApartments VerifyMonthlyRentsPrePaymentAddApartmentsPage(string getMonthlyRentsPrePayment)
        {
            Assert.AreEqual(getMonthlyRentsPrePayment, TestDataForWebSiteAdmin.DEFAULT_MONTHLY_RENTS_PREPAYMENT);

            Console.WriteLine($"MonthlyRentsPrePayment AR: {getMonthlyRentsPrePayment} = {TestDataForWebSiteAdmin.DEFAULT_MONTHLY_RENTS_PREPAYMENT} :ER MonthlyRentsPrePayment");

            return this;
        }

        [AllureStep("GetApartmentTypeAddApartmentsPage")]
        public string GetApartmentTypeAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemApartmentTypeMultiFamilyAddAprtmntsUnitsPage, 10);
            string getApartmentType = ItemApartmentTypeMultiFamilyAddAprtmntsUnitsPage.Text;
            string getApartmentTypeActual = getApartmentType.ToString();

            return getApartmentTypeActual;
        }

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
            WaitUntil.CustomElementIsVisible(FieldInputApartmentHoldDepositAddAprtmntsUnitsPage, 10);
            string getApartmentHoldDeposit = FieldInputApartmentHoldDepositAddAprtmntsUnitsPage.GetAttribute("value");
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
            WaitUntil.CustomElementIsVisible(ItemTwelveMonthsRentalTermsAddAprtmntsUnitsPage, 10);
            string getRentalTerms = ItemTwelveMonthsRentalTermsAddAprtmntsUnitsPage.Text;
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
            WaitUntil.CustomElementIsVisible(ItemThreeRecentPaystubsAddAprtmntsUnitsPage, 10);
            string getThreeRecentPaystubs = ItemThreeRecentPaystubsAddAprtmntsUnitsPage.Text;
            string getThreeRecentPaystubsActual = getThreeRecentPaystubs.ToString();

            return getThreeRecentPaystubsActual;
        }

        [AllureStep("GetRequiredDocumentsPhotoIdAddApartmentsPage")]
        public string GetRequiredDocumentsPhotoIdAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemPhotoIdPaystubsAddAprtmntsUnitsPage, 10);
            string getPhotoId = ItemPhotoIdPaystubsAddAprtmntsUnitsPage.Text;
            string getPhotoIdActual = getPhotoId.ToString();

            return getPhotoIdActual;
        }

        [AllureStep("GetRequiredDocumentsTwoMostRecentBankStatementsAddApartmentsPage")]
        public string GetRequiredDocumentsTwoMostRecentBankStatementsAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemTwoMostRecentBankStatementsAddAprtmntsUnitsPage, 10);
            string getTwoMostRecentBankStatements = ItemTwoMostRecentBankStatementsAddAprtmntsUnitsPage.Text;
            string getTwoMostRecentBankStatementsActual = getTwoMostRecentBankStatements.ToString();

            return getTwoMostRecentBankStatementsActual;
        }

        [AllureStep("GetRequiredDocumentsMostRecentWTwoOrOneZeroNineNineAddApartmentsPage")]
        public string GetRequiredDocumentsMostRecentWTwoOrOneZeroNineNineAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemrMostRecentWTwoOrOneZeroNineNineAddAprtmntsUnitsPage, 10);
            string getMostRecentWTwoOrOneZeroNineNine = ItemrMostRecentWTwoOrOneZeroNineNineAddAprtmntsUnitsPage.Text;
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
