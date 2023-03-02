﻿using Allure.Commons;
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
        [AllureSubSuite("DispalyingIdAgentfromAspNetUsers")]

    [TestFixture]
    [AllureNUnit]

    public class AgentsTestsDB : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]
        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "AspNetUsers".
        //Path to cheking's: 

        public void DispalyingIdAgentFromAspNetUsers()
        {
            string IdAgent = DBTableAspNetUsers.GetIdByEmail(TestDataForWebSiteAdmin.EMAIL_AGENT_TEST);
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
            string brokerId = DBTableBrokers.GetBrokerIdAgentByEmail(TestDataForWebSiteAdmin.EMAIL_AGENT_TEST);
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

        public void Empty()
        {

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
            string firstLastNameAgent = DBTestDataDBForAdmins.NEW_AGENT_FIRST_LAST_NAME;

            string IdAgent = DBTableAspNetUsers.GetIdByEmail(DBTestDataDBForAdmins.NEW_AGENT_EMAIL);
            Console.WriteLine($"{IdAgent} :Id for broker from table AspNetUsers");

            string lastIdAgent = DBTableBrokers.GetLastIdNewAgent();
            Console.WriteLine($"{lastIdAgent} :BrokerId for new agent {firstLastNameAgent} from table Brokers");

            string IdAgentByUserId = DBTableBrokers.GetIdByUserId(IdAgent);
            Console.WriteLine($"{IdAgentByUserId} :BrokerId for new agent {firstLastNameAgent} from table Brokers");

            string marketplaceIdAgentAspNetUsers = DBTableAspNetUsers.GetMarketplaceIdAgentByEmail(DBTestDataDBForAdmins.NEW_AGENT_EMAIL);
            Console.WriteLine($"{marketplaceIdAgentAspNetUsers} :MarketplaceId for agent {firstLastNameAgent} from table AspNetUsers");

            string marketplaceIdAgentBrokers = DBTableBrokers.GetLastMarketplaceIdNewAgentByUserId();
            Console.WriteLine($"{marketplaceIdAgentBrokers} :MarketplaceId for agent {firstLastNameAgent} from table Brokers");

            string roleIdAgent = DBTableAspNetUserRoles.GetRoleIdNewByUserId(IdAgent);
            Console.WriteLine($"{roleIdAgent} :RoleId for new agent {firstLastNameAgent} from table AspNetUserRoles");

            string roleNameNewAgentAspNetRoles = DBTableAspNetUserRoles.GetRoleNameAgentByEmail(DBTestDataDBForAdmins.NEW_AGENT_EMAIL);
            Console.WriteLine($"{roleNameNewAgentAspNetRoles} :Name role for new agent {firstLastNameAgent} from table AspNetRoles");

            string firstNameNewAgentAspNetUsers = DBTableAspNetUsers.GetFirstNameAgentByEmail(DBTestDataDBForAdmins.NEW_AGENT_EMAIL);
            Console.WriteLine($"{firstNameNewAgentAspNetUsers} :First Name for new agent {firstLastNameAgent} from table AspNetUsers");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(marketplaceIdAgentAspNetUsers, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for a new agent AspNetUsers: {marketplaceIdAgentAspNetUsers} = {DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for a new agent ER");

                Assert.AreEqual(marketplaceIdAgentBrokers, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for a new agent Brokers: {marketplaceIdAgentBrokers} = {DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for a new agent ER");

                Assert.AreEqual(roleIdAgent, DBTestDataGeneral.ID_NAME_ROLE_AGENT);
                Console.WriteLine($"RoleId a new agent from table AspNetUserRoles: {roleIdAgent} = {DBTestDataGeneral.ID_NAME_ROLE_AGENT} RoleId a new agent ER");

                Assert.AreEqual(lastIdAgent, IdAgentByUserId);
                Console.WriteLine($"BrokerId a new agent from table Brokers: {lastIdAgent} = {IdAgentByUserId} BrokerId a new agent from table LandlordBrokers");

                Assert.AreEqual(roleNameNewAgentAspNetRoles, DBTestDataGeneral.NAME_ROLE_AGENT);
                Console.WriteLine($"Name role for new agent AspNetRoles: {roleNameNewAgentAspNetRoles} = {DBTestDataGeneral.NAME_ROLE_AGENT} Name role for new agent ER");

                Assert.AreEqual(firstNameNewAgentAspNetUsers, DBTestDataDBForAdmins.NEW_AGENT_FIRST_NAME);
                Console.WriteLine($"First Name for new agent AspNetUsers: {firstNameNewAgentAspNetUsers} = {DBTestDataDBForAdmins.NEW_AGENT_FIRST_NAME} First Name for new agent ER");
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

        public void EmptyTwo()
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
            string agentName = DBTestDataDBForAdmins.DELETED_AGENT_FIRST_LAST_NAME;
            string tableBrokers = TestDataDBNamesTables.TABLE_NAME_BROKERS;

            string numberOneIsDeleted = DBTableBrokers.GetIsDeletedAgentByEmail(DBTestDataDBForAdmins.DELETED_AGENT_EMAIL);
            Console.WriteLine($"{numberOneIsDeleted} :Displayed 1 for agent {agentName} from table {tableBrokers}");

            Assert.AreEqual(numberOneIsDeleted, DBTestDataGeneral.TRUE);
            Console.WriteLine($"Record IsDeleted for agent in table Brokers: {numberOneIsDeleted} = {DBTestDataGeneral.TRUE} Record IsDeleted agent ER");
        }
    }
}