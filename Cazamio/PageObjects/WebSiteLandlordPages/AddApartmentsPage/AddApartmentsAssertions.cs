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
            WaitUntil.WaitSomeInterval(500);
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
            WaitUntil.WaitSomeInterval(3000);
            Assert.AreEqual(getBuildingNameAddApartmentsPage, TestDataForWebSiteAdmin.BUILDING_NAME_NEW_BUILDING);

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

            Console.WriteLine($"AR: {getMonthlyRentsPrePayment} = {TestDataForWebSiteAdmin.DEFAULT_MONTHLY_RENTS_PREPAYMENT} :ER");

            return this;
        }
    }
}
