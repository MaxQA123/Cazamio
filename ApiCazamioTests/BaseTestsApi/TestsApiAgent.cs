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
using CazamioProject.ApiHelpers.ApiPagesObjects.ApiTenantPages.SignUpTenant;
using CazamioProgect.PageObjects.EmailPutsBox;
using ApiTests.Base;

namespace ApiCazamioTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApiAgent : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiAgent")]
        [AllureSubSuite("LogInAsAgent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void LogInAsAgent()
        {
            var email = TestDataForWebSiteAdmin.EMAIL_AGENT_TEST;
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var deviceFingerprint = ApiRequestData.DEVICE_FINGERPRINT;

            var responseLogInAgent = LogInAdmins.ExecuteLogIn(email, passwordGeneral, deviceFingerprint, ApiRequestData.TRUE);

            LogInAdmins.VerifyingBrandUserNameEmailAgent(responseLogInAgent);
        }
    }
}
