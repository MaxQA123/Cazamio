﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.Commons;
using ApiTests.Base;
using CazamioProject.DBHelpers;
using CazamioProject.DBHelpers.TablePrices;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using static CazamioProject.DBHelpers.TablePrices.DBTablePrices;

namespace DBTests.BaseTestsDB
{
    [TestFixture]
    [AllureNUnit]

    public class CalculationsTestsDB : Base
    {

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBMarketplaceAdmin")]
        [AllureSubSuite("RelatedBuidingBroker")]

        #region Basic info about test

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: Payment for the apartment without the commissions and a holding deposit.
        //Comment: The table "Prices".
        //Path to cheking's:

        #endregion

        public void PaymentForApartmentWithoutCommissionsHoldingDepositViaModel()
        {
            var payment = DBCalculationsCheckings.Calculations.GetPaymentForApartmentWithoutCommissionsHoldingDeposit(DBTestDataDBForAdmins.BUILDING_ADDRESS, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{payment.PaymentOfApartment}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBMarketplaceAdmin")]
        [AllureSubSuite("RelatedBuidingBroker")]

        #region Basic info about test

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: Payment for the apartment without the commissions and with a holding deposit.
        //Comment: The table "Prices".
        //Path to cheking's:

        #endregion

        public void PaymentForApartmentWithoutCommissionsWithHoldingDepositViaModel()
        {
            var payment = DBCalculationsCheckings.Calculations.GetPaymentForApartmentWithoutCommissionsWithHoldingDeposit(DBTestDataDBForAdmins.BUILDING_ADDRESS, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{payment.PaymentOfApartment}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBMarketplaceAdmin")]
        [AllureSubSuite("RelatedBuidingBroker")]

        #region Basic info about test

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "Prices".
        //Path to cheking's:

        #endregion

        public void DisplayingLeasePrice()
        {
            var lesePrice = DBTablePrices.GetLeasePrice(DBTestDataDBForAdmins.BUILDING_ADDRESS, DBTestDataDBForAdmins.UNIT_NUMBER);
            Console.WriteLine($"{lesePrice.LeasePrice}");
        }

    }
}