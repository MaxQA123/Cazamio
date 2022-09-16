using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.BrokersPage
{
    public partial class Brokers
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'Brokers']"))]
        public IWebElement TitleBrokersPage;

        [FindsBy(How = How.XPath, Using = ("//button[@class = 'middle primary-action absolute-loader']"))]
        public IWebElement ButtonCreateBrokerBrkrsPage;
    }
}
