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
        [AllureSubSuite("RelatedBuidingBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Buildings", "Addresses", "Landlords".
        //Path to cheking's: 

        public void NewBuilding()
        {
            string buildingName = TestDataDBForWebSiteAdmin.BUILDIN_NAME;
            string nameLandlordsTable = TestDataDBNamesTables.TABLE_NAME_LANDLORDS;

            string newAddressIdBuildingsTable = DBBuildings.GetAddressesIdInBuildingsNewBuilding();
            Console.WriteLine($"{newAddressIdBuildingsTable} :AddressesId building for {buildingName} from table Buildings");

            string newAddressIdAddressesTable = DBBuildings.GetAddressesIdInAddressesNewBuilding();
            Console.WriteLine($"{newAddressIdAddressesTable} :AddressesId building for {buildingName} from table Addresses");

            string newMarketplaceIdBuildingsTable = DBBuildings.GetMarketplaceIdInBuildingsNewBuilding();
            Console.WriteLine($"{newMarketplaceIdBuildingsTable} :MarketplaceId building for {buildingName} from table Buildings");

            string landlordIdLandlordsTable = DBBrokers.GetIdForBrokerFromLanlords(TestDataDBGeneral.ID_NAME_ROLE_BROKER);
            Console.WriteLine($"{landlordIdLandlordsTable} :LandlordId building for {buildingName} from table Buildings");

            string landlordIdBuildingsTable = DBBuildings.GetLandlordIdInBuildingsNewBuilding();
            Console.WriteLine($"{landlordIdBuildingsTable} :LandlordId building for {buildingName} from table Buildings");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(newAddressIdBuildingsTable, newAddressIdAddressesTable);
                Console.WriteLine($"AddressId for building in table Buildings: {newAddressIdBuildingsTable} = {newAddressIdAddressesTable} AddressId for building in table Addresses");

                Assert.AreEqual(newMarketplaceIdBuildingsTable, TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for building in table Buildings: {newMarketplaceIdBuildingsTable} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for building ER");

                Assert.AreEqual(landlordIdLandlordsTable, landlordIdBuildingsTable);
                Console.WriteLine($"MarketplaceId for building in table Buildings: {landlordIdLandlordsTable} = {landlordIdBuildingsTable} MarketplaceId for building in table Buildings");
            });
        }

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

            string idBuildingByName = DBBuildings.GetIdBuildingByName(TestDataDBForWebSiteAdmin.BUILDIN_NAME);
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
        //Comment: The table "Buildings".
        //Path to cheking's: 

        public void DisplayingIdBuildingByLlcName()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string idBuildingByLlcName = DBBuildings.GetIdBuildingByLlcName(TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME);
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
        //Comment: The table "Buildings".
        //Path to cheking's: 

        public void DisplayingMarketplaceIdForBuildingByAddress()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string marketplaceIdForBuildingByAddress = DBBuildings.GetMarketplaceIdForBuildingByAddress(TestDataDBForWebSiteAdmin.BUILDING_ADDRESS);
            Console.WriteLine($"{marketplaceIdForBuildingByAddress} :MarketplaceId for building {buildingLlcName} by address from table Buildings");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("DisplayingMarketplaceIdForBuildingByBuildingName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Buildings".
        //Path to cheking's: 

        public void DisplayingMarketplaceIdForBuildingByBuildingName()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string marketplaceIdForBuildingByBuildingName = DBBuildings.GetMarketplaceIdForBuildingByBuildingName(TestDataDBForWebSiteAdmin.BUILDIN_NAME);
            Console.WriteLine($"{marketplaceIdForBuildingByBuildingName} :MarketplaceId for building {buildingLlcName} by building name from table Buildings");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("RelatedBuidingBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Buildings".
        //Path to cheking's: 

        public void RelatedBuidingBroker()
        {
            string buildingLlcName = TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME;

            string idBuildingByName = DBBuildings.GetIdBuildingByName(TestDataDBForWebSiteAdmin.BUILDIN_NAME);
            Console.WriteLine($"{idBuildingByName} :Id for building {buildingLlcName} in the table Buildings By BuildingName");

            string idBuildingByLlcName = DBBuildings.GetIdBuildingByLlcName(TestDataDBForWebSiteAdmin.BUILDING_LLC_NAME);
            Console.WriteLine($"{idBuildingByLlcName} :AddressId for building {buildingLlcName} in the table Buildings By BuildingName");

            string landlordIdForBuilding = DBBuildings.GetLandlordIdForBuilding(TestDataDBForWebSiteAdmin.BUILDIN_NAME);
            Console.WriteLine($"{landlordIdForBuilding} :LandlordId for building {buildingLlcName} in the table Buildings");

            string idBroker = DBBrokers.GetIdForAdminFromLandlords(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            Console.WriteLine($"{idBroker} :Id for admin from table {TestDataDBNamesTables.TABLE_NAME_LANDLORDS}");

            string marketplaceIdForBuildingByAddress = DBBuildings.GetMarketplaceIdForBuildingByAddress(TestDataDBForWebSiteAdmin.BUILDING_ADDRESS);
            Console.WriteLine($"{marketplaceIdForBuildingByAddress} :MarketplaceId for building {buildingLlcName} by address from table Buildings");

            string marketplaceIdForBuildingByBuildingName = DBBuildings.GetMarketplaceIdForBuildingByBuildingName(TestDataDBForWebSiteAdmin.BUILDIN_NAME);
            Console.WriteLine($"{marketplaceIdForBuildingByBuildingName} :MarketplaceId for building {buildingLlcName} by building name from table Buildings");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(idBuildingByName, idBuildingByLlcName);
                Console.WriteLine($"Id for building by name in table Buildings: {idBuildingByName} = {idBuildingByLlcName} Id for building by LLC name in table Buildings");

                Assert.AreEqual(landlordIdForBuilding, idBroker);
                Console.WriteLine($"LanlordId in table Buildings: {landlordIdForBuilding} = {idBroker} Id broker ER {TestDataDBNamesTables.TABLE_NAME_LANDLORDS}");

                Assert.AreEqual(landlordIdForBuilding, idBroker);
                Console.WriteLine($"MarketplaceId by address in table Buildings: {marketplaceIdForBuildingByAddress} = {marketplaceIdForBuildingByBuildingName} MarketplaceId by building name in table Buildings");
            });
        }
    }
}
