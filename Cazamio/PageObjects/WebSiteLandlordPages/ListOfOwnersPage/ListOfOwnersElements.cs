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

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = 'Create Owner']"))]
        public IWebElement ButtonCreateOwner;

        [FindsBy(How = How.XPath, Using = ("//tbody//tr//td[3]"))]
        public IWebElement FirstOwnerEmailOnPage;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Owner has been successfully created']"))]
        public IWebElement MessageOwnerHasBeenSuccessfullyCreated;
    }
}
