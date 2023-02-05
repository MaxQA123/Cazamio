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
        //Comment: The tables "AspNetUsers", "Brokers", "AspNetUserRoles", "LandlordBrokers".
        //Path to cheking's: 

        public void RecordsDBAboutNewAgent()
        {
            string firstLastNameAgent = TestDataDBForWebSiteAdmin.NEW_AGENT_FIRST_LAST_NAME;

            string brokerIdAgentBrokers = DBAgents.GetBrokerIdNewAgentFromBrokers();
            Console.WriteLine($"{brokerIdAgentBrokers} :BrokerId for new agent {firstLastNameAgent} from table Brokers");

            string marketplaceIdAgentAspNetUsers = DBAgents.GetMarketplaceIDAgentFromAspNetUsers(TestDataDBForWebSiteAdmin.NEW_AGENT_EMAIL);
            Console.WriteLine($"{marketplaceIdAgentAspNetUsers} :MarketplaceId for agent {firstLastNameAgent} from table AspNetUsers");

            string marketplaceIdAgentBrokers = DBAgents.GetMarketplaceIDNewAgentFromBrokers();
            Console.WriteLine($"{marketplaceIdAgentBrokers} :MarketplaceId for agent {firstLastNameAgent} from table Brokers");

            string roleIdAgent = DBAgents.GetRoleIdNewAgentFromAspNetUserRoles();
            Console.WriteLine($"{roleIdAgent} :RoleId for new agent {firstLastNameAgent} from table AspNetUserRoles");

            string brokerdIdNewAgentLandlordBrokers = DBAgents.GetBrokerIdForNewAgent();
            Console.WriteLine($"{brokerdIdNewAgentLandlordBrokers} :BrokerId for new agent {firstLastNameAgent} from table LandlordBrokers");

            string LandlordIdRelatedNewAgent = DBBrokers.GetLandlordIdNewBrokerFromLandlordBrokers();
            Console.WriteLine($"{LandlordIdRelatedNewAgent} :LandlordId for new agent {firstLastNameAgent} from table LandlordBrokers");

            string roleNameNewAgentAspNetRoles = DBAgents.GetRoleNameAgentFromAspNetRoles(TestDataDBForWebSiteAdmin.NEW_AGENT_EMAIL);
            Console.WriteLine($"{roleNameNewAgentAspNetRoles} :Name role for new agent {firstLastNameAgent} from table AspNetRoles");

            string firstNameNewAgentAspNetUsers = DBAgents.GetFirstNameAgentFromAspNetUsers(TestDataDBForWebSiteAdmin.NEW_AGENT_EMAIL);
            Console.WriteLine($"{firstNameNewAgentAspNetUsers} :First Name for new agent {firstLastNameAgent} from table AspNetUsers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(marketplaceIdAgentAspNetUsers, TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for a new agent AspNetUsers: {marketplaceIdAgentAspNetUsers} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for a new agent ER");

                Assert.AreEqual(marketplaceIdAgentBrokers, TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for a new agent Brokers: {marketplaceIdAgentBrokers} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for a new agent ER");

                Assert.AreEqual(roleIdAgent, TestDataDBGeneral.ID_NAME_ROLE_AGENT);
                Console.WriteLine($"RoleId a new agent from table AspNetUserRoles: {roleIdAgent} = {TestDataDBGeneral.ID_NAME_ROLE_AGENT} RoleId a new agent ER");

                Assert.AreEqual(brokerIdAgentBrokers, brokerdIdNewAgentLandlordBrokers);
                Console.WriteLine($"BrokerId a new agent from table Brokers: {brokerIdAgentBrokers} = {brokerdIdNewAgentLandlordBrokers} BrokerId a new agent from table LandlordBrokers");

                Assert.AreEqual(LandlordIdRelatedNewAgent, TestDataDBForWebSiteAdmin.BROKER_MARTIN_MACFLY_LANDLORDID);
                Console.WriteLine($"LandlordId for a new agent from table LandlordBrokers: {LandlordIdRelatedNewAgent} = {TestDataDBForWebSiteAdmin.BROKER_MARTIN_MACFLY_LANDLORDID} LandlordId for a new agent from table ER");

                Assert.AreEqual(roleNameNewAgentAspNetRoles, TestDataDBGeneral.NAME_ROLE_AGENT);
                Console.WriteLine($"Name role for new agent AspNetRoles: {roleNameNewAgentAspNetRoles} = {TestDataDBGeneral.NAME_ROLE_AGENT} Name role for new agent ER");

                Assert.AreEqual(firstNameNewAgentAspNetUsers, TestDataDBForWebSiteAdmin.NEW_AGENT_FIRST_NAME);
                Console.WriteLine($"First Name for new agent AspNetUsers: {firstNameNewAgentAspNetUsers} = {TestDataDBForWebSiteAdmin.NEW_AGENT_FIRST_NAME} First Name for new agent ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]
        [AllureSubSuite("Empty")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void Empty()
        {
            
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

            string oneDeletedTableLandlordBrokers = DBAgents.GetDeleteAgentTableLandlordBrokers($"{TestDataDBForWebSiteAdmin.DELETED_AGENT_EMAIL}");
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
