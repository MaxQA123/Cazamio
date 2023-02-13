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

            string IdNewBroker = DBBrokers.GetIdForBrokerFromAspNetUsers(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{IdNewBroker}: Id for new broker {newBroker} from table AspNetUsers");

            string userIdBroker = DBBrokers.GetUserIdNewBrokerFromLandlords();
            Console.WriteLine($"{userIdBroker} :UserId for new broker {newBroker} from table Landlords");

            string marketplaceIdNewBroker = DBBrokers.GetMarketplaceIdForBrokerFromAspNetUsers(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{marketplaceIdNewBroker}: MarketplaceId for new broker {newBroker} from table AspNetUsers");

            string roleIdBroker = DBBrokers.GetRoleIdNewBrokerFromAspNetUserRoles();
            Console.WriteLine($"{roleIdBroker} :RoleId for new broker {newBroker} from table AspNetUserRoles");

            string roleNameBroker = DBBrokers.GetRoleNameBrokerFromAspNetRoles(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{roleNameBroker} :Name role for broker {newBroker} from table AspNetRoles");

            string firstNameBroker = DBBrokers.GetFirstNameBrokerFromAspNetUsers(DBTestDataDBForAdmins.NEW_BROKER_EMAIL);
            Console.WriteLine($"{firstNameBroker} :First Name for broker {newBroker} from table AspNetRoles");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(IdNewBroker, userIdBroker);
                Console.WriteLine($"Id a new broker from table AspNetUserRoles: {IdNewBroker} = {userIdBroker} Id for admin from table Landlords");

                Assert.AreEqual(marketplaceIdNewBroker, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId a new broker from table AspNetUsers: {marketplaceIdNewBroker} = {DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for broker ER");

                Assert.AreEqual(roleIdBroker, DBTestDataGeneral.ID_NAME_ROLE_BROKER);
                Console.WriteLine($"RoleId a new broker from table AspNetUserRoles: {roleIdBroker} = {DBTestDataGeneral.ID_NAME_ROLE_BROKER} RoleId for broker ER");

                Assert.AreEqual(roleNameBroker, DBTestDataGeneral.NAME_ROLE_BROKER);
                Console.WriteLine($"Name role a broker: {roleNameBroker} = {DBTestDataGeneral.NAME_ROLE_BROKER} Name role a broker ER");

                Assert.AreEqual(firstNameBroker, DBTestDataDBForAdmins.NEW_BROKER_FIRST_NAME);
                Console.WriteLine($"First Name a broker: {firstNameBroker} = {DBTestDataDBForAdmins.NEW_BROKER_FIRST_NAME} First Name a broker ER");
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

            string landlordIddBroker = DBBrokers.GetIdForBrokerFromLandlords(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            Console.WriteLine($"{landlordIddBroker} :Id for broker {brokerName} from table Landlords");

            string marketplaceIdByBrokerEmail = DBBrokers.GetMarketplaceIdBrokerFromLandlords(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            Console.WriteLine($"{marketplaceIdByBrokerEmail} :MarketplaceId for broker {brokerName} from table Landlords");

            string IdBroker = DBBrokers.GetIdForBrokerFromAspNetUsers(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
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
