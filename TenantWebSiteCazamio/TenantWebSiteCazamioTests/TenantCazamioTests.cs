using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
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
        [AllureSuite("Admin")]
        [AllureSubSuite("Login")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as admin.
        //Comment: 

        public void LogInAsTenant()
        {

        }
    }
}