using Allure.Commons;
using CazamioProgect.Helpers;
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
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Landlord")]
        [AllureSubSuite("LogInAsLandlord")]

        //Date of publication: 25.08.2022.
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as lanlord.
        //Comment: 

        public void LogInAsLandlord()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();

            Pages.SideBarLandlord
                .VerifyLandlordUserName(getUserNameCompare);

            WaitUntil.WaitSomeInterval(2000);

        }
    }
}