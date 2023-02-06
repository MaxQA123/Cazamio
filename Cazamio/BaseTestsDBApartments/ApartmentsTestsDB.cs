using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
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
        [AllureSubSuite("GetIdApartmentFromBD")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void DisplayingIdApartments()
        {
            string idApartment = DBApartments.GetIdApartment();

            Console.WriteLine(idApartment);
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
            string numberApartment = TestDataDBForWebSiteAdmin.NEW_UNIT_NUMBER;
            string buildingName = TestDataDBForWebSiteAdmin.BUILDING_NAME;

            string apartmentIdLast = DBApartments.GetApartmentIdApartmentForApartments();
            Console.WriteLine($"{apartmentIdLast} :ApartmentId Last from table Apartments for {buildingName} related {numberApartment}");

            string apartmentIdByNameBuilding = DBApartments.GetApartmentIdApartmentByBuildingNameForApartments(TestDataDBForWebSiteAdmin.BUILDING_NAME);
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

                Assert.AreEqual(landlordId, TestDataDBForWebSiteAdmin.BROKER_MARTIN_MACFLY_LANDLORD_ID);
                Console.WriteLine($"LandlordId from table Apartments: {landlordId} = {TestDataDBForWebSiteAdmin.BROKER_MARTIN_MACFLY_LANDLORD_ID} LandlordId ER");

                Assert.AreEqual(buildingId, TestDataDBForWebSiteAdmin.BUILDING_ID);
                Console.WriteLine($"BuildingId from table Apartments: {buildingId} = {TestDataDBForWebSiteAdmin.BUILDING_ID} BuildingId ER");

                Assert.AreEqual(buildingId, TestDataDBForWebSiteAdmin.BUILDING_ID);
                Console.WriteLine($"MarketplaceId from table Apartments: {marketplaceId} = {TestDataDBGeneral.MARKETPLACE_ID_TESTLANDLORD_DEMO} MarketplaceId ER");

                Assert.AreEqual(unitName, TestDataDBForWebSiteAdmin.NEW_UNIT_NUMBER);
                Console.WriteLine($"Unit Name from table Apartments: {unitName} = {TestDataDBForWebSiteAdmin.NEW_UNIT_NUMBER} Unit Name ER");

                Assert.AreEqual(brokerId, TestDataDBForWebSiteAdmin.AGENT_TEST_AGENT_BROKER_ID);
                Console.WriteLine($"BrokerId from table Apartments: {brokerId} = {TestDataDBForWebSiteAdmin.AGENT_TEST_AGENT_BROKER_ID} BrokerId ER");

                Assert.AreEqual(ownerId, TestDataDBForWebSiteAdmin.OWNER_AGATA_OWNER_ID);
                Console.WriteLine($"OwnerId from table Apartments: {ownerId} = {TestDataDBForWebSiteAdmin.OWNER_AGATA_OWNER_ID} OwnerId ER");
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
