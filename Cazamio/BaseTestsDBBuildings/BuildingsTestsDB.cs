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
        [AllureSubSuite("GetIdBuildingByName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Buildings".
        //Path to cheking's: 

        public void DisplayingIdBuildingByName()
        {
            string idBuildingByName = DBBuildings.GetIdBuildingByName();
            Console.WriteLine($"Id building form table Buildings: {idBuildingByName}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBBuilding")]
        [AllureSubSuite("GetIdBuildingByName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Addresses".
        //Path to cheking's: 

        public void DisplayingIdBuildingByAddress()
        {
            string idBuildingByAddress = DBBuildings.GetAddressIdBuildingByName();
            Console.WriteLine(idBuildingByAddress);
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
            string idBuilding = DBBuildings.GetIdBuildingByName();
            Console.WriteLine($"Id in the table Buildings By BuildingName: {idBuilding}");
            string AddressidBuilding = DBBuildings.GetAddressIdBuildingByName();
            Console.WriteLine($"AddressId in the table Buildings By BuildingName: {AddressidBuilding}");
            string landlordIdForBuilding = DBBuildings.GetLandlordIdForBuilding();
            Console.WriteLine($"LandlordId in the table Buildings: {landlordIdForBuilding}");
            string idAdmin = DBAdmins.GetIdForLandlordFromLandlordsT();
            Console.WriteLine($"Id for admin from table Landlords: {idAdmin}");
            Assert.AreEqual(landlordIdForBuilding, idAdmin);
            Console.WriteLine($"LanlordId in table Buildings: {landlordIdForBuilding} = {idAdmin} Id admin in the table Landlords");
        }
    }
}
