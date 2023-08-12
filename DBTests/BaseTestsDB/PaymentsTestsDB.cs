using Allure.Commons;
using ApiTests.Base;
using CazamioProgect.Helpers;
using CazamioProject.DBHelpers;
using CazamioProject.Helpers;
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

    public class PaymentsTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("PaymentForApartmentWithoutCommissionsAndHoldingDeposit")]

        #region Preconditions

        // (Lease Price * PaidMonyhs) + DepositPrice)

        #endregion

        public void PaymentForApartmentWithoutCommissionsAndHoldingDeposit()
        {
            var payment = DBCalculationsCheckings.Calculations.GetPaymentForApartmentWithoutCommissionsAndHoldingDeposit(DBTestDataDBForAdmins.BUILDING_ADDRESS, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($" Payment of apartment: {payment.PaymentOfApartment}");
            Console.WriteLine($" Lease Price: {payment.LeasePrice}");
            Console.WriteLine($" Paid Months (Month's rent): {payment.PaidMonths}");
            Console.WriteLine($" Deposit Price (Security deposit): {payment.DepositPrice}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("PaymentForApartmentWithoutCommissionsWithHoldingDeposit")]

        #region Preconditions

        // (Lease Price * PaidMonyhs) + DepositPrice - holding deposit)

        #endregion

        public void PaymentForApartmentWithoutCommissionsWithHoldingDeposit()
        {
            string buildingAddress = "101 Franklin Avenue";
            string unitNumber = "26";

            var payment = DBCalculationsCheckings.Calculations.GetPaymentForApartmentWithoutCommissionsWithHoldingDeposit(buildingAddress, unitNumber);
            Console.WriteLine($" Payment of apartment: {payment.PaymentOfApartment}");
            Console.WriteLine($" Lease Price: {payment.LeasePrice}");
            Console.WriteLine($" Paid Months (Month's rent): {payment.PaidMonths}");
            Console.WriteLine($" Deposit Price (Security deposit): {payment.DepositPrice}");
            Console.WriteLine($" Amount (Holding deposit): {payment.Amount}");
        }


        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("PaymentForApartmentWithoutCommissionsWithHoldingDeposit")]

        public void PaymentForApartmentWithCommissionsAndHoldingDeposit()
        {

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("RecordsAboutNewPaymentHoldDeposit")]

        public void RecordsAboutNewPaymentHoldDeposit()
        {
            string lastId = DBTableTransactions.GetLastId();
            Console.WriteLine($"{lastId} :Id last from table Transactions");

            string lastIdByTenantId = DBTableTransactions.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastIdByTenantId} :Id last by TenantId from table Transactions");

            string apartmentIdByBuildingIdUnit = DBRequestApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{apartmentIdByBuildingIdUnit} :ApartmentId by BuildingId Unit from Apartments");

            string lastTenantIdByIdTransactionType = DBTableTransactions.GetLastTenantIdByIdTransactionType(DBTestDataPayments.TRANSACTION_TYPE_TENANT_HOLDING_DEPOSIT);
            Console.WriteLine($"{lastTenantIdByIdTransactionType} :TenantId last by TransactionId TransactionType from table Transactions");

            string tenantIdByEmail = DBTableAspNetUsers.GetIdByEmailMarketplaceId(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId by Email from table AspNetUsers");

            string lastTransactionId = DBTableTransactions.GetLastTransactionId();
            Console.WriteLine($"{lastTransactionId} :TransactionId from table Transactions");

            string lastTransactionIdByTenantId = DBTableTransactions.GetLastTransactionIdByTenantIdApartmentId(tenantIdByEmail, apartmentIdByBuildingIdUnit);
            Console.WriteLine($"{lastTransactionId} :TransactionId by TenantId ApartmentId from table Transactions");

            string lastApartmentId = DBTableTransactions.GetLastApartmentId();
            Console.WriteLine($"{lastApartmentId} :ApartmentId table Transactions");

            string lastApartmentIdByTenantId = DBTableTransactions.GetLastApartmentIdByTenantIdApartmentId(tenantIdByEmail, apartmentIdByBuildingIdUnit);
            Console.WriteLine($"{lastApartmentIdByTenantId} :ApartmentId by TenantId ApartmentId table Transactions");

            string transactionStatusComplete = DBTableTransactions.GetLastTransactionStatusdByIdApartmentIdTransactionType(apartmentIdByBuildingIdUnit, DBTestDataPayments.TRANSACTION_TYPE_TENANT_HOLDING_DEPOSIT);
            Console.WriteLine($"{transactionStatusComplete} :TransactionStatus complete by ApartmentId TransactionType table Transactions");

            string transactionTypeHoldingDepositPayment = DBTableTransactions.GetLastTransactionTypeByIdApartmentId(apartmentIdByBuildingIdUnit);
            Console.WriteLine($"{transactionTypeHoldingDepositPayment} :TransactionType by ApartmentId table Transactions");

            Assert.Multiple(() =>
           {
               Assert.AreEqual(lastId, lastIdByTenantId);
               Console.WriteLine($"TransactionId for HoldDeposit from Tarnsactions {lastId} = {lastIdByTenantId} TransactionId by TenantId for HoldDeposit from Tarnsactions");

               Assert.AreEqual(lastTenantIdByIdTransactionType, tenantIdByEmail);
               Console.WriteLine($"TenantId last by TransactionId TransactionType from table Transactions {lastTenantIdByIdTransactionType} = {tenantIdByEmail} TenantId by Email from table AspNetUsers");

               Assert.AreEqual(lastTransactionId, lastTransactionIdByTenantId);
               Console.WriteLine($"TransactionId from table Transactions {lastTransactionId} = {lastTransactionIdByTenantId} TransactionId by TenantId from table AspNetUsers");

               Assert.AreEqual(lastApartmentIdByTenantId, apartmentIdByBuildingIdUnit);
               Console.WriteLine($"ApartmentId table Transactions {lastApartmentIdByTenantId} = {apartmentIdByBuildingIdUnit} ApartmentId by BuildingId Unit from Apartments");

               Assert.AreEqual(transactionStatusComplete, DBTestDataPayments.TRANSACTION_STATUS_COMPLETED);
               Console.WriteLine($"TransactionStatus complete by ApartmentId TransactionType from table Transactions {transactionStatusComplete} = {DBTestDataPayments.TRANSACTION_STATUS_COMPLETED} TransactionStatus ER");

               Assert.AreEqual(transactionTypeHoldingDepositPayment, DBTestDataPayments.TRANSACTION_TYPE_TENANT_HOLDING_DEPOSIT);
               Console.WriteLine($"TransactionType complete by ApartmentId from table Transactions {transactionTypeHoldingDepositPayment} = {DBTestDataPayments.TRANSACTION_TYPE_TENANT_HOLDING_DEPOSIT} TransactionType ER");
           });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("RecordsAboutNewPaymentCreditScreeningFee")]

        public void RecordsAboutNewPaymentCreditScreeningFeeApplicant()
        {
            string userIdTenant = DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID;
            string buildingId = DBTestDataDBForAdmins.BUILDING_ID;
            string unitNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string apartmentApplicationId = DBTableApartmentApplications.GetApartmentApplicationIdByTenantIdApartmentid(userIdTenant, buildingId, unitNumber);
            Console.WriteLine($"{apartmentApplicationId} :ApartmentApplicationId by TenantId BuildingId UnitNumber for application from table ApartmentApplications");

            string lastId = DBTableTransactions.GetLastId();
            Console.WriteLine($"{lastId} :Id last from table Transactions");

            string lastIdByTenantId = DBTableTransactions.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastIdByTenantId} :Id last by TenantId from table Transactions");

            string apartmentIdByBuildingIdUnit = DBRequestApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{apartmentIdByBuildingIdUnit} :ApartmentId by BuildingId Unit from Apartments");

            string lastTenantIdByIdTransactionType = DBTableTransactions.GetLastTenantIdByIdTransactionType(DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION);
            Console.WriteLine($"{lastTenantIdByIdTransactionType} :TenantId last by TransactionId TransactionType from table Transactions");

            string tenantIdByEmail = DBTableAspNetUsers.GetIdByEmailMarketplaceId(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId by Email from table AspNetUsers");

            string lastTransactionId = DBTableTransactions.GetLastTransactionId();
            Console.WriteLine($"{lastTransactionId} :TransactionId from table Transactions");

            string lastApartmentApplicationId = DBTableTransactions.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :ApartmentApplicationId last table Transactions");

            string lastTransactionIdByTenantId = DBTableTransactions.GetLastTransactionIdByTenantIdApartmentApplicationId(tenantIdByEmail, apartmentApplicationId);
            Console.WriteLine($"{lastTransactionIdByTenantId} :TransactionId by TenantId ApartmentId from table Transactions");

            string lastApartmentApplicationIdByTenantId = DBTableTransactions.GetLastApartmentApplicationIdByTenantIdTransactionType(tenantIdByEmail, DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION);
            Console.WriteLine($"{lastApartmentApplicationIdByTenantId} :ApartmentId by TenantId ApartmentId table Transactions");

            string transactionStatusComplete = DBTableTransactions.GetLastTransactionStatusByIdApartmentApplicationIdTransactionType(lastApartmentApplicationId, DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION);
            Console.WriteLine($"{transactionStatusComplete} :TransactionStatus complete by ApartmentId TransactionType table Transactions");

            string transactionTypeTenantApplication = DBTableTransactions.GetLastTransactionTypeByIdApartmentApplicationId(apartmentApplicationId);
            Console.WriteLine($"{transactionTypeTenantApplication} :TransactionType by ApartmentApplicationId table Transactions");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastId, lastIdByTenantId);
                Console.WriteLine($"TransactionId for HoldDeposit from Tarnsactions {lastId} = {lastIdByTenantId} TransactionId by TenantId for HoldDeposit from Tarnsactions");

                Assert.AreEqual(lastTenantIdByIdTransactionType, tenantIdByEmail);
                Console.WriteLine($"TenantId last by TransactionId TransactionType from table Transactions {lastTenantIdByIdTransactionType} = {tenantIdByEmail} TenantId by Email from table AspNetUsers");

                Assert.AreEqual(lastTransactionId, lastTransactionIdByTenantId);
                Console.WriteLine($"TransactionId from table Transactions {lastTransactionId} = {lastTransactionIdByTenantId} TransactionId by TenantId from table AspNetUsers");

                Assert.AreEqual(lastApartmentApplicationId, lastApartmentApplicationIdByTenantId);
                Console.WriteLine($"ApartmentApplicationId last by TenantId table Transactions {lastApartmentApplicationId} = {lastApartmentApplicationIdByTenantId} ApartmentApplicationId by TenantId TransactionType from Transactions");

                Assert.AreEqual(transactionStatusComplete, DBTestDataPayments.TRANSACTION_STATUS_COMPLETED);
                Console.WriteLine($"TransactionStatus complete by ApartmentId TransactionType from table Transactions {transactionStatusComplete} = {DBTestDataPayments.TRANSACTION_STATUS_COMPLETED} TransactionStatus ER");

                Assert.AreEqual(transactionTypeTenantApplication, DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION);
                Console.WriteLine($"TransactionType complete by ApartmentApplicationId from table Transactions {transactionTypeTenantApplication} = {DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION} TransactionType ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("RecordsAboutNewPaymentSignLeaseApplicant")]

        public void RecordsAboutNewPaymentSignLeaseApplicant()
        {
            string userIdTenant = DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID;
            string buildingId = DBTestDataDBForAdmins.BUILDING_ID;
            string unitNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string apartmentApplicationId = DBTableApartmentApplications.GetApartmentApplicationIdByTenantIdApartmentid(userIdTenant, buildingId, unitNumber);
            Console.WriteLine($"{apartmentApplicationId} :ApartmentApplicationId by TenantId BuildingId UnitNumber for application from table ApartmentApplications");

            string lastId = DBTableTransactions.GetLastId();
            Console.WriteLine($"{lastId} :Id last from table Transactions");

            string lastIdByTenantId = DBTableTransactions.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastIdByTenantId} :Id last by TenantId from table Transactions");

            string apartmentIdByBuildingIdUnit = DBRequestApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{apartmentIdByBuildingIdUnit} :ApartmentId by BuildingId Unit from Apartments");

            string lastTenantIdByIdTransactionType = DBTableTransactions.GetLastTenantIdByIdTransactionType(DBTestDataPayments.TRANSACTION_TYPE_TENANT_SINGING_LEASE);
            Console.WriteLine($"{lastTenantIdByIdTransactionType} :TenantId last by TransactionId TransactionType from table Transactions");

            string tenantIdByEmail = DBTableAspNetUsers.GetIdByEmailMarketplaceId(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId by Email from table AspNetUsers");

            string lastTransactionId = DBTableTransactions.GetLastTransactionId();
            Console.WriteLine($"{lastTransactionId} :TransactionId from table Transactions");

            string lastApartmentApplicationId = DBTableTransactions.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :ApartmentApplicationId last table Transactions");

            string lastTransactionIdByTenantId = DBTableTransactions.GetLastTransactionIdByTenantIdApartmentApplicationId(tenantIdByEmail, apartmentApplicationId);
            Console.WriteLine($"{lastTransactionIdByTenantId} :TransactionId by TenantId ApartmentId from table Transactions");

            string lastApartmentApplicationIdByTenantId = DBTableTransactions.GetLastApartmentApplicationIdByTenantIdTransactionType(tenantIdByEmail, DBTestDataPayments.TRANSACTION_TYPE_TENANT_SINGING_LEASE);
            Console.WriteLine($"{lastApartmentApplicationIdByTenantId} :ApartmentId by TenantId ApartmentId table Transactions");

            string transactionStatusComplete = DBTableTransactions.GetLastTransactionStatusByIdApartmentApplicationIdTransactionType(lastApartmentApplicationId, DBTestDataPayments.TRANSACTION_TYPE_TENANT_SINGING_LEASE);
            Console.WriteLine($"{transactionStatusComplete} :TransactionStatus complete by ApartmentId TransactionType table Transactions");

            string transactionTypeSigningLease = DBTableTransactions.GetLastTransactionTypeByIdApartmentApplicationId(apartmentApplicationId);
            Console.WriteLine($"{transactionTypeSigningLease} :TransactionType by ApartmentApplicationId table Transactions");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastId, lastIdByTenantId);
                Console.WriteLine($"TransactionId for HoldDeposit from Tarnsactions {lastId} = {lastIdByTenantId} TransactionId by TenantId for HoldDeposit from Tarnsactions");

                Assert.AreEqual(lastTenantIdByIdTransactionType, tenantIdByEmail);
                Console.WriteLine($"TenantId last by TransactionId TransactionType from table Transactions {lastTenantIdByIdTransactionType} = {tenantIdByEmail} TenantId by Email from table AspNetUsers");

                Assert.AreEqual(lastTransactionId, lastTransactionIdByTenantId);
                Console.WriteLine($"TransactionId from table Transactions {lastTransactionId} = {lastTransactionIdByTenantId} TransactionId by TenantId from table AspNetUsers");

                Assert.AreEqual(lastApartmentApplicationId, lastApartmentApplicationIdByTenantId);
                Console.WriteLine($"ApartmentApplicationId last by TenantId table Transactions {lastApartmentApplicationId} = {lastApartmentApplicationIdByTenantId} ApartmentApplicationId by TenantId TransactionType from Transactions");

                Assert.AreEqual(transactionStatusComplete, DBTestDataPayments.TRANSACTION_STATUS_COMPLETED);
                Console.WriteLine($"TransactionStatus complete by ApartmentId TransactionType from table Transactions {transactionStatusComplete} = {DBTestDataPayments.TRANSACTION_STATUS_COMPLETED} TransactionStatus ER");

                Assert.AreEqual(transactionTypeSigningLease, DBTestDataPayments.TRANSACTION_TYPE_TENANT_SINGING_LEASE);
                Console.WriteLine($"TransactionType complete by ApartmentApplicationId from table Transactions {transactionTypeSigningLease} = {DBTestDataPayments.TRANSACTION_TYPE_TENANT_SINGING_LEASE} TransactionType ER");
            });
        }
    }
}
