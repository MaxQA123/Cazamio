using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ListOfBuildingsPage
{
    public partial class ListOfBuildings
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= 'List of buildings']")]
        public IWebElement TitleListOfBuildingsPage;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'large primary-action relative-loader add-desktop-btn']")]
        public IWebElement ButtonAddListOfBuildings;
    }
}
