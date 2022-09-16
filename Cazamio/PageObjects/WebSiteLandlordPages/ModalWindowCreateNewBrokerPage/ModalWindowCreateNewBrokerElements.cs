using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage
{
    public partial class ModalWindowCreateNewBroker
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

        [FindsBy(How = How.XPath, Using = "//button[@class= 'middle primary-action absolute-loader ng-star-inserted']")]
        public IWebElement ButtonSaveCrtNwBrkrOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'success-container ng-star-inserted']//p[text() = 'New broker created successfully!']")]
        public IWebElement MessageNewBrokerCreatedSuccessfullyCrtNwBrkrOnMdlwndw;

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
