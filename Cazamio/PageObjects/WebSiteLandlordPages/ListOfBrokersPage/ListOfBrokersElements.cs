using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'List of brokers']"))]
        public IWebElement TitleListOfBrokers;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Create Broker']"))]
        public IWebElement ButtonCreateBroker;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Broker has been successfully created']")]
        public IWebElement MessageBrokerHasBeenSuccessfullyCreated;

        [FindsBy(How = How.XPath, Using = "//app-landlords-list//table//tbody//tr[last()]//td[4]")]
        public IWebElement LastRecordEmailForLastBrokerInList;
    }
}
