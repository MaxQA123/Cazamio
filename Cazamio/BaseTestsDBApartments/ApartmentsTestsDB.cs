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
        [AllureSubSuite("RelatedeApartmentBuildingAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void RelatedeApartmentBuildingAdmin()
        {
            string buildingName = "Royal House";

            string getLandlordId = DBApartments.GetLandlordIdFromApartmentsT("Royal House");
            Console.WriteLine($"LandlordId from table Apartments for {buildingName}: {getLandlordId}");
            string getBuildingId = DBApartments.GetBuildingIdFromApartmentsT("Royal House");
            Console.WriteLine($"BuildingId from table Apartments for {buildingName}: {getBuildingId}");
            string getUnitNumber = DBApartments.GetUnitFromApartmentsT("Royal House");
            Console.WriteLine($"Unit number from table Apartments for {buildingName}: {getUnitNumber}");
            string idBuilding = DBBuildings.GetIdBuildingByName();
            Console.WriteLine($"Id for {buildingName} in the table Buildings: {idBuilding}");
            Assert.AreEqual(getBuildingId, idBuilding);
            Console.WriteLine($"BuildingId in table Apartments for {buildingName}: {getBuildingId} = {idBuilding} Id building in the table Buildings for {buildingName}");
        }
    }
}
