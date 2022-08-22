using Allure.Commons;
using LandlordTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace LandlordTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseLandlord
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Landlord")]
        [AllureSubSuite("LogInAsLandlord")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as admin.
        //Comment: 

        public void LogInAsLandlord()
        {

        }
    }
}