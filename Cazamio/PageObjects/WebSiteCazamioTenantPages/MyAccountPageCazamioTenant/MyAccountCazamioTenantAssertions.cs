using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant
{
    public partial class MyAccountCazamioTenant
    {
        #region SectionAccountVirifyFirstName

        [AllureStep("GetFirstNameFromMyAccount")]
        public string GetFirstNameFromMyAccount()
        {
            WaitUntil.WaitSomeInterval(100);
            string getFirstName = FieldInputFirsNameMyAccntPgTabAccnt.GetAttribute("value");
            string getFirstNameActual = getFirstName.ToString();

            return getFirstNameActual;
        }

        [AllureStep("GetLastNameFromMyAccount")]
        public string GetLastNameFromMyAccount()
        {
            WaitUntil.WaitSomeInterval(100);
            string getLastName = FieldInputLastNameMyAccntPgTabAccnt.GetAttribute("value");
            string getLastNameActual = getLastName.ToString();

            return getLastNameActual;
        }

        [AllureStep("VerifyTenatFirstLastName")]
        public MyAccountCazamioTenant VerifyTenatFirstLastNameTW(string getFirstNameActual, string getLastNameActual)
        {
            Assert.Multiple (() =>
            {
                WaitUntil.WaitSomeInterval(500);
                string getFirstNameExpected = TestDataForWebSiteTenant.FIRST_NAME_TENANT_APPLICANT;
                string getLastNameExpected = TestDataForWebSiteTenant.LAST_NAME_TENANT_APPLICANT;

                Assert.AreEqual(getFirstNameExpected, getFirstNameActual);
                Assert.AreEqual(getLastNameExpected, getLastNameActual);

                Console.WriteLine($"First name EX: {getFirstNameExpected} AC: {getFirstNameActual}");
                Console.WriteLine($"Last name EX: {getLastNameExpected} AC: {getLastNameActual}");
            });
            return this;
        }

        [AllureStep("VerifyOccupantFirstName")]
        public MyAccountCazamioTenant VerifyOccupantFirstName(string getFirstNameActual, string getLastNameActual)
        {
            Assert.Multiple(() =>
            {
                WaitUntil.WaitSomeInterval(500);
                string getFirstNameExpected = TestDataForWebSiteTenant.NEW_FIRST_NAME_OCCUPANT_ONE;
                string getLastNameExpected = TestDataForWebSiteTenant.NEW_LAST_NAME_OCCUPANT_ONE;

                Assert.AreEqual(getFirstNameExpected, getFirstNameActual);
                Assert.AreEqual(getLastNameExpected, getLastNameActual);

                Console.WriteLine($"First name EX: {getFirstNameExpected} AC: {getFirstNameActual}");
                Console.WriteLine($"Last name EX: {getLastNameExpected} AC: {getLastNameActual}");
            });

            return this;
        }

        [AllureStep("VerifyEnterData")]
        public MyAccountCazamioTenant VerifyEnterData()
        {
            Assert.Multiple(() =>
           {
               Assert.IsTrue(Errors.IsInvisible(ErrorMyAccntPgTabAccnt));
           });
            
            return this;
        }

        [AllureStep("VerifyEmailFirstLastNamesNewTenant")]
        public MyAccountCazamioTenant VerifyEmailFirstLastNamesNewTenant(string emailExpected, string firstNameFromModalWindowHowShallWeCallYou, string lastNameFromModalWindowHowShallWeCallYou, string getFirstNameFromMyAccount, string getLastNameFromMyAccount)
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailMyAccntPgTabAccnt);
            string getEmailActual = FieldInputEmailMyAccntPgTabAccnt.GetAttribute("value");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(emailExpected, getEmailActual);
                Assert.AreEqual(firstNameFromModalWindowHowShallWeCallYou, getFirstNameFromMyAccount);
                Assert.AreEqual(lastNameFromModalWindowHowShallWeCallYou, getLastNameFromMyAccount);

            });

            return this;
        }

        [AllureStep("VerifyEmailFirstLastNamesNewTenant")]
        public MyAccountCazamioTenant VerifyEmailNewTenant(string emailExpected)
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailMyAccntPgTabAccnt);
            string getEmailActual = FieldInputEmailMyAccntPgTabAccnt.GetAttribute("value");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(emailExpected, getEmailActual);

            });

            return this;
        }

        #endregion
    }
}
