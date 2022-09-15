using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.BrokersPage
{
    public partial class Brokers
    {
        [AllureStep("VerifyTitleBrokersPg")]
        public Brokers VerifyTitleBrokersPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleBrokersPage));

            return this;
        }
    }
}
