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
        [AllureSuite("TestingDBAgent")]
        [AllureSubSuite("DispalyingIdAgentfromAspNetUsers")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "AspNetUsers".
        //Path to cheking's: 

        public void DispalyingIdAgentfromAspNetUsers()
        {
            string IdAgent = DBAgents.GetIdAgentFromAspNetUsers(TestDataForWebSiteAdmin.EMAIL_AGENT_TEST);
            Console.WriteLine($"{IdAgent} :Id for broker from table AspNetUsers");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]
        [AllureSubSuite("DispalyingBrokerIdAgentFromBrokers")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Brokers".
        //Path to cheking's: 

        public void DispalyingBrokerIdAgentFromBrokers()
        {
            string brokerId = DBAgents.GetBrokerIdAgentFromBrokers(TestDataForWebSiteAdmin.EMAIL_AGENT_TEST);
            Console.WriteLine($"{brokerId} :Id for broker from table Brokers");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]
        [AllureSubSuite("RelatedAgentWithBrokerFromLandlordBrokers")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "LandlordBrokers".
        //Path to cheking's: 

        public void RelatedAgentWithBrokerFromLandlordBrokers()
        {
            string landlordId = DBAgents.GetLandlordIdByBrokerIdFromLandlordBrokers(TestDataForWebSiteAdmin.EMAIL_AGENT_TEST);
            Console.WriteLine($"{landlordId} :LanlordId for broker from table LandlordBrokers");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]
        [AllureSubSuite("RecordsDBAboutNewAgent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Brokers".
        //Path to cheking's: 

        public void RecordsDBAboutNewAgent()
        {
            string firstLastNameAgent = TestDataDBForWebSiteAdmin.NEW_AGENT_FIRST_LAST_NAME;

            string userIdAgent = DBAgents.GetBrokerIdNewAgentFromBrokers();
            Console.WriteLine($"{userIdAgent} :UserId for new agent {firstLastNameAgent} from table Brokers");

            string marketplaceIdAgent = DBAgents.GetMarketplaceIdFromNewAgents();
            Console.WriteLine($"{marketplaceIdAgent} :MarketplaceId for broker {firstLastNameAgent} from table Brokers");

            string roleIdAgent = DBAgents.GetRoleIdNewAgentFromAspNetUserRoles();
            Console.WriteLine($"{roleIdAgent} :RoleId for new admin {firstLastNameAgent} from table AspNetUserRoles");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(marketplaceIdAgent, TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for a new agent: {marketplaceIdAgent} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for a new agent ER");

                Assert.AreEqual(roleIdAgent, TestDataDBGeneral.ID_NAME_ROLE_AGENT);
                Console.WriteLine($"RoleId a new broker from table AspNetUserRoles: {roleIdAgent} = {TestDataDBGeneral.ID_NAME_ROLE_AGENT} Id for broker from table AspNetUserRoles");
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
