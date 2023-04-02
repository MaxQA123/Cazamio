using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfCommissionsPage
{
    public partial class ListOfCommissions
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'List of commissions']"))]
        public IWebElement TitleListOfCommissions;
    }
}
