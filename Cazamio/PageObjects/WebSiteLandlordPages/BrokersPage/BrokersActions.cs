using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.BrokersPage
{
    public partial class Brokers
    {
        [AllureStep("ClickButtonCreateBrokerBrokersPage")]
        public Brokers ClickButtonCreateBrokerBrokersPage()
        {
            Button.Click(ButtonCreateBrokerBrkrsPage);

            return this;
        }
    }
}
