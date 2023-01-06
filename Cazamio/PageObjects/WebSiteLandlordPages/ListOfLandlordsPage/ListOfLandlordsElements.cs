using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfLandlordsPage
{
    public partial class ListOfLandlords
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'List of landlords']"))]
        public IWebElement TitleListOfLandlords;

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = 'Create Landlord']"))]
        public IWebElement ButtonCreateLandlord;
    }
}
