using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
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

namespace CazamioProject.BaseTestsDBApartments
{
    [TestFixture]
    [AllureNUnit]

    public class ApartmentsTestsDB
    {

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApartments")]
        [AllureSubSuite("DisplayingIdApartments")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void DisplayingIdApartments()
        {
            string idApartmentByBuildingId = DBTableApartments.GetApartmentIdByBuildingIdUnit(DBTestDataDBForAdmins.BUILDING_ID, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{idApartmentByBuildingId} :ApartmentId from Apartments");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApartments")]
        [AllureSubSuite("GetIdApartmentFromBD")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RecordsDBAboutNewApartments()
        {
            string numberApartment = DBTestDataDBForAdmins.NEW_UNIT_NUMBER;
            string buildingName = DBTestDataDBForAdmins.BUILDING_NAME;

            string apartmentIdLast = DBTableApartments.GetLastApartmentId();
            Console.WriteLine($"{apartmentIdLast} :ApartmentId Last from table Apartments for {buildingName} related {numberApartment}");

            string apartmentIdByNameBuilding = DBTableApartments.GetApartmentIdByBuildingNameF(DBTestDataDBForAdmins.BUILDING_NAME);
            Console.WriteLine($"{apartmentIdByNameBuilding} :ApartmentId by NameBuilding from table Apartments for {buildingName} related {numberApartment}");

            string landlordId = DBApartments.GetLandlordIdApartmentForApartments();
            Console.WriteLine($"{landlordId} :LandlordId from table Apartments for {buildingName} related {numberApartment}");

            string buildingId = DBApartments.GetBuildingIdNewApartmentForApartments();
            Console.WriteLine($"{buildingId} :BuildingId from table Apartments for {buildingName} related {numberApartment}");

            string marketplaceId = DBApartments.GetMarketplaceIdApartmentForApartments();
            Console.WriteLine($"{marketplaceId} :MarketplaceId from table Apartments for {buildingName} related {numberApartment}");

            string unitName = DBApartments.GetUnitNameNewApartmentForApartments();
            Console.WriteLine($"{unitName} :Unit Name from table Apartments for {buildingName} related {numberApartment}");

            string brokerId = DBApartments.GetBrokerIdApartmentForApartments();
            Console.WriteLine($"{brokerId} :BrokerId from table Apartments for {buildingName} related {numberApartment}");

            string ownerId = DBApartments.GetOwnerIdApartmentForApartments();
            Console.WriteLine($"{ownerId} :OwnerId from table Apartments for {buildingName} related {numberApartment}");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(apartmentIdLast, apartmentIdByNameBuilding);
                Console.WriteLine($"ApartmentId Last from table Apartments: {apartmentIdLast} = {apartmentIdByNameBuilding} ApartmentId by NameBuilding from table Apartments");

                Assert.AreEqual(landlordId, DBTestDataDBForAdmins.BROKER_MARTIN_MACFLY_LANDLORD_ID);
                Console.WriteLine($"LandlordId from table Apartments: {landlordId} = {DBTestDataDBForAdmins.BROKER_MARTIN_MACFLY_LANDLORD_ID} LandlordId ER");

                Assert.AreEqual(buildingId, DBTestDataDBForAdmins.BUILDING_ID);
                Console.WriteLine($"BuildingId from table Apartments: {buildingId} = {DBTestDataDBForAdmins.BUILDING_ID} BuildingId ER");

                Assert.AreEqual(marketplaceId, DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO);
                Console.WriteLine($"MarketplaceId from table Apartments: {marketplaceId} = {DBTestDataGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId ER");

                Assert.AreEqual(unitName, DBTestDataDBForAdmins.NEW_UNIT_NUMBER);
                Console.WriteLine($"Unit Name from table Apartments: {unitName} = {DBTestDataDBForAdmins.NEW_UNIT_NUMBER} Unit Name ER");

                Assert.AreEqual(brokerId, DBTestDataDBForAdmins.AGENT_TEST_AGENT_BROKER_ID);
                Console.WriteLine($"BrokerId from table Apartments: {brokerId} = {DBTestDataDBForAdmins.AGENT_TEST_AGENT_BROKER_ID} BrokerId ER");

                Assert.AreEqual(ownerId, DBTestDataDBForAdmins.OWNER_AGATA_OWNER_ID);
                Console.WriteLine($"OwnerId from table Apartments: {ownerId} = {DBTestDataDBForAdmins.OWNER_AGATA_OWNER_ID} OwnerId ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApartments")]
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
    }
}
