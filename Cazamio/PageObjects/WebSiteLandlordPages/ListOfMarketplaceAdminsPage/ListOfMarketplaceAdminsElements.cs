using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfMarketplaceAdmins
{
    public partial class ListOfMarketplaceAdmins
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'List of marketplace admins']"))]
        public IWebElement TitleListOfMarketplaceAdmins;

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = 'Create Marketplace admin']"))]
        public IWebElement ButtonCreateMarketplaceAdmin;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Marketplace admin has been successfully created']"))]
        public IWebElement MessageMarketplaceAdminHasBeenSuccessfullyCreated;

        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr[last()]//td[3]"))]
        public IWebElement LastMarketplaceAdminEmailOnPage;
    }
}
