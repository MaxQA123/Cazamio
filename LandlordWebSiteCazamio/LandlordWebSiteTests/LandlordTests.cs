using Allure.Commons;
using CazamioProgect.PageObjects;
using LandlordTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

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
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully LogIn as lanlord.
        //Comment: 

        public void LogInAsLandlord()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPg()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            Thread.Sleep(5000);

        }
    }
}