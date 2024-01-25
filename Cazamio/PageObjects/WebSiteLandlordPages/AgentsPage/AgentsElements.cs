using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.AgentsPage
{
    public partial class Agents
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'Agents']"))]
        public IWebElement TitleAgentsPage;

        [FindsBy(How = How.XPath, Using = ("//cazamio-button[@text= 'Create Agent']"))]
        public IWebElement ButtonCreateAgentAgntsPage;
    }
}
