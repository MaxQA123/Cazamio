using Allure.Commons;
using ApiTests.Base;
using CazamioProgect.Helpers;
using CazamioProject.DBHelpers;
using CazamioProject.DBHelpers.TableOwnerCommissionsStructure;
using CazamioProject.DBHelpers.TableOwnerManagements;
using CazamioProject.DBHelpers.TableOwnerPhoneNumbers;
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

    public class OwnersTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwners")]
        [AllureSubSuite("RecordsDBAboutNewOwner")]

        #region Basic info about test

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Owners".
        //Path to cheking's: 

        #endregion

        public void RecordsDBAboutNewOwnerCommon()
        {
            #region Preconditions

            string nameOwner = DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME;

            #endregion

            #region Test

            string createdByUserIdViaEmail = DBRequestOwnersOld.GetCreatedByUserIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{createdByUserIdViaEmail} :CreatedByUserId wner via email for owner {nameOwner} from table Owners");

            string createdByUserIdViaId = DBRequestOwnersOld.GetLasCreatedByUserIdById();
            Console.WriteLine($"{createdByUserIdViaId} :CreatedByUserId owner via id for owner {nameOwner} from table Owners");

            string ownerIdViaEmail = DBRequestOwnersOld.GetIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{ownerIdViaEmail} :OwnerId wner via email for owner {nameOwner} from table Owners");

            string lastIdOwner = DBRequestOwnersOld.GetLastIdNewOwner();
            Console.WriteLine($"{lastIdOwner} :OwnerId owner via id for owner {nameOwner} from table Owners");

            string emailOwnerViaId = DBRequestOwnersOld.GetLastOwnerEmailNewOwnerByIdOwners();
            Console.WriteLine($"{emailOwnerViaId} :Email owner via id for owner {nameOwner} from table Owners");

            string ownerNameOwnerViaId = DBRequestOwnersOld.GetOwnerNameNewOwnerByIdOwners();
            Console.WriteLine($"{ownerNameOwnerViaId} :Owner Name owner via id for owner {nameOwner} from table Owners");

            string companyNameOwnerViaId = DBRequestOwnersOld.GetLastCompanyNameNewOwnerByIdOwners();
            Console.WriteLine($"{companyNameOwnerViaId} :Company Name owner via id for owner {nameOwner} from table Owners");

            string marketplaceIdByEmail = DBRequestOwnersOld.GetMarketplaceIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{marketplaceIdByEmail} :MarketplaceId by email owner via id for owner {nameOwner} from table Owners");

            string lastMarketplaceId = DBRequestOwnersOld.GetLastMarketplaceIdOwner();
            Console.WriteLine($"{lastMarketplaceId} :Last MarketplaceId for owner {nameOwner} from table Owners");

            string brokerIdByEmail = DBRequestOwnersOld.GetIdBrokerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{brokerIdByEmail} :BrokerId by email owner for owner {nameOwner} from table Owners");

            //string brokerIdFromTestData = DBRequestOwnersOld.GetIdForBroker(DBTestDataDBForAdmins.BROKER_EMAIL);
            //Console.WriteLine($"{brokerIdFromTestData} :BrokerId for owner {nameOwner} from table AspNetUsers");

            #endregion

            #region Assertions

            Assert.Multiple(() =>
            {
                Assert.AreEqual(createdByUserIdViaEmail, createdByUserIdViaId);
                Console.WriteLine($"CreatedByUserId owner via email for owner from table Owners: {createdByUserIdViaEmail} = {createdByUserIdViaId} CreatedByUserId owner via id for owner from table Owners");

                Assert.AreEqual(ownerIdViaEmail, lastIdOwner);
                Console.WriteLine($"Id owner via email for owner from table Owners: {ownerIdViaEmail} = {lastIdOwner} Id owner via id for owner from table Owners");

                Assert.AreEqual(emailOwnerViaId, DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
                Console.WriteLine($"Email owner via email for owner from table Owners: {emailOwnerViaId} = {DBTestDataDBForAdmins.NEW_OWNER_EMAIL} Email owner via id for owner ER");

                Assert.AreEqual(ownerNameOwnerViaId, DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME);
                Console.WriteLine($"Owner Name owner via email for owner from table Owners: {ownerNameOwnerViaId} = {DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME} Owner Name owner via id for owner ER");

                Assert.AreEqual(companyNameOwnerViaId, DBTestDataDBForAdmins.NEW_COMPANY_NAME_OWNER);
                Console.WriteLine($"Company Owner owner via email for owner from table Owners: {companyNameOwnerViaId} = {DBTestDataDBForAdmins.NEW_COMPANY_NAME_OWNER} LandlordId owner via id for owner ER");

                Assert.AreEqual(marketplaceIdByEmail, lastMarketplaceId);
                Console.WriteLine($"MarketplaceId for owner via email from table Owners: {marketplaceIdByEmail} = {lastMarketplaceId} Last MarketplaceId for owner via id from table Owners");

                //Assert.AreEqual(brokerIdByEmail, brokerIdFromTestData);
                //Console.WriteLine($"BrokerId by email owner: {brokerIdByEmail} = {brokerIdFromTestData} BrokerId for owner from table AspNetUsers");
            });

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwners")]
        [AllureSubSuite("RecordsDBAboutNewOwner")]

        #region Basic info about test

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Owners".
        //Path to cheking's: 

        #endregion

        public void RecordsDBAboutNewOwnerMySpace()
        {
            #region Preconditions

            string nameOwner = DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME;

            #endregion

            #region Test

            string createdByUserIdViaEmail = DBRequestOwnersOld.GetCreatedByUserIdOwnerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{createdByUserIdViaEmail} :CreatedByUserId wner via email for owner {nameOwner} from table Owners");

            string createdByUserIdViaId = DBRequestOwnersOld.GetLasCreatedByUserIdById();
            Console.WriteLine($"{createdByUserIdViaId} :CreatedByUserId owner via id for owner {nameOwner} from table Owners");

            string ownerIdViaEmail = DBRequestOwnersOld.GetIdOwnerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{ownerIdViaEmail} :OwnerId wner via email for owner {nameOwner} from table Owners");

            string lastIdOwner = DBRequestOwnersOld.GetLastIdNewOwner();
            Console.WriteLine($"{lastIdOwner} :OwnerId owner via id for owner {nameOwner} from table Owners");

            string emailOwnerViaId = DBRequestOwnersOld.GetLastOwnerEmailNewOwnerByIdOwners();
            Console.WriteLine($"{emailOwnerViaId} :Email owner via id for owner {nameOwner} from table Owners");

            string ownerNameOwnerViaId = DBRequestOwnersOld.GetOwnerNameNewOwnerByIdOwners();
            Console.WriteLine($"{ownerNameOwnerViaId} :Owner Name owner via id for owner {nameOwner} from table Owners");

            string companyNameOwnerViaId = DBRequestOwnersOld.GetLastCompanyNameNewOwnerByIdOwners();
            Console.WriteLine($"{companyNameOwnerViaId} :Company Name owner via id for owner {nameOwner} from table Owners");

            string marketplaceIdByEmail = DBRequestOwnersOld.GetMarketplaceIdOwnerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{marketplaceIdByEmail} :MarketplaceId by email owner via id for owner {nameOwner} from table Owners");

            string lastMarketplaceId = DBRequestOwnersOld.GetLastMarketplaceIdOwner();
            Console.WriteLine($"{lastMarketplaceId} :Last MarketplaceId for owner {nameOwner} from table Owners");

            string brokerIdByEmail = DBRequestOwnersOld.GetIdBrokerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{brokerIdByEmail} :BrokerId by email owner for owner {nameOwner} from table Owners");

            string brokerIdFromTestData = DBRequestLandlordsOld.GetIdForBroker(DBTestDataDBForAdminsMySpace.BROKER_EMAIL);
            Console.WriteLine($"{brokerIdFromTestData} :BrokerId for owner {nameOwner} from table AspNetUsers");

            #endregion

            #region Assertions

            Assert.Multiple(() =>
            {
                Assert.AreEqual(createdByUserIdViaEmail, createdByUserIdViaId);
                Console.WriteLine($"CreatedByUserId owner via email for owner from table Owners: {createdByUserIdViaEmail} = {createdByUserIdViaId} CreatedByUserId owner via id for owner from table Owners");

                Assert.AreEqual(ownerIdViaEmail, lastIdOwner);
                Console.WriteLine($"Id owner via email for owner from table Owners: {ownerIdViaEmail} = {lastIdOwner} Id owner via id for owner from table Owners");

                Assert.AreEqual(emailOwnerViaId, DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
                Console.WriteLine($"Email owner via email for owner from table Owners: {emailOwnerViaId} = {DBTestDataDBForAdmins.NEW_OWNER_EMAIL} Email owner via id for owner ER");

                Assert.AreEqual(ownerNameOwnerViaId, DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME);
                Console.WriteLine($"Owner Name owner via email for owner from table Owners: {ownerNameOwnerViaId} = {DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME} Owner Name owner via id for owner ER");

                Assert.AreEqual(companyNameOwnerViaId, DBTestDataDBForAdmins.NEW_COMPANY_NAME_OWNER);
                Console.WriteLine($"Company Owner owner via email for owner from table Owners: {companyNameOwnerViaId} = {DBTestDataDBForAdmins.NEW_COMPANY_NAME_OWNER} LandlordId owner via id for owner ER");

                Assert.AreEqual(marketplaceIdByEmail, lastMarketplaceId);
                Console.WriteLine($"MarketplaceId for owner via email from table Owners: {marketplaceIdByEmail} = {lastMarketplaceId} Last MarketplaceId for owner via id from table Owners");

                Assert.AreEqual(brokerIdByEmail, brokerIdFromTestData);
                Console.WriteLine($"BrokerId by email owner: {brokerIdByEmail} = {brokerIdFromTestData} BrokerId for owner from table AspNetUsers");
            });

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwners")]
        [AllureSubSuite("OwnerBasicDataCommissionStructure")]

        #region Basic info about test

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: Getting the basic data of the owner commission structure
        //Comment: The table "OwnerCommissionsStructure".
        //Path to cheking's: 

        #endregion

        public void OwnerBasicDataCommissionStructure()
        {
            #region Preconditions

            var ownerEmail = DBTestDataDBForAdminsMySpace.OWNER_EMAIL;

            #endregion

            var fromDbBasicDataOwnerCommissionStructure = DBRequestOwnerCommissionsStructure.OwnerCommissionsStructure.GetBasicDataOwnerCommissionStructure(ownerEmail);
            Console.WriteLine($"Pay Type: {fromDbBasicDataOwnerCommissionStructure.PayType}");
            Console.WriteLine($"Tenant Number Of Months: {fromDbBasicDataOwnerCommissionStructure.TenantNumberOfMonths}");
            Console.WriteLine($"Tenant Percentage: {fromDbBasicDataOwnerCommissionStructure.TenantPercentage}");
            Console.WriteLine($"Owner Number Of Months: {fromDbBasicDataOwnerCommissionStructure.OwnerNumberOfMonths}");
            Console.WriteLine($"Owner Percentage: {fromDbBasicDataOwnerCommissionStructure.OwnerPercentage}");
            Console.WriteLine($"Take Off: {fromDbBasicDataOwnerCommissionStructure.TakeOff}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwners")]
        [AllureSubSuite("DeleteNewlyCreatedOwnerWithBroker")]

        public void DeleteNewlyCreatedOwnerWithBroker()
        {
            #region Preconditions

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            string ownerEmail = "Jovanny.Ziemann12@hotmail.com";

            #endregion

            #region Test

            DBRequestOwnerCommissionsStructure.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(ownerEmail, marketplaceId);
            DBRequestOwnerPhoneNumbers.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(ownerEmail, marketplaceId);
            DBRequestOwnerManagements.OwnerManagements.DeleteRecordAboutOwnerManagements(ownerEmail, marketplaceId);
            DbRequestOwners.DBOwners.DeleteCreatedUserOwner(ownerEmail, marketplaceId);

            #endregion
        }
    }
}
