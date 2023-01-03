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

namespace CazamioProgect.BaseTestsDB
{
    [TestFixture]
    [AllureNUnit]

    public class TestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingBD")]
        [AllureSubSuite("GetBuildingNameFromBD")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The name email had been got successfully.
        //Comment: 
        //Path to cheking's: 

        public void DisplayingBuildingName()
        {
            string buildingName = WebSiteDBHelper.GetBuildingName();

            Console.WriteLine(buildingName);
        }
    }
}
