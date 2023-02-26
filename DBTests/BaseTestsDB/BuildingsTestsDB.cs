using Allure.Commons;
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
    [TestFixture]
    [AllureNUnit]

    public class BuildingsTestsDB : Base
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
            string buildingName = DBTestDataDBForAdmins.NEW_BUILDING_NAME;
            string nameLandlordsTable = TestDataDBNamesTables.TABLE_NAME_LANDLORDS;

            string newAddressIdBuildingsTable = DBTableBuildings.GetLastAddressesIdNewBuilding();
            Console.WriteLine($"{newAddressIdBuildingsTable} :AddressesId building for {buildingName} from table Buildings");

            string newAddressIdAddressesTable = DBTableAddresses.GetLastIdNewBuilding();
            Console.WriteLine($"{newAddressIdAddressesTable} :AddressesId building for {buildingName} from table Addresses");

            string lastIdBuilding = DBTableBuildings.GetLastIdNewBuilding();
            Console.WriteLine($"{lastIdBuilding} :Last Id building for {buildingName} from table Buildings");

            string lastIdBuildingByAddressId = DBTableBuildings.GetLastIdNewBuildingByAddressId(newAddressIdBuildingsTable);
            Console.WriteLine($"{lastIdBuilding} :Last Id building for {buildingName} from table Buildings");

            string newMarketplaceIdBuildingsTable = DBTableBuildings.GetMarketplaceIdByBuildingNameNewBuilding(buildingName);
            Console.WriteLine($"{newMarketplaceIdBuildingsTable} :MarketplaceId building for {buildingName} from table Buildings");

            string landlordIdLandlordsTable = DBTableLandlords.GetIdLastForBroker();
            Console.WriteLine($"{landlordIdLandlordsTable} :LandlordId building for {buildingName} from table Buildings");

            string landlordIdBuildingsTable = DBTableBuildings.GetLastLandlordByBuildingNameNewBuilding(buildingName);
            Console.WriteLine($"{landlordIdBuildingsTable} :LandlordId building for {buildingName} from table Buildings");

            string buildingNameBuildingsTable = DBTableBuildings.GetBuildingNameByAddressIdNewBuilding();
            Console.WriteLine($"{buildingNameBuildingsTable} :LandlordId building for {buildingName} from table Buildings");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastIdBuilding, lastIdBuildingByAddressId);
                Console.WriteLine($"Last Id for building in table Buildings: {lastIdBuilding} = {lastIdBuildingByAddressId} Last Id by address for building in table Buildings");

                Assert.AreEqual(newAddressIdBuildingsTable, newAddressIdAddressesTable);
                Console.WriteLine($"AddressId for building in table Buildings: {newAddressIdBuildingsTable} = {newAddressIdAddressesTable} AddressId for building in table Addresses");

                Assert.AreEqual(newMarketplaceIdBuildingsTable, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId for building in table Buildings: {newMarketplaceIdBuildingsTable} = {DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId for building ER");

                Assert.AreEqual(landlordIdLandlordsTable, landlordIdBuildingsTable);
                Console.WriteLine($"MarketplaceId for building in table Buildings: {landlordIdLandlordsTable} = {DBTestDataDBForAdmins.BROKER_MARTIN_MACFLY_LANDLORD_ID} MarketplaceId for building ER");

                Assert.AreEqual(buildingNameBuildingsTable, DBTestDataDBForAdmins.NEW_BUILDING_NAME);
                Console.WriteLine($"Building Name for building in table Buildings: {buildingNameBuildingsTable} = {DBTestDataDBForAdmins.NEW_BUILDING_NAME} Building Name for building ER");
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
            string buildingName = DBTestDataDBForAdmins.BUILDING_NAME;

            string idBuildingByName = DBTableBuildings.GetIdBuildingByBuildingName(DBTestDataDBForAdmins.BUILDING_NAME);
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
            string buildingLlcName = DBTestDataDBForAdmins.BUILDING_LLC_NAME;

            string idBuildingByLlcName = DBTableBuildings.GetIdBuildingByLlcName(DBTestDataDBForAdmins.BUILDING_LLC_NAME);
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
            string buildingLlcName = DBTestDataDBForAdmins.BUILDING_LLC_NAME;

            string marketplaceIdForBuildingByAddress = DBTableBuildings.GetMarketplaceIdByBuildingByAddress(DBTestDataDBForAdmins.BUILDING_ADDRESS);
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
            string buildingLlcName = DBTestDataDBForAdmins.BUILDING_LLC_NAME;

            string marketplaceIdForBuildingByBuildingName = DBTableBuildings.GetMarketplaceIdByBuildingName(DBTestDataDBForAdmins.BUILDING_NAME);
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
            string buildingLlcName = DBTestDataDBForAdmins.BUILDING_LLC_NAME;

            string idBuildingByName = DBTableBuildings.GetIdBuildingByBuildingName(DBTestDataDBForAdmins.BUILDING_NAME);
            Console.WriteLine($"{idBuildingByName} :Id for building {buildingLlcName} in the table Buildings By BuildingName");

            string idBuildingByLlcName = DBTableBuildings.GetIdBuildingByLlcName(DBTestDataDBForAdmins.BUILDING_LLC_NAME);
            Console.WriteLine($"{idBuildingByLlcName} :AddressId for building {buildingLlcName} in the table Buildings By BuildingName");

            string landlordIdForBuilding = DBTableBuildings.GetLandlordIdByBuildingName(DBTestDataDBForAdmins.BUILDING_NAME);
            Console.WriteLine($"{landlordIdForBuilding} :LandlordId for building {buildingLlcName} in the table Buildings");

            string idBroker = DBTableLandlords.GetLandlordIdForBroker(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY);
            Console.WriteLine($"{idBroker} :Id for admin from table {TestDataDBNamesTables.TABLE_NAME_LANDLORDS}");

            string marketplaceIdForBuildingByAddress = DBTableBuildings.GetMarketplaceIdByBuildingByAddress(DBTestDataDBForAdmins.BUILDING_ADDRESS);
            Console.WriteLine($"{marketplaceIdForBuildingByAddress} :MarketplaceId for building {buildingLlcName} by address from table Buildings");

            string marketplaceIdForBuildingByBuildingName = DBTableBuildings.GetMarketplaceIdByBuildingName(DBTestDataDBForAdmins.BUILDING_NAME);
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
