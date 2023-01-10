using Allure.Commons;
using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.BaseTestsDBAdmins
{
    [TestFixture]
    [AllureNUnit]
    public class AdminsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAdmin")]
        [AllureSubSuite("RecordsDBAboutNewAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Lanlords".
        //Path to cheking's: 

        public void RecordsDBAboutNewAdmin()
        {
            string newAdmin = TestDataDBForWebSiteAdmin.NEW_ADMIN_FIRST_LAST_NAME;

            string userIdAdmin = DBAdmins.GetUserIdNewAdminFromLandlords();
            Console.WriteLine($"UserId for new admin {newAdmin} from table Landlords: {userIdAdmin}");

            string roleIdAdmin = DBAdmins.GetRoleIdNewAdminFromAspNetUserRoles();
            Console.WriteLine($"RoleId for new admin {newAdmin} from table AspNetUserRoles: {roleIdAdmin}");

            string marketplaceIdByAdminEmail = DBAdmins.GetMarketplaceIdFromLandlordsT("twysb@putsbox.com");
            Console.WriteLine($"MarketplaceId for admin {newAdmin} from table Landlords: {marketplaceIdByAdminEmail}");
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(roleIdAdmin, TestDataDBGeneral.ID_NAME_ROLE_ADMIN);
                Console.WriteLine($"RoleId a new admin from table AspNetUserRoles: {roleIdAdmin} = {TestDataDBGeneral.ID_NAME_ROLE_ADMIN} Id for tenant from table AspNetUsers");

                Assert.AreEqual(marketplaceIdByAdminEmail, TestDataDBGeneral.MARKETPLACE_ID);
                Console.WriteLine($"MarketplaceId admin for a new admin AR: {marketplaceIdByAdminEmail} = {TestDataDBGeneral.MARKETPLACE_ID} MarketplaceId admin for a new admin ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAdmin")]
        [AllureSubSuite("CompareUserIdAdminWithMarkeplaceId")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedUserIdAdminWithMarkeplaceId()
        {
            string adminName = "Fred Dred";

            string idAdmin = DBAdmins.GetIdAdminFromLandlordsT("su1per2ad3min@gmail.com");
            Console.WriteLine($"Id for admin {adminName} from table Landlords: {idAdmin}");
            string marketplaceIdByAdminEmail = DBAdmins.GetMarketplaceIdFromLandlordsT("su1per2ad3min@gmail.com");
            Console.WriteLine($"MarketplaceId for admin {adminName} from table Landlords: {marketplaceIdByAdminEmail}");
            string marketplaceIdForNewAdmin = DBAdmins.GetMarketplaceIdForNewAdmin();
            Console.WriteLine($"MarketplaceId for admin {adminName} from table Landlords: {marketplaceIdForNewAdmin}");
            
            Assert.AreEqual(marketplaceIdByAdminEmail, marketplaceIdForNewAdmin);
            Console.WriteLine($"MarketplaceId by email new admin AspNetUsers: {marketplaceIdByAdminEmail} = {marketplaceIdForNewAdmin} MarketplaceId for new admin in the table Landlords");
        }
    }
}
