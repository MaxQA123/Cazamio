using Allure.Commons;
using CazamioProgect.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

namespace TenantAbodeTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseTenantAbode
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("WebSiteAbodeTenant")]
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
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg();

            string getFirstNameForCompare = Pages.MyAccountCazamioTenant.GetFirstNameFromMyAccount();

            Pages.MyAccountCazamioTenant
                .VerifyTenatFirstName(getFirstNameForCompare);

            Thread.Sleep(5000);
        }

    }
}