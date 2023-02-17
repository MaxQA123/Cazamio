using Allure.Commons;
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

namespace CazamioProject.BaseTestsDBPayments
{
    [TestFixture]
    [AllureNUnit]

    public class PaymentsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("RecordsAboutNewPaymentHoldDeposit")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The tables "Transactions", "AspNetUsers.
        //Path to cheking's: 
        public void RecordsAboutNewPaymentHoldDeposit()
        {
            string lastId = DBTableTransactions.GetLastId();
            Console.WriteLine($"{lastId} :Id last from table Transactions");

            string lastIdByTenantId = DBTableTransactions.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastIdByTenantId} :Id last by TenantId from table Transactions");

            string apartmentIdByBuildingIdUnit = DBTableApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{apartmentIdByBuildingIdUnit} :ApartmentId by BuildingId Unit from Apartments");

            string lastTenantIdByIdTransactionType = DBTableTransactions.GetLastTenantIdByIdTransactionType(DBTestDataPayments.TRANSACTION_TYPE_TENANT_HOLDING_DEPOSIT);
            Console.WriteLine($"{lastTenantIdByIdTransactionType} :TenantId last by TransactionId TransactionType from table Transactions");

            string tenantIdByEmail = DBTableAspNetUsers.GetIdByEmailMarketplaceIdForTenant(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
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
           });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("RecordsAboutNewPaymentCreditScreeningFee")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The tables "Transactions", "AspNetUsers.
        //Path to cheking's: 
        public void RecordsAboutNewPaymentCreditScreeningFee()
        {
            string userIdTenant = DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID;
            string buildingId = DBTestDataDBForAdmins.BUILDING_ID;
            string unitNumber = DBTestDataDBForAdmins.UNIT_NUMBER;

            string ApartmentApplicationId = DBTableApartmentApplications.GetApartmentApplicationIdByTenantIdApartmentid(userIdTenant, buildingId, unitNumber);
            Console.WriteLine($"{ApartmentApplicationId} :ApartmentApplicationId by TenantId BuildingId UnitNumber for application from table ApartmentApplications");

            string lastId = DBTableTransactions.GetLastId();
            Console.WriteLine($"{lastId} :Id last from table Transactions");

            string lastIdByTenantId = DBTableTransactions.GetLastIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastIdByTenantId} :Id last by TenantId from table Transactions");

            string apartmentIdByBuildingIdUnit = DBTableApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{apartmentIdByBuildingIdUnit} :ApartmentId by BuildingId Unit from Apartments");

            string lastTenantIdByIdTransactionType = DBTableTransactions.GetLastTenantIdByIdTransactionType(DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION);
            Console.WriteLine($"{lastTenantIdByIdTransactionType} :TenantId last by TransactionId TransactionType from table Transactions");

            string tenantIdByEmail = DBTableAspNetUsers.GetIdByEmailMarketplaceIdForTenant(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
            Console.WriteLine($"{tenantIdByEmail} :TenantId by Email from table AspNetUsers");

            string lastTransactionId = DBTableTransactions.GetLastTransactionId();
            Console.WriteLine($"{lastTransactionId} :TransactionId from table Transactions");

            string lastApartmentApplicationId = DBTableTransactions.GetLastApartmentApplicationId();
            Console.WriteLine($"{lastApartmentApplicationId} :ApartmentApplicationId last table Transactions");

            string lastTransactionIdByTenantId = DBTableTransactions.GetLastTransactionIdByTenantIdApartmentApplicationId(tenantIdByEmail, ApartmentApplicationId);
            Console.WriteLine($"{lastTransactionIdByTenantId} :TransactionId by TenantId ApartmentId from table Transactions");

            string lastApartmentApplicationIdByTenantId = DBTableTransactions.GetLastApartmentApplicationIdByTenantIdTransactionType(tenantIdByEmail, DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION);
            Console.WriteLine($"{lastApartmentApplicationIdByTenantId} :ApartmentId by TenantId ApartmentId table Transactions");

            string transactionStatusComplete = DBTableTransactions.GetLastTransactionStatusdByIdApartmentApplicationIdTransactionType(lastApartmentApplicationId, DBTestDataPayments.TRANSACTION_TYPE_TENANT_APPLICATION);
            Console.WriteLine($"{transactionStatusComplete} :TransactionStatus complete by ApartmentId TransactionType table Transactions");

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
            });
        }
    }
}
