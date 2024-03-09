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
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'Payment options']")]
        public IWebElement TitlePaymentOptions;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Credit Card ']")]
        public IWebElement ItemCreditCard;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' ACH ']")]
        public IWebElement ItemAch;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Deliver Check ']")]
        public IWebElement ItemDeliverCheck;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Zelle ']")]
        public IWebElement ItemZelle;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Venmo ']")]
        public IWebElement ItemVenmo;

        [FindsBy(How = How.XPath, Using = "//mat-dialog-container//div[@class = 'payments-wrapper']//div[@class = 'note-input']//textarea")]
        public IWebElement FieldInputDeliverCheckNoteBuilding;

        [FindsBy(How = How.XPath, Using = "//mat-dialog-container//div[@class = 'payments-wrapper']//div[@class = 'note-input ng-star-inserted']//textarea")]
        public IWebElement FieldInputDeliverCheckNoteApartment;

        [FindsBy(How = How.XPath, Using = "//mat-dialog-container//div[@class = 'payments-wrapper']//div[@class = 'note-input'][2]//input")]
        public IWebElement FieldInputZelleAddressOrPhoneBuilding;

        [FindsBy(How = How.XPath, Using = "//mat-dialog-container//div[@class = 'payments-wrapper']//div[@class = 'note-input ng-star-inserted'][2]//input")]
        public IWebElement FieldInputZelleAddressOrPhoneApartment;

        [FindsBy(How = How.XPath, Using = "//mat-dialog-container//div[@class = 'payments-wrapper']//div[@class = 'note-input'][3]//input")]
        public IWebElement ButtonForVenmoQrCodeImage;

        [FindsBy(How = How.XPath, Using = "//app-select-payment-method//span[@class = 'cazamio-button-txt']")]
        public IWebElement ButtonSaveMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//i[@class= 'material-icons']")]
        public IWebElement ButtonInFormCrossMdlWndwOptns;

        #region Assertions

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Success']")]
        public IWebElement MessageSuccessMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Payment methods selected, Click save to confirm']")]
        public IWebElement MessageSuccessPaymentMethodsSelectedMdlWndwOptns;

        #endregion
    }
}
