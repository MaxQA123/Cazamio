using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateNewLandlordPage
{
    public partial class ModalWndwCreateNewLandlord
    {
        [FindsBy(How = How.XPath, Using = ("//h2[text() = 'Create a new Landlord']"))]
        public IWebElement TitleMdlWndwCreateNewLandlord;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'first-name']"))]
        public IWebElement FieldInputFirstNameMdlWndwCrtNwLndlrd;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'last-name']"))]
        public IWebElement FieldInputLastNameMdlWndwCrtNwLndlrd;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'email']"))]
        public IWebElement FieldInputEmailMdlWndwCrtNwLndlrd;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'subDomain']"))]
        public IWebElement FieldInputMarketplaceSubdomainMdlWndwCrtNwLndlrd;

        [FindsBy(How = How.XPath, Using = ("//label[text() = 'Host : https://testlandlord-demo.cazamiodemo.com/']"))]
        public IWebElement NameHostMarketplaceSubdomainMdlWndwCrtNwLndlrd;

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = 'Create']"))]
        public IWebElement ButtonCreateMdlWndwCrtNwLndlrd;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Landlord has been successfully created']"))]
        public IWebElement MessageLandlordHasBeenSuccessfullyCreated;
        
    }
}
