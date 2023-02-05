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

            string buildingId = DBApartments.GetBuildingIdApartmentForApartments();
            Console.WriteLine($"{buildingId} :BuildingId from table Apartments for {buildingName} related {numberApartment}");
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(apartmentIdLast, apartmentIdByNameBuilding);
                Console.WriteLine($"ApartmentId Last from table Apartments: {apartmentIdLast} = {apartmentIdByNameBuilding} ApartmentId by NameBuilding from table Apartments");

                Assert.AreEqual(landlordId, TestDataDBForWebSiteAdmin.BROKER_MARTIN_MACFLY_LANDLORD_ID);
                Console.WriteLine($"LandlordId from table Apartments: {landlordId} = {TestDataDBForWebSiteAdmin.BROKER_MARTIN_MACFLY_LANDLORD_ID} LandlordId from table Apartments ER");

                Assert.AreEqual(buildingId, TestDataDBForWebSiteAdmin.BUILDING_ID);
                Console.WriteLine($"BuildingId from table Apartments: {buildingId} = {TestDataDBForWebSiteAdmin.BUILDING_ID} BuildingId from table Apartments ER");
            });
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBApartments")]
        [AllureSubSuite("RelatedeApartmentBuildingAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedeApartmentBuildingAdmin()
        {
            string buildingName = "LLC Atlant House";

            string getLandlordId = DBApartments.GetLandlordIdFromApartmentsT("LLC Atlant House");
            Console.WriteLine($"LandlordId from table Apartments for {buildingName}: {getLandlordId}");
            string getBuildingId = DBApartments.GetBuildingIdFromApartmentsT("LLC Atlant Housee");
            Console.WriteLine($"BuildingId from table Apartments for {buildingName}: {getBuildingId}");
            string getUnitNumber = DBApartments.GetUnitFromApartmentsT("LLC Atlant Housee");
            Console.WriteLine($"Unit number from table Apartments for {buildingName}: {getUnitNumber}");
            string idBuilding = DBBuildings.GetIdBuildingByName("Atlant");
            Console.WriteLine($"Id for {buildingName} in the table Buildings: {idBuilding}");
            Assert.AreEqual(getBuildingId, idBuilding);
            Console.WriteLine($"BuildingId in table Apartments for {buildingName}: {getBuildingId} = {idBuilding} Id building in the table Buildings for {buildingName}");
        }
    }
}
