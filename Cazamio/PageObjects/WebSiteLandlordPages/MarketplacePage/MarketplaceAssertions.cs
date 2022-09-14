using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.MarketplacePage
{
    public partial class Marketplace
    {
        [AllureStep("VerifyTitleMarketplacePg")]
        public Marketplace VerifyTitleMarketplacePg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleMarketplacePage));

            return this;
        }
    }
}
