using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.ApiPagesObjects.ApiTenantPages.ApiLogInTenant
{
    public partial class LogInTenant
    {
        [AllureStep("VerifyingUserNameEmailTenant")]
        public static void VerifyingUserNameEmailTenant(ResponseLogInTenant response)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(TestDataForWebSiteTenant.FIRST_LAST_NAME_TENANT_APPLICANT, response.authData.user.userName);
                Console.WriteLine($"{response.authData.user.userName} :Userd Name");

                Assert.AreEqual(TestDataForWebSiteTenant.EMAIL_TENANT_APPLICANT, response.authData.user.userEmail);
                Console.WriteLine($"{response.authData.user.userEmail} :Email");
            });
        }
    }
}
