using Allure.Commons;
using CazamioProject.DBHelpers;
using CazamioProject.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.BaseTestsDBPayments
{
    [TestFixture]
    [AllureNUnit]

    public class PaymentsTestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBPayment")]
        [AllureSubSuite("RecordsAboutNewPayments")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: 
        //Comment: The tables "Transactions".
        //Path to cheking's: 
        public void RecordsAboutNewPaymentHoldDeposit()
        {
            string lastTransactionId = DBTableTransactions.GetLastTransactionId();
            Console.WriteLine($"{lastTransactionId} :TransactionId last from table Transactions");

            string lastTransactionIdBytenantId = DBTableTransactions.GetLastTransactionIdByTenantId(DBTestDataForTenantMarketplaceOne.TENANT_APPLICANT_RAY_USER_ID);
            Console.WriteLine($"{lastTransactionIdBytenantId} :TransactionId last by TenantId from table Transactions");
        }
    }
}
