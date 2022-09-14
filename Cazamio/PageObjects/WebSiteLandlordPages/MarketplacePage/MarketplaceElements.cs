using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.MarketplacePage
{
    public partial class Marketplace
    {
        [FindsBy(How = How.XPath, Using = ("//div[@class = 'navigation-title']"))]
        public IWebElement TitleMarketplacePage;
    }
}
