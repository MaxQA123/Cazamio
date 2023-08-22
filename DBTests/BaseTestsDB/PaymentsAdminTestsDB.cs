using Allure.Commons;
using ApiTests.Base;
using CazamioProject.DBHelpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTests.BaseTestsDB
{
    [TestFixture]
    [AllureNUnit]

    public class PaymentsAdminTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentAdmins")]
        [AllureSubSuite("PaymentCreditScreeningFeeForBuildingWithCommission")]

        public void PaymentCreditScreeningFeeForBuildingWithCommission()
        {
            #region Preconditions

            string buildingAddress = "101 Franklin Avenue";
            string marketplaceId = "15";

            #endregion

            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentCreditScreeningFeeForBuildingWithCommission(buildingAddress, marketplaceId);
            Console.WriteLine($"Credit Screening Fee Building: {payment.CreditScreeningFeeBuilding} $");
            Console.WriteLine($"Commission Fee Building: {payment.CommissionScreeningFeeBuilding} %");
            Console.WriteLine($"Total: {payment.Total} $");
        }
    }
}
