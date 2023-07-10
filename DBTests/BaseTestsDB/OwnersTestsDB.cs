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

    public class OwnersTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwner")]
        [AllureSubSuite("RecordsDBAboutNewOwner")]


        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Owners".
        //Path to cheking's: 

        public void RecordsDBAboutNewOwnerCommon()
        {
            string nameOwner = DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME;

            string createdByUserIdViaEmail = DBTableOwners.GetCreatedByUserIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{createdByUserIdViaEmail} :CreatedByUserId wner via email for owner {nameOwner} from table Owners");

            string createdByUserIdViaId = DBTableOwners.GetLasCreatedByUserIdById();
            Console.WriteLine($"{createdByUserIdViaId} :CreatedByUserId owner via id for owner {nameOwner} from table Owners");

            string ownerIdViaEmail = DBTableOwners.GetIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{ownerIdViaEmail} :OwnerId wner via email for owner {nameOwner} from table Owners");

            string lastIdOwner = DBTableOwners.GetLastIdNewOwner();
            Console.WriteLine($"{lastIdOwner} :OwnerId owner via id for owner {nameOwner} from table Owners");

            string emailOwnerViaId = DBTableOwners.GetLastOwnerEmailNewOwnerByIdOwners();
            Console.WriteLine($"{emailOwnerViaId} :Email owner via id for owner {nameOwner} from table Owners");

            string ownerNameOwnerViaId = DBTableOwners.GetOwnerNameNewOwnerByIdOwners();
            Console.WriteLine($"{ownerNameOwnerViaId} :Owner Name owner via id for owner {nameOwner} from table Owners");

            string companyNameOwnerViaId = DBTableOwners.GetLastCompanyNameNewOwnerByIdOwners();
            Console.WriteLine($"{companyNameOwnerViaId} :Company Name owner via id for owner {nameOwner} from table Owners");

            string marketplaceIdByEmail = DBTableOwners.GetMarketplaceIdOwnerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{marketplaceIdByEmail} :MarketplaceId by email owner via id for owner {nameOwner} from table Owners");

            string lastMarketplaceId = DBTableOwners.GetLastMarketplaceIdOwner();
            Console.WriteLine($"{lastMarketplaceId} :Last MarketplaceId for owner {nameOwner} from table Owners");

            string brokerIdByEmail = DBTableOwners.GetIdBrokerByOwnerEmail(DBTestDataDBForAdmins.NEW_OWNER_EMAIL);
            Console.WriteLine($"{brokerIdByEmail} :BrokerId by email owner for owner {nameOwner} from table Owners");

            string brokerIdFromTestData = DBTableLandlords.GetIdForBroker(DBTestDataDBForAdmins.BROKER_EMAIL);
            Console.WriteLine($"{brokerIdFromTestData} :BrokerId for owner {nameOwner} from table AspNetUsers");

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
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBOwner")]
        [AllureSubSuite("RecordsDBAboutNewOwner")]


        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Owners".
        //Path to cheking's: 

        public void RecordsDBAboutNewOwnerMySpace()
        {
            string nameOwner = DBTestDataDBForAdmins.NEW_OWNER_FIRST_LAST_NAME;

            string createdByUserIdViaEmail = DBTableOwners.GetCreatedByUserIdOwnerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{createdByUserIdViaEmail} :CreatedByUserId wner via email for owner {nameOwner} from table Owners");

            string createdByUserIdViaId = DBTableOwners.GetLasCreatedByUserIdById();
            Console.WriteLine($"{createdByUserIdViaId} :CreatedByUserId owner via id for owner {nameOwner} from table Owners");

            string ownerIdViaEmail = DBTableOwners.GetIdOwnerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{ownerIdViaEmail} :OwnerId wner via email for owner {nameOwner} from table Owners");

            string lastIdOwner = DBTableOwners.GetLastIdNewOwner();
            Console.WriteLine($"{lastIdOwner} :OwnerId owner via id for owner {nameOwner} from table Owners");

            string emailOwnerViaId = DBTableOwners.GetLastOwnerEmailNewOwnerByIdOwners();
            Console.WriteLine($"{emailOwnerViaId} :Email owner via id for owner {nameOwner} from table Owners");

            string ownerNameOwnerViaId = DBTableOwners.GetOwnerNameNewOwnerByIdOwners();
            Console.WriteLine($"{ownerNameOwnerViaId} :Owner Name owner via id for owner {nameOwner} from table Owners");

            string companyNameOwnerViaId = DBTableOwners.GetLastCompanyNameNewOwnerByIdOwners();
            Console.WriteLine($"{companyNameOwnerViaId} :Company Name owner via id for owner {nameOwner} from table Owners");

            string marketplaceIdByEmail = DBTableOwners.GetMarketplaceIdOwnerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{marketplaceIdByEmail} :MarketplaceId by email owner via id for owner {nameOwner} from table Owners");

            string lastMarketplaceId = DBTableOwners.GetLastMarketplaceIdOwner();
            Console.WriteLine($"{lastMarketplaceId} :Last MarketplaceId for owner {nameOwner} from table Owners");

            string brokerIdByEmail = DBTableOwners.GetIdBrokerByOwnerEmail(DBTestDataDBForAdminsMySpace.NEW_OWNER_EMAIL);
            Console.WriteLine($"{brokerIdByEmail} :BrokerId by email owner for owner {nameOwner} from table Owners");

            string brokerIdFromTestData = DBTableLandlords.GetIdForBroker(DBTestDataDBForAdminsMySpace.BROKER_EMAIL);
            Console.WriteLine($"{brokerIdFromTestData} :BrokerId for owner {nameOwner} from table AspNetUsers");

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
        }
    }
}
