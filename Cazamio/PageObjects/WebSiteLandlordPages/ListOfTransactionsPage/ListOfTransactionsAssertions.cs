using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfTransactionsPage
{
    public partial class ListOfTransactions
    {
        [AllureStep("VerifyTitleListOfTransactionsPg")]
        public ListOfTransactions VerifyTitleListOfTransactionsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfTransactionsPage));

            return this;
        }
    }
}
