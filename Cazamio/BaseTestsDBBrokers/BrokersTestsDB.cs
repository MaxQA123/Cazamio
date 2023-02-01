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
        //Comment: The table "Lanlords", "AspNetUserRoles", "AspNetUsers".
        //Path to cheking's: 

        public void RecordsDBAboutNewBroker()
        {
            string newBroker = TestDataDBForWebSiteAdmin.NEW_BROKER_FIRST_LAST_NAME;

            string IdNewBroker = DBBrokers.GetIdForBrokerFromAspNetUsers(TestDataDBForWebSiteAdmin.NEW_BROKER_EMAIL);
            Console.WriteLine($"{IdNewBroker}: Id for new broker {newBroker} from table AspNetUsers");

            string marketplaceIdNewBroker = DBBrokers.GetMarketplaceIdForBrokerFromAspNetUsers(TestDataDBForWebSiteAdmin.NEW_BROKER_EMAIL);
            Console.WriteLine($"{marketplaceIdNewBroker}: Id for new broker {newBroker} from table AspNetUsers");

            //string userIdAdmin = DBBrokers.GetUserIdNewAdminFromLandlords();
            //Console.WriteLine($"UserId for new broker {newBroker} from table Landlords: {userIdAdmin}");

            //string roleIdAdmin = DBBrokers.GetRoleIdNewAdminFromAspNetUserRoles();
            //Console.WriteLine($"RoleId for new broker {newBroker} from table AspNetUserRoles: {roleIdAdmin}");

            //string marketplaceIdByAdminEmail = DBBrokers.GetMarketplaceIdFromLandlordsT("twysb@putsbox.com");
            //Console.WriteLine($"MarketplaceId for broker {newBroker} from table Landlords: {marketplaceIdByAdminEmail}");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(IdNewBroker, TestDataDBForWebSiteAdmin.NEW_BROKER_ID);
                Console.WriteLine($"Id a new broker from table AspNetUsers: {IdNewBroker} = {TestDataDBForWebSiteAdmin.NEW_BROKER_ID} Id for broker ER");

                Assert.AreEqual(marketplaceIdNewBroker, TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId a new broker from table AspNetUsers: {marketplaceIdNewBroker} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for broker ER");

                //Assert.AreEqual(roleIdAdmin, TestDataDBGeneral.ID_NAME_ROLE_BROKER);
                //Console.WriteLine($"RoleId a new broker from table AspNetUserRoles: {roleIdAdmin} = {TestDataDBGeneral.ID_NAME_ROLE_BROKER} Id for admin from table AspNetUsers");

                //Assert.AreEqual(marketplaceIdByAdminEmail, TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                //Console.WriteLine($"MarketplaceId broker for a new admin AR: {marketplaceIdByAdminEmail} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId admin for a new admin ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBroker")]
        [AllureSubSuite("RelatedUserIdAdminWithMarkeplaceId")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedUserIdAdminWithMarkeplaceId()
        {
            string adminName = "Fred Dred";

            string idAdmin = DBBrokers.GetIdAdminFromLandlordsT("su1per2ad3min@gmail.com");
            Console.WriteLine($"Id for admin {adminName} from table Landlords: {idAdmin}");
            string marketplaceIdByAdminEmail = DBBrokers.GetMarketplaceIdFromLandlordsT("su1per2ad3min@gmail.com");
            Console.WriteLine($"MarketplaceId for admin {adminName} from table Landlords: {marketplaceIdByAdminEmail}");
            string marketplaceIdForNewAdmin = DBBrokers.GetMarketplaceIdForNewAdmin();
            Console.WriteLine($"MarketplaceId for admin {adminName} from table Landlords: {marketplaceIdForNewAdmin}");
            
            Assert.AreEqual(marketplaceIdByAdminEmail, marketplaceIdForNewAdmin);
            Console.WriteLine($"MarketplaceId by email new admin AspNetUsers: {marketplaceIdByAdminEmail} = {marketplaceIdForNewAdmin} MarketplaceId for new admin in the table Landlords");
        }
    }
}
