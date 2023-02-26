using CazamioProject.ApiHelpers;
using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CazamioProject.DBHelpers;

namespace ApiTests.ApiPagesObjects.ApiCommonPages.LogInApiAdmins
{
    public partial class LogInAdmins
    {
        [AllureStep("VerifyingBrandUserNameEmailAgent")]
        public static void VerifyingBrandUserNameEmailAgent(ResponseLogInAdmins response)
        {
            Assert.Multiple(() =>
           {
               Assert.AreEqual(ApiTestDataGeneral.BRAND_NAME_MARKETPLACE_ONE, response.Brand);
               Console.WriteLine($"{response.Brand} :Brand Name");

               Assert.AreEqual(TestDataForWebSiteAdmin.USER_NAME_AGENT, response.AuthData.User.UserName);
               Console.WriteLine($"{response.AuthData.User.UserName} :User Name");

               Assert.AreEqual(TestDataForWebSiteAdmin.EMAIL_AGENT_TEST, response.AuthData.User.UserEmail);
               Console.WriteLine($"{response.AuthData.User.UserEmail} :email");
           });
        }

        [AllureStep("VerifyingBrandUserNameEmailMarketplaceAdmin")]
        public static void VerifyingBrandUserNameEmailMarketplaceAdmin(ResponseLogInAdmins response)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(ApiTestDataGeneral.BRAND_NAME_MARKETPLACE_ONE, response.Brand);
                Console.WriteLine($"{response.Brand} :Brand Name");

                Assert.AreEqual(DBTestDataDBForAdmins.MARKETPLACE_ADMIN_FIRST_LAST_NAME, response.AuthData.User.UserName);
                Console.WriteLine($"{response.AuthData.User.UserName} :User Name");

                Assert.AreEqual(DBTestDataDBForAdmins.MARKETPLACE_ADMIN_EMAIL, response.AuthData.User.UserEmail);
                Console.WriteLine($"{response.AuthData.User.UserEmail} :email");
            });
        }

        [AllureStep("VerifyingBrandUserNameEmailBroker")]
        public static void VerifyingBrandUserNameEmailBroker(ResponseLogInAdmins response)
        {
            Assert.Multiple(() =>
           {
               Assert.AreEqual(ApiTestDataGeneral.BRAND_NAME_MARKETPLACE_ONE, response.Brand);
               Console.WriteLine($"{response.Brand} :Brand Name");

               Assert.AreEqual(TestDataForWebSiteAdmin.USER_NAME_BROKER_MARTIN_MACFLY, response.AuthData.User.UserName);
               Console.WriteLine($"{response.AuthData.User.UserName} :User Name");

               Assert.AreEqual(TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY, response.AuthData.User.UserEmail);
               Console.WriteLine($"{response.AuthData.User.UserEmail} :email");
           });
        }

        [AllureStep("VerifyingUserNameEmailSuperAdmin")]
        public static void VerifyingUserNameEmailSuperAdmin(ResponseLogInAdmins response)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(TestDataForWebSiteAdmin.USER_NAME_SUPER_ADMIN, response.AuthData.User.UserName);
                Console.WriteLine($"{response.AuthData.User.UserName} :User Name");

                Assert.AreEqual(TestDataForWebSiteAdmin.EMAIL_SUPER_ADMIN_SUPER, response.AuthData.User.UserEmail);
                Console.WriteLine($"{response.AuthData.User.UserEmail} :Email");

            });
            
        }
    }
}
