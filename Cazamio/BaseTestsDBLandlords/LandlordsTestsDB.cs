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
        [AllureSuite("TestingBD")]
        [AllureSubSuite("GetIdBuildingByName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Lanlords".
        //Path to cheking's: 

        public void DisplayingIdForLandlordFromLandlordsTable()
        {
            //string idLandlord = DBLandlords.GetIdForLandlordFromLandlordsT();
            //Console.WriteLine($"Id for admin from table Landlords: {idLandlord}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingBD")]
        [AllureSubSuite("GetIdBuildingByName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Lanlords".
        //Path to cheking's: 

        public void CompareUserIdAdminWithMarkeplaceId()
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
