using Allure.Commons;
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

namespace SuperAdminTests
{
    [TestFixture]
    [AllureNUnit]

    public class SuperAdminTests : BaseSuperAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin")]
        [AllureSubSuite("LogInAsSuperAdmin")]

        //Date of publication: 
        //Version\Build:
        //Willingness for testing: 
        //This test case is doing checking: The successfully LogIn as super admin.
        //Comment: 

        public void LogInAsSuperAdmin()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordLogInPgAsSuperAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            Pages.SideBarLandlord
                .VerifySuperAdminUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}
