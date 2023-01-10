using Allure.Commons;
using CazamioProgect.Helpers;
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
        //Comment: The table "Lanlords".
        //Path to cheking's: 

        public void RecordsDBAboutNewBroker()
        {
            string newBroker = TestDataDBForWebSiteAdmin.NEW_ADMIN_FIRST_LAST_NAME;

            string userIdBroker = DBBrokers.GetUserIdNewBrokerFromBrokers();
            Console.WriteLine($"{userIdBroker} :UserId for new broker {newBroker} from table Brokers");

            string roleIdBroker = DBBrokers.GetRoleIdNewBrokerFromAspNetUserRoles();
            Console.WriteLine($"{roleIdBroker} :RoleId for new admin {newBroker} from table AspNetUserRoles");

            string marketplaceIdBroker = DBBrokers.GetMarketplaceIdFromBrokers();
            Console.WriteLine($"{marketplaceIdBroker} :MarketplaceId for broker {newBroker} from table Brokers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(roleIdBroker, TestDataDBGeneral.ID_NAME_ROLE_BROKER);
                Console.WriteLine($"RoleId a new broker from table AspNetUserRoles: {roleIdBroker} = {TestDataDBGeneral.ID_NAME_ROLE_BROKER} Id for broker from table AspNetUserRoles");

                Assert.AreEqual(marketplaceIdBroker, TestDataDBGeneral.MARKETPLACE_ID);
                Console.WriteLine($"MarketplaceId admin for a new broker AR: {marketplaceIdBroker} = {TestDataDBGeneral.MARKETPLACE_ID} MarketplaceId broker for a new broker ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBroker")]
        [AllureSubSuite("RelatedNewBrokerWithAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedNewBrokerWithAdmin()
        {
            string brokerName = "Fred Dred";

            string idBroker = DBBrokers.GetIdBrokerFromBrokersT("joingilbert901broker@gmail.com");
            Console.WriteLine($"{idBroker} :Id for broker {brokerName} from table Brokers");
            
            string landlordIdByEmail = DBBrokers.GetLandlordIdByBrokerId("joingilbert901broker@gmail.com");
            Console.WriteLine($"{landlordIdByEmail} :LandlordId by Email for broker {brokerName} from table LandlordBrokers");
            
            string landlordIdByBrokerid = DBBrokers.GetLandlordIdForNewBroker();
            Console.WriteLine($"{landlordIdByBrokerid} :LandlordId for new broker {brokerName} from table LandlordBrokers");

            Assert.AreEqual(landlordIdByEmail, landlordIdByBrokerid);
            Console.WriteLine($"LandlordId by email broker AspNetUsers: {landlordIdByEmail} = {landlordIdByBrokerid} LandlordId for new broker in the table LandlordBrokers");
        }
    }
}
