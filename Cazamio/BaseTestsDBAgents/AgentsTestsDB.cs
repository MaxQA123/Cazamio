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

namespace CazamioProject.BaseTestsDBAgents
{
    [TestFixture]
    [AllureNUnit]

    public class AgentsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBroker")]
        [AllureSubSuite("RecordsDBAboutNewAgentr")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Lanlords".
        //Path to cheking's: 

        public void RecordsDBAboutNewAgent()
        {
            string newBroker = TestDataDBForWebSiteAdmin.BROKER_AXEL_FOLLY_LANDLORDID;

            string userIdBroker = DBAgents.GetUserIdNewAgentFromBrokers();
            Console.WriteLine($"{userIdBroker} :UserId for new broker {newBroker} from table Brokers");

            string roleIdBroker = DBAgents.GetRoleIdNewAgentFromAspNetUserRoles();
            Console.WriteLine($"{roleIdBroker} :RoleId for new admin {newBroker} from table AspNetUserRoles");

            string marketplaceIdBroker = DBAgents.GetMarketplaceIdFromBrokers();
            Console.WriteLine($"{marketplaceIdBroker} :MarketplaceId for broker {newBroker} from table Brokers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(roleIdBroker, TestDataDBGeneral.ID_NAME_ROLE_BROKER);
                Console.WriteLine($"RoleId a new broker from table AspNetUserRoles: {roleIdBroker} = {TestDataDBGeneral.ID_NAME_ROLE_BROKER} Id for broker from table AspNetUserRoles");

                Assert.AreEqual(marketplaceIdBroker, TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId admin for a new broker AR: {marketplaceIdBroker} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId broker for a new broker ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]
        [AllureSubSuite("RelatedNewAgentrWithAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedNewAgentWithAdmin()
        {
            string brokerName = "Fred Dred";

            string idBroker = DBAgents.GetIdAgentFromBrokersT("joingilbert901broker@gmail.com");
            Console.WriteLine($"{idBroker} :Id for broker {brokerName} from table Brokers");
            
            string landlordIdByEmail = DBAgents.GetLandlordIdByAgentId("joingilbert901broker@gmail.com");
            Console.WriteLine($"{landlordIdByEmail} :LandlordId by Email for broker {brokerName} from table LandlordBrokers");
            
            string landlordIdByBrokerid = DBAgents.GetLandlordIdForNewAgent();
            Console.WriteLine($"{landlordIdByBrokerid} :LandlordId for new broker {brokerName} from table LandlordBrokers");

            Assert.AreEqual(landlordIdByEmail, landlordIdByBrokerid);
            Console.WriteLine($"LandlordId by email broker AspNetUsers: {landlordIdByEmail} = {landlordIdByBrokerid} LandlordId for new broker in the table LandlordBrokers");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]
        [AllureSubSuite("DeletedRecordsInTableBrokersLandlordBrokersDBAboutAgent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Brokers", "LandlordBrokers".
        //Path to cheking's: 

        public void DeletedRecordsInTableBrokersLandlordBrokersDBAboutAgent()
        {
            string agentName = TestDataDBForWebSiteAdmin.DELETED_AGENT_FIRST_LAST_NAME;
            string tableBrokers = TestDataDBNamesTables.TABLE_NAME_BROKERS;
            string tableLandlordBrokers = TestDataDBNamesTables.TABLE_NAME_LANDLORD_BROKERS;

            string oneDeletedTableBrokers = DBAgents.GetDeleteAgentTableBrokers($"{TestDataDBForWebSiteAdmin.DELETED_AGENT_EMAIL}");
            Console.WriteLine($"{oneDeletedTableBrokers} :Displayed 1 for agent {agentName} from table {tableBrokers}");

            string oneDeletedTableLandlordBrokers = DBAgents.GetDeleteAgentTableBrokers($"{TestDataDBForWebSiteAdmin.DELETED_AGENT_EMAIL}");
            Console.WriteLine($"{oneDeletedTableLandlordBrokers} :Displayed 1 for agent {agentName} from table {tableLandlordBrokers}");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(oneDeletedTableBrokers, TestDataDBGeneral.TRUE);
                Console.WriteLine($"Deleted agent in table Brokers: {oneDeletedTableBrokers} = {TestDataDBGeneral.TRUE} Deleted agent in table {tableBrokers}");

                Assert.AreEqual(oneDeletedTableLandlordBrokers, TestDataDBGeneral.TRUE);
                Console.WriteLine($"Deleted agent in table LandlordBrokers: {oneDeletedTableLandlordBrokers} = {TestDataDBGeneral.TRUE} Deleted agent in table {tableLandlordBrokers}");

            });
        }
    }
}
