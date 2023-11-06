using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwCreateAApplicationPage
{
    public partial class ModalWndwCreateApplication
    {
        [FindsBy(How = How.XPath, Using = "//app-prepare-application//h2[text() = 'Create application']")]
        public IWebElement TitleCreateApplicationModalWndw;

        [FindsBy(How = How.XPath, Using = "//cazamio-mobile-button[@ng-reflect-text = 'Next']")]
        public IWebElement ButtonNextModalWndw;

        #region Create application step 1

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Look up existing lead or create new']")]
        public IWebElement FieldInputMainApplicantEmailAddressModalWndw;

        [FindsBy(How = How.XPath, Using = "//div[text() = 'tenantapp123ray@putsbox.com ']")]
        public IWebElement ItemEmailAddressModalWndw;

        [FindsBy(How = How.XPath, Using = "//cazamio-mobile-button[@ng-reflect-text = 'Cancel']")]
        public IWebElement ButtonCancelModalWndw;

        #endregion

        #region Create application step 2

        [FindsBy(How = How.XPath, Using = "//div[@class = 'address-input']")]
        public IWebElement FieldInputUnitAddressModalWndw;

        #endregion

        #region Create application step 3

        [FindsBy(How = How.XPath, Using = "//div[@class = 'main-info']//div[@class = 'info-field-container']//div[last()]")]
        public IWebElement ValueFromStringLeadEmailModalWndw;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'main-info']//div[@class = 'info-field-container'][2]//div[last()]")]
        public IWebElement ValueFromStringUnitAddressModalWndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'requested-offer-price']")]
        public IWebElement FieldInputRequestedOfferPriceModalWndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'lease-price']")]
        public IWebElement FieldInputLeasePriceModalWndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'security-deposit']")]
        public IWebElement FieldInputSecurityDepositModalWndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'rent-pre-payment']")]
        public IWebElement FieldInputMonthlyRentsPrePaymentModalWndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'mat-input-2']")]
        public IWebElement FieldInputMoveInDateModalWndwForCreateApplicationModalWndwViaListOfApplication;

        [FindsBy(How = How.XPath, Using = "//form//mat-form-field//input")]
        public IWebElement FieldInputMoveInDateModalWndwForCreateApplicationModalWndwViaApartmentView;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'mat-input-3']")]
        public IWebElement FieldInputRentalTermsModalWndw;

        [FindsBy(How = How.XPath, Using = "//cazamio-mobile-button[@ng-reflect-text = 'Create']")]
        public IWebElement ButtonCreateStepThreeModalWndw;

        #endregion

        #region Create application step 4

        [FindsBy(How = How.XPath, Using = "//div[text() = 'Application successfully created']")]
        public IWebElement MessageStepFourModalWndw;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add Applicant']")]
        public IWebElement ButtonAddApplicant;

        #endregion
    }
}
