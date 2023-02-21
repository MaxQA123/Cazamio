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

namespace CazamioProject.BaseTestsDBBrokers
{
    [TestFixture]
    [AllureNUnit]
    public class BrokersTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBroker")]
        [AllureSubSuite("RecordsDBAboutNewBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Lanlords", "AspNetUserRoles", "AspNetUsers".
        //Path to cheking's: 

        public void RecordsDBAboutNewBroker()
        {
            string newBroker = DBTestDataDBForAdmins.NEW_BROKER_FIRST_LAST_NAME;

            string userIdByEmailBroker = DBTableAspNetUsers.GetIdForBrokerFromAspNetUsers(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{userIdByEmailBroker}: Id for new broker {newBroker} from table AspNetUsers");

            string userIdBroker = DBTableLandlords.GetUserIdNewBroker();
            Console.WriteLine($"{userIdBroker} :UserId for new broker {newBroker} from table Landlords");

            string lastLandlordIdBroker = DBTableLandlords.GetlastLandlordIdForBroker();
            Console.WriteLine($"{lastLandlordIdBroker} :LandlordId last for new broker {newBroker} from table Landlords");

            string lastLandlordIdBrokerByUserId = DBTableLandlords.GetlastLandlordIdByUserIdForBroker(userIdByEmailBroker);
            Console.WriteLine($"{lastLandlordIdBroker} :LandlordId by UserId for new broker {newBroker} from table Landlords");

            string marketplaceIdNewBroker = DBTableAspNetUsers.GetMarketplaceIdForBrokerByEmail(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{marketplaceIdNewBroker}: MarketplaceId for new broker {newBroker} from table AspNetUsers");

            string roleIdBroker = DBTableAspNetUserRoles.GetRoleIdNewBrokerByUserId();
            Console.WriteLine($"{roleIdBroker} :RoleId for new broker {newBroker} from table AspNetUserRoles");

            string roleNameBroker = DBTableAspNetRoles.GetRoleNameByEmail(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{roleNameBroker} :Name role for broker {newBroker} from table AspNetRoles");

            string firstNameBroker = DBTableAspNetUsers.GetFirstNameBrokerByEmail(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{firstNameBroker} :First Name for broker {newBroker} from table AspNetRoles");

            string emailNewBroker = DBTableAspNetUsers.GetEmailByIdNew(userIdByEmailBroker);
            Console.WriteLine($"{emailNewBroker} :Email for broker {newBroker} from table AspNetUsers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(userIdByEmailBroker, userIdBroker);
                Console.WriteLine($"Id a new broker from table AspNetUserRoles: {userIdByEmailBroker} = {userIdBroker} Id for admin from table Landlords");

                Assert.AreEqual(lastLandlordIdBroker, lastLandlordIdBrokerByUserId);
                Console.WriteLine($"LandlordId last a new broker from table Landlords: {lastLandlordIdBroker} = {lastLandlordIdBrokerByUserId} LandlordId by UserId for broker from table Landlords");

                Assert.AreEqual(marketplaceIdNewBroker, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId a new broker from table AspNetUsers: {marketplaceIdNewBroker} = {DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for broker ER");

                Assert.AreEqual(roleIdBroker, DBTestDataGeneral.ID_NAME_ROLE_BROKER);
                Console.WriteLine($"RoleId a new broker from table AspNetUserRoles: {roleIdBroker} = {DBTestDataGeneral.ID_NAME_ROLE_BROKER} RoleId for broker ER");

                Assert.AreEqual(roleNameBroker, DBTestDataGeneral.NAME_ROLE_BROKER);
                Console.WriteLine($"Name role a broker: {roleNameBroker} = {DBTestDataGeneral.NAME_ROLE_BROKER} Name role a broker ER");

                Assert.AreEqual(firstNameBroker, DBTestDataDBForAdmins.NEW_BROKER_FIRST_NAME);
                Console.WriteLine($"First Name a broker: {firstNameBroker} = {DBTestDataDBForAdmins.NEW_BROKER_FIRST_NAME} First Name a broker ER");

                Assert.AreEqual(emailNewBroker, DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
                Console.WriteLine($"Email a broker: {emailNewBroker} = {DBTestDataDBForAdmins.NEW_BROKER_EMAIL} Email a broker ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBroker")]
        [AllureSubSuite("RelatedUserIdBrokerWithMarkeplaceId")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Lanlords", "AspNetUsers".
        //Path to cheking's: 

        public void RelatedUserIdBrokerWithMarkeplaceId()
        {
            string brokerName = DBTestDataDBForAdmins.BROKER_FIRST_NAME;

            string landlordIddBroker = DBTableLandlords.GetIdForBroker(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            Console.WriteLine($"{landlordIddBroker} :Id for broker {brokerName} from table Landlords");

            string marketplaceIdByBrokerEmail = DBTableLandlords.GetMarketplaceIdBroker(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            Console.WriteLine($"{marketplaceIdByBrokerEmail} :MarketplaceId for broker {brokerName} from table Landlords");

            string IdBroker = DBTableAspNetUsers.GetIdForBrokerFromAspNetUsers(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            Console.WriteLine($"{IdBroker}: Id for new broker {brokerName} from table AspNetUsers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(landlordIddBroker, DBTestDataDBForAdmins.BROKER_MARTIN_MACFLY_LANDLORD_ID);
                Console.WriteLine($"LandlordId a broker from table Landlords: {landlordIddBroker} = {DBTestDataDBForAdmins.BROKER_MARTIN_MACFLY_LANDLORD_ID} LandlordId a broker from table Landlords ER");

                Assert.AreEqual(marketplaceIdByBrokerEmail, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for a broker from table AspNetUsers: {marketplaceIdByBrokerEmail} = {DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for broker ER");

                Assert.AreEqual(IdBroker, DBTestDataDBForAdmins.BROKER_MARTIN_MACFLY_ID);
                Console.WriteLine($"Id for a broker from table AspNetUsers: {IdBroker} = {DBTestDataDBForAdmins.BROKER_MARTIN_MACFLY_ID} Id for broker ER");
            });
        }
    }
}
