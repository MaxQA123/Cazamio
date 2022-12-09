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
            WaitUntil.WaitSomeInterval(500);
            string getFirstName = Browser._Driver.FindElement(By.XPath("//div[@class= 'info-title']")).Text;
            string getFirstNameActual = getFirstName.ToString();

            return getFirstNameActual;
        }

        [AllureStep("GetLastNameFromMyAccount")]
        public string GetLastNameFromMyAccount()
        {
            WaitUntil.WaitSomeInterval(500);
            string getLastName = Browser._Driver.FindElement(By.XPath("//div[@class = 'info-account ng-star-inserted']//div[2]//div[@class = 'info-title']")).Text;
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

        [AllureStep("VerifyEmailNewTenant")]
        public MyAccountCazamioTenant VerifyEmailNewTenant(string emailExpected)
        {
            WaitUntil.WaitSomeInterval(500);
            string getEmailActual = FieldInputEmailMyAccntPgTabAccnt.GetAttribute("value");

            Assert.AreEqual(emailExpected, getEmailActual);

            Console.WriteLine($"Email EX: {emailExpected} Email AC:{getEmailActual}");

            return this;
        }

        #endregion
    }
}
