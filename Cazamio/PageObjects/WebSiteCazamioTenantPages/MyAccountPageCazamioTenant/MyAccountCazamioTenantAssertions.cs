﻿using CazamioProgect.Helpers;
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

        [AllureStep("VerifyTenatFirstName")]
        public MyAccountCazamioTenant VerifyTenatFirstNameTW(string getFirstNameActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getFirstNameExpected = TestDataForWebSiteCazamio.firstNameTenantWife;

            Assert.AreEqual(getFirstNameActual, getFirstNameExpected);

            return this;
        }

        [AllureStep("VerifyOccupantFirstNameTL")]
        public MyAccountCazamioTenant VerifyOccupantFirstNameTL(string getFirstNameActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getFirstNameExpected = TestDataForWebSiteCazamio.firstNameCurrentOccupantTomCruz;

            Assert.AreEqual(getFirstNameActual, getFirstNameExpected);

            return this;
        }

        [AllureStep("VerifyEnterData")]
        public MyAccountCazamioTenant VerifyEnterData()
        {
            Assert.IsTrue(Errors.IsInvisible(ErrorMyAccntPgTabAccnt));

            return this;
        }

        [AllureStep("VerifyEmailNewTenant")]
        public MyAccountCazamioTenant VerifyEmailNewTenant(string email)
        {
            WaitUntil.WaitSomeInterval(500);
            string getEmailActual = Browser._Driver.FindElement(By.XPath("//input[@id = 'account-email']")).GetAttribute("value");

            Assert.AreEqual(getEmailActual, email);

            return this;
        }

        #endregion
    }
}
