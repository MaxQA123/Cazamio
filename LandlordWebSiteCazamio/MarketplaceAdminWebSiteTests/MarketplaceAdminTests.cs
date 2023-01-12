using Allure.Commons;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using MarketplaceAdminTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

namespace MarketplaceAdminTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseMarketplaceAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("LogInAsLandlord")]

        //Date of publication: 
        //Version\Build:
        //Willingness for testing: 
        //This test case is doing checking: 
        //Comment: 

        public void LogInMarketplaceAdmin()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifyAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);

        }
    }
}