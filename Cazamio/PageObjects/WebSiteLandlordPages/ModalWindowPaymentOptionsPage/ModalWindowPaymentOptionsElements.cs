using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowPaymentOptionsPage
{
    public partial class ModalWindowPaymentOptions
    {
        [FindsBy(How = How.XPath, Using = "//span[text() = ' Credit Card ']")]
        public IWebElement CheckBoxCreditCardMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' ACH ']")]
        public IWebElement CheckBoxAchMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Deliver Check ']")]
        public IWebElement CheckBoxDeliverCheckMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//textarea[@class = 'ng-untouched ng-pristine ng-valid']")]
        public IWebElement FieldInputDeliverCheckNoteMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//app-select-payment-method//span[@class = 'cazamio-button-txt']")]
        public IWebElement ButtonSaveMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//i[@class= 'material-icons']")]
        public IWebElement ButtonInFormCrossMdlWndwOptns;

        #region Assertions

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Success']")]
        public IWebElement MessageSuccessMdlWndwOptns;

        #endregion
    }
}
