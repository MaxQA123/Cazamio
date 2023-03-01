using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateNewOwner
{
    public partial class ModalWndwCreateNewOwner
    {
        [FindsBy(How = How.XPath, Using = ("//app-owner-create-update//h2[text() = 'Create a new Owner']"))]
        public IWebElement TitleCreateANewOwner;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'companyName']"))]
        public IWebElement FieldInputCompanyName;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'ownerName']"))]
        public IWebElement FieldInputOwnerName;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'ownerEmail']"))]
        public IWebElement FieldInputOwnerEmail;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'officeLocation']"))]
        public IWebElement FieldInputOfficeLocation;

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'note']"))]
        public IWebElement FieldInputInternalNotes;

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = 'Create']"))]
        public IWebElement ButtonCreate;
    }
}
