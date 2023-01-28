using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.AgentsPage
{
    public partial class Agents
    {
        [AllureStep("ClickButtonCreateAgentAgentsPage")]
        public Agents ClickButtonCreateAgentAgentsPage()
        {
            Button.Click(ButtonCreateAgentBrkrsPage);

            return this;
        }
    }
}
