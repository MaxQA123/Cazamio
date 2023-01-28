using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.AgentsPage
{
    public partial class Agents
    {
        [AllureStep("VerifyTitleBrokersPg")]
        public Agents VerifyTitleBrokersPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleAgentsPage));

            return this;
        }
    }
}
