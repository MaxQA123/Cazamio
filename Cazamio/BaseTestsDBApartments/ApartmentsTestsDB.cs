﻿using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
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
        [AllureSuite("TestingBD")]
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
        [AllureSuite("TestingBD")]
        [AllureSubSuite("GetIdBuildingByName")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: 
        //Path to cheking's: 

        public void CompareApartmentBuildingAdmin()
        {
            string getLandlordId = DBApartments.GetLandlordIdFromApartmentsT("Diamond Hall");
            Console.WriteLine($"LandlordId from table Apartments: {getLandlordId}");
            
        }
    }
}
