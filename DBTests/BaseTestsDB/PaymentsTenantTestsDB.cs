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

    public class PaymentsTenantTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentTenant")]
        [AllureSubSuite("PaymentCreditScreeningFeeForBuildingWithCommission")]

        public void PaymentCreditScreeningFeeForBuildingWithCommission()
        {
            #region Preconditions

            string buildingAddress = "123 Linden Boulevard";
            string marketplaceId = "15";

            #endregion

            //Step 8 Pay Application fee
            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentCreditScreeningFeeForBuildingWithCommission(buildingAddress, marketplaceId);
            Console.WriteLine($"Credit Screening Fee Building: {payment.CreditScreeningFeeBuilding} $");
            Console.WriteLine($"Commission Fee Building: {payment.CommissionScreeningFeeBuilding} %");
            Console.WriteLine($"Total: {payment.Total} $");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentTenant")]
        [AllureSubSuite("PaymentHoldingDepositForApartmentWithCommission")]

        public void PaymentHoldingDepositForApartmentWithCommission()
        {
            #region Preconditions

            string buildingAddress = "123 Linden Boulevard";
            string unitNumber = "49";
            string marketplaceId = "15";

            #endregion

            //Step 9 Rental option payment
            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentHoldingDepositForApartmentWithCommission(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Application Deposit: $ {payment.HoldingDepositWithoutCommission}");
            Console.WriteLine($"Commission Fee: % {payment.CommissionForHoldingDeposit}");
            Console.WriteLine($"Total: $ {payment.HoldingDepositWithCommission}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentTenant")]
        [AllureSubSuite("PaymentForApartmentWithoutOwnerTenantPayCommissionsAndHoldingDeposit")]

        #region Preconditions

        // For Tenant (Lease Price * PaidMonyhs) + DepositPrice)
        // Displayed at a tenant-applicant (without adding a tenant-occupant) in the modal window "Payment details" when payment for signing a lease.
        // Can testing when had been set "OwnerPay".

        #endregion

        public void PaymentForApartmentWithoutOwnerTenantPayCommissionsAndHoldingDeposit()
        {
            #region Preconditions

            string buildingAddress = "101 Franklin Avenue";
            string unitNumber = "131";
            string marketplaceId = "15";

            #endregion

            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithoutOwnerTenantPayCommissionsAndHoldingDeposit(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Payment of apartment: $ {payment.PaymentOfApartment}");
            Console.WriteLine($"Lease Price: $ {payment.LeasePrice}");
            Console.WriteLine($"Paid Months (Month's rent): {payment.PaidMonths}");
            Console.WriteLine($"Deposit Price (Security deposit): $ {payment.DepositPrice}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentTenant")]
        [AllureSubSuite("PaymentForApartmentWithoutOwnerTenantPayCommissionsWithHoldingDeposit")]

        #region Preconditions

        // For Tenant (Lease Price * PaidMonyhs) + DepositPrice - holding deposit)
        // Displayed at a tenant-applicant (without adding a tenant-occupant) in the modal window "Payment details" when payment for signing a lease.
        // Can testing when had been set "OwnerPay".

        #endregion

        public void PaymentForApartmentWithoutOwnerTenantPayCommissionsWithHoldingDeposit()
        {
            #region Preconditions

            string buildingAddress = "101 Franklin Avenue";
            string unitNumber = "122";
            string marketplaceId = "15";

            #endregion

            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithoutOwnerTenantPayCommissionsWithHoldingDeposit(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Payment of apartment: {payment.PaymentOfApartment}");
            Console.WriteLine($"Lease Price: {payment.LeasePrice}");
            Console.WriteLine($"Paid Months (Month's rent): {payment.PaidMonths}");
            Console.WriteLine($"Deposit Price (Security deposit): {payment.DepositPrice}");
            Console.WriteLine($"Amount (Holding deposit): {payment.Amount}");
        }


        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentTenant")]
        [AllureSubSuite("PaymentSignLeaseForApartmentWithOwnerAndTenantPayAndHoldingDepositWithCommission")]

        #region Preconditions

        // For Tenant (Lease Price * PaidMonyhs) + DepositPrice + (TenantNumberOfMonths * LeasePrice) - holding deposit)
        // For Landlord (Lease Price * PaidMonyhs) + DepositPrice + (TenantNumberOfMonths * LeasePrice * TenantPercentage) - holding deposit)
        // Displayed at a tenant-applicant (without adding a tenant-occupant) in the modal window "Payment details" when payment for signing a lease.
        // Can testing when had been set "TenantPay".

        #endregion

        public void PaymentSignLeaseForApartmentWithOwnerAndTenantPayAndHoldingDepositWithCommission()
        {
            #region Preconditions

            string buildingAddress = "123 Linden Boulevard";
            string unitNumber = "51";
            string marketplaceId = "15";

            #endregion

            var paymentA = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithoutOwnerTenantPayCommissionsWithHoldingDeposit(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Move-in proce: $ {paymentA.PaymentOfApartment}");
            Console.WriteLine($"Deposit Price (Security deposit): $ {paymentA.DepositPrice}");
            Console.WriteLine($"Lease Price: $ {paymentA.LeasePrice}");
            Console.WriteLine($"Paid Months (Month's rent): {paymentA.PaidMonths}");
            Console.WriteLine($"Holding deposit: $ {paymentA.Amount}");

            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithOwnerAndTenantPayTakeOffWithHoldingDepositWithoutCommission(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Applicant subtotal: $ {payment.FullPaymentOfApartment}");
            Console.WriteLine($"Broker fee: $ {payment.BrokerFee}");
            Console.WriteLine($"Pay Type: {payment.PayType}");
            Console.WriteLine($"Tenant Number Of Months: {payment.TenantNumberOfMonths}");
            Console.WriteLine($"Tenant percentage: {payment.TenantPercentage}");

            var paymentB = DBRequestCalculationsTenants.CalculationsTenant.GetSignLeaseWithCommission(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Total: $ {paymentB.Total}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentTenant")]
        [AllureSubSuite("PaymentSignLeaseForApartmentWithTenantPayAndHoldingDepositWithCommission")]

        #region Preconditions

        // For Tenant (Lease Price * PaidMonyhs) + DepositPrice + (TenantNumberOfMonths * LeasePrice) - holding deposit)
        // For Landlord (Lease Price * PaidMonyhs) + DepositPrice + (TenantNumberOfMonths * LeasePrice) - holding deposit)
        // Displayed at a tenant-applicant (without adding a tenant-occupant) in the modal window "Payment details" when payment for signing a lease.
        // Can testing when had been set "TenantPay".

        #endregion

        public void PaymentSignLeaseForApartmentWithTenantPayAndHoldingDepositWithCommission()
        {
            #region Preconditions

            string buildingAddress = "123 Linden Boulevard";
            string unitNumber = "53";
            string marketplaceId = "15";

            #endregion

            var paymentA = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithoutOwnerTenantPayCommissionsWithHoldingDeposit(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Move-in proce: $ {paymentA.PaymentOfApartment}");
            Console.WriteLine($"Deposit Price (Security deposit): $ {paymentA.DepositPrice}");
            Console.WriteLine($"Lease Price: $ {paymentA.LeasePrice}");
            Console.WriteLine($"Paid Months (Month's rent): {paymentA.PaidMonths}");
            Console.WriteLine($"Holding deposit: $ {paymentA.Amount}");

            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithTenantPayTakeOffWithHoldingDepositWithoutCommission(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Applicant subtotal: $ {payment.FullPaymentOfApartment}");
            Console.WriteLine($"Broker fee: $ {payment.BrokerFee}");
            Console.WriteLine($"Pay Type: {payment.PayType}");
            Console.WriteLine($"Tenant Number Of Months: {payment.TenantNumberOfMonths}");

            var paymentB = DBRequestCalculationsTenants.CalculationsTenant.GetSignLeaseWithCommission(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Total: $ {paymentB.Total}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPaymentTenant")]
        [AllureSubSuite("TenantPaySignLeaseOnlyTenantApplicantWithoutCommissions")]

        #region Preconditions

        // For Tenant (Lease Price * PaidMonyhs) + DepositPrice + (TenantNumberOfMonths * LeasePrice) - holding deposit)
        // For Landlord (Lease Price * PaidMonyhs) + DepositPrice + (TenantNumberOfMonths * LeasePrice * TakeOff) - holding deposit)
        // Displayed at a tenant-applicant (without adding a tenant-occupant) in the modal window "Payment details" when payment for signing a lease.
        // Can testing when had been set "TenantPay".

        #endregion

        public void TenantPaySignLeaseOnlyTenantApplicantWithoutCommissions()
        {
            #region Preconditions

            string buildingAddress = "101 Franklin Avenue";
            string unitNumber = "26";
            string marketplaceId = "15";

            #endregion

            var paymentA = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithoutOwnerTenantPayCommissionsWithHoldingDeposit(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Move-in price: {paymentA.PaymentOfApartment}");
            Console.WriteLine($"Lease Price: {paymentA.LeasePrice}");
            Console.WriteLine($"Paid Months (Month's rent): {paymentA.PaidMonths}");
            Console.WriteLine($"Deposit Price (Security deposit): {paymentA.DepositPrice}");
            Console.WriteLine($"Amount (Holding deposit): {paymentA.Amount}");

            var payment = DBRequestCalculationsTenants.CalculationsTenant.GetPaymentForApartmentWithOwnerAndTenantPayTakeOffWithHoldingDepositWithoutCommission(buildingAddress, unitNumber, marketplaceId);
            Console.WriteLine($"Applicant subtotal: {payment.FullPaymentOfApartment}");
            Console.WriteLine($"Pay Type: {payment.PayType}");
            Console.WriteLine($"Tenant Number Of Months: {payment.TenantNumberOfMonths}");
            Console.WriteLine($"Take Off: {payment.TakeOff}");
            Console.WriteLine($"Broker Fee: {payment.BrokerFee}");
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
