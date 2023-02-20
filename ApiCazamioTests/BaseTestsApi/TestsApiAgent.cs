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

namespace ApiCazamioTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApiAgent
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
            //var email = TestDataForWebSiteAdmin.EMAIL_AGENT_TEST;
            //var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var deviceFingerprint = ApiRequestData.DEVICE_FINGERPRINT;

            //var responseLogInAgent = LogInAdmins.ExecuteLogIn(email, passwordGeneral, deviceFingerprint, ApiRequestData.TRUE);

            //LogInAdmins.VerifyingBrandUserNameEmailAgent(responseLogInAgent);

            var twoEmail = GenerateRandomDataHelper.RandomEmail + NameDomen.PUTS_BOX;
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var firstName = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_NAME;
            var lastName = DBTestDataForTenantMarketplaceOne.NEW_TENANT_LAST_NAME;
            var returnUrl = ApiRequestData.RETURN_URL;
            var isNeedToVisit = ApiRequestData.FALSE;
            var role = DBTestDataGeneral.NAME_ROLE_TENANT;
            var toHowToVisit = ApiRequestData.FALSE;

            var responseSignUpTenant = SignUpTenant.ExecuteSignUp(twoEmail, passwordGeneral, firstName, lastName, returnUrl, isNeedToVisit, role, toHowToVisit);

            VerifyPutsBox.VerifyVisibilityOfToaster(twoEmail);

            Console.WriteLine(responseSignUpTenant);
        }
    }
}
