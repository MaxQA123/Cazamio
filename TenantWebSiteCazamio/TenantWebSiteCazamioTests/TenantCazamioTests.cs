using Allure.Commons;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;
using TenantCazamioTests;

namespace TenantCazamioTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseTenantCazamio
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteCazamioTenant")]
        [AllureSubSuite("LogInAsTenant")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully LogIn as tenant.
        //Comment: 

        public void LogInAsTenant()
        {
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInCzmTnnt()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HeaderCazamioTenant
                .ClickButtonMyApplicationsHdrCzmTnnt();

            Thread.Sleep(5000);
        }
    }
}