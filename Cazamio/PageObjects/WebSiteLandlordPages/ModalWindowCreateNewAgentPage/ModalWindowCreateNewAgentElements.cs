using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewAgentPage
{
    public partial class ModalWindowCreateNewAgent
    {
        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstNameCrtNwBrkrOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastNameCrtNwBrkrOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement FieldInputEmailCrtNwBrkrOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'phoneNumber']")]
        public IWebElement FieldInputPhoneNumberCrtNwBrkrOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'cell']")]
        public IWebElement FieldInputCellCrtNwBrkrOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'broker-commission']")]
        public IWebElement FieldInputBrokerCommissionMdlwndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'agent-commission']")]
        public IWebElement FieldInputAgentCommissionMdlwndw;

        [FindsBy(How = How.XPath, Using = "//cazamio-button//span[text() = 'Save']")]
        public IWebElement ButtonSaveCrtNwAgntOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//p[text() = 'New agent created successfully!']")]
        public IWebElement MessageNewAgentCreatedSuccessfullyCrtNwAgntOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        public IWebElement ErrorFirstNameCrtNwBrkrOnMdlwndw;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorLastNameCrtNwBrkrOnMdlwndw;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorEmailCrtNwBrkrOnMdlwndw;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorPhoneNumberCrtNwBrkrOnMdlwndw;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorCellNameCrtNwBrkrOnMdlwndw;
    }
}
