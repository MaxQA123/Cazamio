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
        [AllureSubSuite("DisplayingOwnerNameCompanyNameForApartment")]

        public void DisplayingOwnerNameCompanyNameForApartment()
        {
            #region Preconditions

            string buildingAddress = "123 Linden Boulevard";
            string unitNumber = "53";
            string marketplaceId = "15";

            #endregion

            var name = DBRequestApartments.Apartments.GetOwnerNameCompanyNameForApartment(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Owner name for apartment: {name.OwnerName}");
            Console.WriteLine($"Company name for apartment: {name.CompanyName}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentAdmins")]
        [AllureSubSuite("ForApartmentTenantPayCommissionStructure")]

        #region Preconditions

        // Available Commission = (TenantNumberOfMonths * LeasePrice) - TakeOff
        // Take off = (TenantNumberOfMonths * LeasePrice) - Available Commission

        #endregion

        public void ForApartmentTenantPayCommissionStructure()
        {
            #region Preconditions

            string buildingAddress = "123 Linden Boulevard";
            string unitNumber = "36";
            string marketplaceId = "15";

            #endregion

            var payment = DBRequestApartments.Apartments.GetPayTypeTenantNumberOfMonhsTakeOffAvailableCommission(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Pay Type: {payment.PayType}");
            Console.WriteLine($"Tenant number of months: {payment.TenantNumberOfMonths}");
            Console.WriteLine($"Take off: $ {payment.TakeOff}");
            Console.WriteLine($"Available for Commission: $ {payment.AvailableForCommission}");
        }
    }
}
