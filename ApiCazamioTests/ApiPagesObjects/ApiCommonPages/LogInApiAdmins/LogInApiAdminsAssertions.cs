using ApiCazamioTests.ApiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.ApiPagesObjects.ApiCommonPages.LogInApiAdmins
{
    public partial class LogInAdmins
    {
        [AllureStep("VerifyingBrandNameNewAgent")]
        public static void VerifyingBrandNameAgent(ResponseLogInAdmins response)
        {
            Assert.AreEqual(ApiTestDataGeneral.BRAND_NAME_MARKETPLACE_ONE, response.Brand);
            Console.WriteLine($"{response.Brand} :Brand Name");
        }
    }
}
