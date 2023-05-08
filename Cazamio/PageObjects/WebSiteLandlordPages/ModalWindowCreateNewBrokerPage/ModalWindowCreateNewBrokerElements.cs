using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage
{
    public partial class ModalWindowCreateNewBroker
    {
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'Create a new Broker']")]
        public IWebElement TitleCreateNewBroker;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement InputFieldFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement InputFieldLastName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement InputFieldEmail;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Create']")]
        public IWebElement ButtonCreate;
    }
}
