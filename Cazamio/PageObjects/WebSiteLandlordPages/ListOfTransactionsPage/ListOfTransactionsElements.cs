using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfTransactionsPage
{
    public partial class ListOfTransactions
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'navigation-title']")]
        public IWebElement TitleListOfTransactionsPage;
    }
}
