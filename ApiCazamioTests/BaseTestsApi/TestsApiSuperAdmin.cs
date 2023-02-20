using Allure.Commons;
using ApiCazamioTests.ApiHelpers;
using ApiTests.ApiPagesObjects.ApiCommonPages.LogInApiAdmins;
using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCazamioTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApiSuperAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiSuperAdmin")]
        [AllureSubSuite("LogInAsSuperAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void LogInAsBroker()
        {
            var email = TestDataForWebSiteAdmin.EMAIL_SUPER_ADMIN_SUPER;
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var deviceFingerprint = ApiRequestData.DEVICE_FINGERPRINT;

            var responseLogInBroker = LogInAdmins.ExecuteLogIn(email, passwordGeneral, deviceFingerprint, ApiRequestData.TRUE);

            LogInAdmins.VerifyingBrandNameAgent(responseLogInBroker);
        }
    }
}
