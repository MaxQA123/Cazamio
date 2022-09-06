using CazamioProgect.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant
{
    public partial class MyAccountCazamioTenant
    {
        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/profile']")]
        public IWebElement TabAccount;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/applications']")]
        public IWebElement TabApplications;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/favorites']")]
        public IWebElement TabFavorites;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'info-tabs']/ul/li[@routerlink = '/my-info/history']")]
        public IWebElement TabHistory;

        #region SidebarOnTabAccount

        [FindsBy(How = How.XPath, Using = "//input[@id= 'upload-account-photo']")]
        public IWebElement IconForUploadingImage;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'tab-container ng-star-inserted']//span[text() = 'Account']")]
        public IWebElement ButtonAccountMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'tab-container ng-star-inserted']//span[text() = 'Password']")]
        public IWebElement ButtonPasswordMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'tab-container ng-star-inserted']//span[text() = 'Billing details']")]
        public IWebElement ButtonBillingDetailsMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'tab-container ng-star-inserted']//span[text() = 'Log Out']")]
        public IWebElement ButtonLogOutMyAccntPgTabAccnt;

        #endregion

        #region TabAccountSectionAccount

        [FindsBy(How = How.XPath, Using = "//div[@class = 'profile-loadable-wrapper']//div[@class = 'cazamio-button-content']")]
        public IWebElement ButtonEditMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirsNameMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastNameMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'account-email']")]
        public IWebElement FieldInputEmailMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'phone-number']")]
        public IWebElement FieldInputPhoneNumberMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'birtday']")]
        public IWebElement FieldInputDateOfBirthMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id= 'date-address']")]
        public IWebElement FieldInputLivingThereSinceMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'address-acc']")]
        public IWebElement FieldInputStreetMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'city-acc']")]
        public IWebElement FieldInputCityMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'state-acc']")]
        public IWebElement FieldInputStateMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'zipcode-acc']")]
        public IWebElement FieldInputZipCodeSectionYourCrrntAdrsMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//button[@id = 'action']")]
        public IWebElement ButtonDropDownDoYouRentOrOwnThisPropertMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[text() = 'I rent this property']")]
        public IWebElement ItemFromDrpDwnIRentThisPropertyDoYouRntMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[text() = 'I own this property']")]
        public IWebElement ItemFromDrpDwnIOwnThisPropertyDoYouRntMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'accoumt-paid']")]
        public IWebElement FieldInputPriceRentMortgageCostMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'add-address-account ng-star-inserted']//input[@id = 'zipcode-acc']")]
        public IWebElement FieldInputZipCodeSectionDoYouRentOrOwnThisPropertMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'name-address']")]
        public IWebElement FieldInputNameSectionReferenceMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'basic-info-phone-address']")]
        public IWebElement FieldInputPhnNmbrSectionReferenceMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'landLordExtensionNumber']")]
        public IWebElement FieldInputExtensionNmbrSectionReferenceMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@class = 'default middle primary-action relative-loader ng-star-inserted']//button")]
        public IWebElement ButtonSaveMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Cancel']")]
        public IWebElement ButtonCancelMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'First Name is required']")]
        public IWebElement ErrorFirstNameIsRequiredMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'First Name is required']")]
        public IWebElement ErrorLastNameIsRequiredMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'Email address is required']")]
        public IWebElement ErrorEmailAddressIsRequiredMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[text() = 'Phone field is invalid']")]
        public IWebElement ErrorPhoneАieldШsШnvalidBaseMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'Street is required']")]
        public IWebElement ErrorStreetIsRequiredMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'City is required']")]
        public IWebElement ErrorCityIsRequiredMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'State is required']")]
        public IWebElement ErrorStateIsRequiredMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'Zip Code is required']")]
        public IWebElement ErrorZipCodeIsRequiredMyAccntPgTabAccnt;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-msg-error ng-star-inserted')]/span[text() = 'Phone field is invalid']")]
        public IWebElement ErrorPhoneFieldIsInvalidReferenceMyAccntPgTabAccnt;

        
        #endregion
    }
}
