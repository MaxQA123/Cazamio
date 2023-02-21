using Allure.Commons;
using CazamioProject.ApiHelpers;
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
using CazamioProject.DBHelpers;

namespace ApiCazamioTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApiMarketplaceAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiMarketplaceAdmin")]
        [AllureSubSuite("LogInAsMarketplaceAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: PLANED.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void LogInAsMarketplaceAdmin()
        {
            var email = DBTestDataDBForAdmins.MARKETPLACE_ADMIN_EMAIL;
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var deviceFingerprint = ApiRequestData.DEVICE_FINGERPRINT;

            var responseLogInMa = LogInAdmins.ExecuteLogIn(email, passwordGeneral, deviceFingerprint, ApiRequestData.TRUE);

            LogInAdmins.VerifyingBrandUserNameEmailMarketplaceAdmin(responseLogInMa);
        }
    }
}
