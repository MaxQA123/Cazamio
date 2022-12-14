using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfOwnersPage
{
    public partial class ListOfOwners
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'List of owners']"))]
        public IWebElement TitleListOfOwnersPage;
    }
}
