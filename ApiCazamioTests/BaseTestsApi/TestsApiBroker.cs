using Allure.Commons;
using ApiCazamioTests.ApiHelpers;
using ApiTests.ApiPagesObjects.ApiBrokerPages.CreateNewAgent;
using ApiTests.ApiPagesObjects.ApiCommonPages.LogInApiAdmins;
using CazamioProgect.Helpers;
using CazamioProject.DBHelpers;
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
        [AllureSubSuite("LogInAsBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void LogInAsBroker()
        {
            var email = TestDataForWebSiteAdmin.EMAIL_BROKER_MARTIN_MACFLY;
            var passwordGeneral = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var deviceFingerprint = ApiRequestData.DEVICE_FINGERPRINT;

            var responseLogInBroker = LogInAdmins.ExecuteLogIn(email, passwordGeneral, deviceFingerprint, ApiRequestData.TRUE);

            LogInAdmins.VerifyingBrandNameAgent(responseLogInBroker);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiBroker")]
        [AllureSubSuite("CreateNewAgent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully create a new "Agent".
        //Comment: 
        //Path to cheking's: 

        public void SignUpNewAgent()
        {
            var firstName = DBTestDataDBForAdmins.NEW_AGENT_FIRST_NAME;
            var lastName = DBTestDataDBForAdmins.NEW_AGENT_LAST_NAME;
            var email = DBTestDataDBForAdmins.NEW_AGENT_EMAIL;
            var phoneNumber = DBTestDataDBForAdmins.NEW_AGENT_PHONE_NUMBER;
            var cell = DBTestDataDBForAdmins.NEW_AGENT_CELL_PHONE_NUMBER;

            var responseCreateAgent = CreateNewAgent.ExecuteCreateNewAgent(firstName, lastName, email, phoneNumber, cell);

            Console.WriteLine(responseCreateAgent.Email);

            //LogInBroker.VerifyingBrandNameNewAgent(responseLogInBroker);
        }
    }
}
