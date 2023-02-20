using Allure.Commons;
using CazamioProject.ApiHelpers;
using ApiTests.ApiPagesObjects.ApiTenantPages.ApiLogInTenant;
using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using CazamioProject.DBHelpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CazamioProject.ApiHelpers.ApiPagesObjects.ApiTenantPages.SignUpTenant;
using ApiTests.Base;

namespace ApiCazamioTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApiTenants : Base
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiPenant")]
        [AllureSubSuite("SignUpAsTenant")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void SignUpAsTenant(string email)
        {
            //var email = DBTestDataForTenantMarketplaceOne.NEW_TENANT_EMAIL;
            
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var firstName = DBTestDataForTenantMarketplaceOne.NEW_TENANT_FIRST_NAME;
            var lastName = DBTestDataForTenantMarketplaceOne.NEW_TENANT_LAST_NAME;
            var returnUrl = ApiRequestData.RETURN_URL;
            var isNeedToVisit = ApiRequestData.FALSE;
            var role = DBTestDataGeneral.NAME_ROLE_TENANT;
            var toHowToVisit = ApiRequestData.FALSE;

            var responseSignUpTenant = SignUpTenant.ExecuteSignUp(email, passwordGeneral, firstName, lastName, returnUrl, isNeedToVisit, role, toHowToVisit);

            //Pages.PutsBox.VerifyVisibilityOfToaster(email);

            Console.WriteLine(responseSignUpTenant);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiPenant")]
        [AllureSubSuite("LogInAsTenant")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void LogInAsTenant()
        {
            var email = TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT;
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = ApiRequestData.DEVICE_FINGERPRINT;

            var responseLogInTenant = LogInTenant.ExecuteLogIn(email, passwordGeneral, deviceFingerprint, rememberMe);

            LogInTenant.VerifyingUserNameEmailTenant(responseLogInTenant);
        }
    }
}
