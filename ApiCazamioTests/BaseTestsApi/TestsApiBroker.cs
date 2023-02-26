using Allure.Commons;
using CazamioProject.ApiHelpers;
using ApiTests.ApiPagesObjects.ApiBrokerPages.CreateNewAgent;
using ApiTests.ApiPagesObjects.ApiCommonPages.CreateOwnerAdmins;
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
using RimuTec.Faker;
using ApiTests.Base;

namespace ApiCazamioTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApiBroker : Base
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

            LogInAdmins.VerifyingBrandUserNameEmailBroker(responseLogInBroker);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiBroker")]
        [AllureSubSuite("SignUpNewAgent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: IN PROGRESS.
        //This test case is doing checking: The successfully create a new "Agent".
        //Comment: 
        //Path to cheking's: 

        public void SignUpNewAgent()
        {
            var firstName = Name.FirstName();
            var lastName = Name.LastName();
            var email = GenerateRandomDataHelper.RandomEmail(5) + NameDomen.PUTS_BOX;
            var phoneNumber = GeneralTestDataForAllUsers.CODE_PHONE_NUMBER_ONE + GenerateRandomDataHelper.RandomPhoneNumber(7);
            var cell = GeneralTestDataForAllUsers.CODE_PHONE_NUMBER_TWO + GenerateRandomDataHelper.RandomPhoneNumber(7);

            var responseCreateAgent = CreateNewAgent.ExecuteCreateNewAgent(firstName, lastName, email, phoneNumber, cell);

            Console.WriteLine(responseCreateAgent.FirstName);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiBroker")]
        [AllureSubSuite("SignUpNewOwner")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully create a new "Owner".
        //Comment: 
        //Path to cheking's: 

        public void SignUpNewOwner()
        {
            var companyName = DBTestDataDBForAdmins.NEW_COMPANY_NAME_OWNER;
            var ownerEmail = GenerateRandomDataHelper.RandomEmail(5) + NameDomen.PUTS_BOX;
            var ownerName = Name.FirstName();
            var officeLocation = DBTestDataDBForAdmins.NEW_OFFICE_LOCATION_OWNER;

            var responseCreateOwner = CreateOwnerAdmins.ExecuteCreateOwner(companyName, ownerEmail, ownerName, officeLocation);

            Console.WriteLine(responseCreateOwner);
        }
    }
}
