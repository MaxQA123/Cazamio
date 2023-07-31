using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.Commons;
using ApiTests.Base;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

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

        #region Basic info for test

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The table "MarketplaceAdmins", "AspNetRoles".
        //Path to cheking's:

        #endregion

        public void VarOnePaymentForApartmentWithoutCommissionsHoldingDeposit()
        {

        }
    }
}
