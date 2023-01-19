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

namespace CazamioProgect.BaseTestsDBBuildings
{
    [TestFixture]
    [AllureNUnit]

    public class BuildingsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("DisplayingIdBuildingByName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Buildings".
        //Path to cheking's: 

        public void DisplayingIdBuildingByName()
        {
            string buildingName = TestDataDBForWebSiteAdmin.BUILDIN_NAME;

            string idBuildingByName = DBBuildings.GetIdBuildingByName("New Beautifull 1234 *&%&$5l");
            Console.WriteLine($"{idBuildingByName} :Id building for {buildingName} from table Buildings");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("DisplayingIdBuildingByLlcName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Addresses".
        //Path to cheking's: 

        public void DisplayingIdBuildingByLlcName()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string idBuildingByLlcName = DBBuildings.GetIdBuildingByLlcName("LLC Bredlye");
            Console.WriteLine($"{idBuildingByLlcName} :Id building for {buildingLlcName} from table Buildings");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("DisplayingMarketplaceIdForBuildingByAddress")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Addresses".
        //Path to cheking's: 

        public void DisplayingMarketplaceIdForBuildingByAddress()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string marketplaceIdForBuildingByAddress = DBBuildings.GetMarketplaceIdForBuildingByAddress("12 2708 Lords Hill Road");
            Console.WriteLine($"{marketplaceIdForBuildingByAddress} :MarketplaceId for building {buildingLlcName} by address from table Buildings");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("DisplayingMarketplaceIdForBuildingByAddress")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Addresses".
        //Path to cheking's: 

        public void DisplayingMarketplaceIdForBuildingByBuildingName()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string marketplaceIdForBuildingByBuildingName = DBBuildings.GetMarketplaceIdForBuildingByBuildingName("Created LUIGI 1234 ^&$654");
            Console.WriteLine($"{marketplaceIdForBuildingByBuildingName} :MarketplaceId for building {buildingLlcName} by building name from table Buildings");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("CompareBuidingAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedBuidingAdmin()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string idBuildingByName = DBBuildings.GetIdBuildingByName("New Beautifull 1234 *&%&$5");
            Console.WriteLine($"{idBuildingByName} :Id for building {buildingLlcName} in the table Buildings By BuildingName");

            string idBuildingByLlcName = DBBuildings.GetIdBuildingByLlcName("LLC Bredlye");
            Console.WriteLine($"{idBuildingByLlcName} :AddressId for building {buildingLlcName} in the table Buildings By BuildingName");
            
            string landlordIdForBuilding = DBBuildings.GetLandlordIdForBuilding("");
            Console.WriteLine($"{landlordIdForBuilding} :LandlordId for building {buildingLlcName} in the table Buildings");
           
            string idAdmin = DBAdmins.GetIdForAdminFromLandlords();
            Console.WriteLine($"{idAdmin} :Id for admin from table Landlords");

            string marketplaceIdForBuildingByAddress = DBBuildings.GetMarketplaceIdForBuildingByAddress("12 2708 Lords Hill Road");
            Console.WriteLine($"{marketplaceIdForBuildingByAddress} :MarketplaceId for building {buildingLlcName} by address from table Buildings");

            string marketplaceIdForBuildingByBuildingName = DBBuildings.GetMarketplaceIdForBuildingByBuildingName("Created LUIGI 1234 ^&$654");
            Console.WriteLine($"{marketplaceIdForBuildingByBuildingName} :MarketplaceId for building {buildingLlcName} by building name from table Buildings");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(idBuildingByName, idBuildingByLlcName);
                Console.WriteLine($"Id for building by name in table Buildings: {idBuildingByName} = {idBuildingByLlcName} Id for building by LLC name in table Buildings");

                Assert.AreEqual(landlordIdForBuilding, idAdmin);
                Console.WriteLine($"LanlordId in table Buildings: {landlordIdForBuilding} = {idAdmin} Id admin in the table Landlords");

                Assert.AreEqual(landlordIdForBuilding, idAdmin);
                Console.WriteLine($"MarketplaceId by address in table Buildings: {marketplaceIdForBuildingByAddress} = {marketplaceIdForBuildingByBuildingName} MarketplaceId by building name in table Buildings");
            });
        }
    }
}
