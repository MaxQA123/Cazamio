using Allure.Commons;
using ApiTets.ApiPagesObjects.ApiBrokerPages.LogInBroker;
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

    public class TestsApiBroker
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiBroker")]
        [AllureSubSuite("LogInBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void LogInAsBroker()
        {
            var email = TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY;

            var responseLogIn = LogInBroker.ExecuteLogIn(email, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            Console.WriteLine(responseLogIn.Brand);
        }
    }
}
