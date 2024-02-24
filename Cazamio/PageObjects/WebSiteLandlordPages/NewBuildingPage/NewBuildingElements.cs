using CazamioProgect.Helpers;
using CazamioProject.Objects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        public IWebElement ItemForAutotestForBroker;

        public IWebElement SetItemForAutotestForBroker()
        {
            // Создание экземпляра класса Owner
            Owner owner = new Owner().Generate();

            // Использование переменной экземпляра owner для построения XPath
            var xpath = "//ng-dropdown-panel[@aria-label = 'Options list']//div[text() = '" + owner.AlreadyCreatedCompanyNameWithBroker + "']";

            // Присвоение значения ItemForAutotestForBroker
            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        public IWebElement ItemForAutotestForAgentBroker;

        public IWebElement SetItemForAutotestForAgentBroker()
        {
            // Создание экземпляра класса Owner
            Owner owner = new Owner().Generate();

            // Использование переменной экземпляра owner для построения XPath
            var xpath = "//ng-dropdown-panel[@aria-label = 'Options list']//div[text() = '" + owner.AlreadyCreatedCompanyNameWithAgent + "']";

            // Присвоение значения ItemForAutotestForBroker
            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        #region PageNewBuilging

        [FindsBy(How = How.XPath, Using = "//div[@class = 'navigation-title']")]
        public IWebElement TitleNewBuildingPage;

        #endregion

        #region ListOfTabs

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Amenities']")]
        public IWebElement TabAmenities;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Access']")]
        public IWebElement TabAccess;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Specials']")]
        public IWebElement TabSpecials;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Images']")]
        public IWebElement TabImages;

        #endregion

        #region TabBasicDetails

        [FindsBy(How = How.XPath, Using = "//ng-select[@placeholder= 'Select owner']")]
        public IWebElement ButtonMenuOwnerSelect;

        [FindsBy(How = How.CssSelector, Using = "input#inputAddress")]
        public IWebElement FieldInputAddress;

        [FindsBy(How = How.CssSelector, Using = "input#city")]
        public IWebElement FieldInputCity;

        [FindsBy(How = How.CssSelector, Using = "input#state")]
        public IWebElement FieldInputState;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'zip']")]
        public IWebElement FieldInputZip;

        [FindsBy(How = How.XPath, Using = "//input[@id= 'neighborhood']")]
        public IWebElement FieldInputNeighborhood;

        [FindsBy(How = How.CssSelector, Using = "input#buildingName")]
        public IWebElement FieldInputBuildingName;

        [FindsBy(How = How.CssSelector, Using = "input#llcName")]
        public IWebElement FieldInputLlcName;

        [FindsBy(How = How.CssSelector, Using = "textarea#description")]
        public IWebElement FieldInputDescroption;

        [FindsBy(How = How.XPath, Using = "//textarea[@id= 'internalNotes']")]
        public IWebElement FieldInputInternalNotes;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Select Pet Policies']")]
        public IWebElement ButtonSelectPetPolicies;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname= 'screeningFee']")]
        public IWebElement FieldInputCreditScreeningFee;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'holdDeposit']")]
        public IWebElement FieldInputHoldDeposit;

        [FindsBy(How = How.XPath, Using = "//button//span[text()= 'Select Payment Methods']")]
        public IWebElement BtnSelectPaymentMethodsForCreditScreeningFee;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'credit-screening-fee'][2]//cazamio-button[@text = 'Select Payment Methods']")]
        public IWebElement BtnSelectPaymentMethodsForHoldDeposit;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Edit']")]
        public IWebElement BtnEditForPaymentSystem;

        [FindsBy(How = How.XPath, Using = "//input[@name = 'api-key']")]
        public IWebElement FieldInputApiKey;

        #endregion

        #region Amenities

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-amenity']")]
        public IWebElement FieldInputSearchForAmenities;

        #endregion

        #region Access

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add lock']")]
        public IWebElement ButtonAddLock;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'location']")]
        public IWebElement FieldInputLocationForAccess;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'accessType']")]
        public IWebElement ButtonAccessType;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'PinCode']")]
        public IWebElement ItemPinCode;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Note']")]
        public IWebElement ItemNote;

        [FindsBy(How = How.XPath, Using = "//input[@autocomplete = 'ab6a07d3a4cb']")]
        public IWebElement FieldInputLockForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Pin term']")]
        public IWebElement FieldInputPinCodeForFirstEnter;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'mat-mdc-chip-list-input-0']")]
        public IWebElement FieldInputPinCodeForNextEnter;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'lockGuid']")]
        public IWebElement FieldInputLockGuideForAccess;

        [FindsBy(How = How.XPath, Using = "//textarea[@formcontrolname = 'customNote']")]
        public IWebElement FieldInputCustomNoteForAccess;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'add-note-image']")]
        public IWebElement ButtonSelectImageForAccess;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Image was upload successfully.']")]
        public IWebElement MessageSuccessUploadImageForAccess;

        //This element will be hidden
        //[FindsBy(How = How.XPath, Using = "//span[text() = ' Time Restriction Enabled ']")]
        //public IWebElement CheckBoxTimeRestrictionEnabledForAccess;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Save']")]
        public IWebElement ButtonSaveForLock;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Cancel']")]
        public IWebElement ButtonCancelForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//table//tbody//tr//td[text() = 'CAB']")]
        public IWebElement RecordCABInTableAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//table//tbody//tr//td[text() = 'Note']")]
        public IWebElement RecordNoteInTableAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//table//tbody//tr//td[text() = 'PinCode']")]
        public IWebElement RecordPinCodeInTableAccessNwBldngPg;

        #endregion

        #region Specials

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Free Stuff']")]
        public IWebElement TabFreeStuff;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Concessions']")]
        public IWebElement TabConcessions;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add']")]
        public IWebElement ButtonAddSpecials;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'name']")]
        public IWebElement FieldInputNameSpecials;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'monthsFree']")]
        public IWebElement FieldInputMonthsFree;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'leaseTerms']")]
        public IWebElement FieldInputLeaseTerms;

        [FindsBy(How = How.XPath, Using = "//mat-button-toggle-group//mat-button-toggle[2]")]
        public IWebElement ButtonYesSpecials;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'dateFrom']")]
        public IWebElement FieldInputDateFrom;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'dateTo']")]
        public IWebElement FieldInputDateTo;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Save']")]
        public IWebElement ButtonSaveSpecials;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Cancel']")]
        public IWebElement ButtonCancelSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'building-specials-container ng-star-inserted'] //table//tbody//td[1]")]
        public IWebElement RecordNameInTableConcessions;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'building-specials-container ng-star-inserted'] //table//tbody//td[1]")]
        public IWebElement RecordNameInTableFreeStuff;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Search for specials']")]
        public IWebElement FieldInputSelectItemsFreeStuff;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Free Netflix ']")]
        public IWebElement ItemFreeNetflix;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Google Speaker ']")]
        public IWebElement ItemGoogleSpeaker;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Application Submitted ']")]
        public IWebElement ButtonApplicationSubmittedTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Lease Signed']")]
        public IWebElement ButtonLeaseSignedTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Move In']")]
        public IWebElement ButtonMoveInTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Self Tour']")]
        public IWebElement ButtonSelfTourTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//mat-checkbox//label[text() = 'Is Active']")]
        public IWebElement CheckBoxIsActive;

        #endregion

        #region Images

        [FindsBy(How = How.XPath, Using = "//input[@class = 'ngx-file-drop__file-input']")]
        public IWebElement ButtonUploadImage;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Save']")]
        public IWebElement ButtonSaveBuilding;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Saved successfully!']")]
        public IWebElement MessageSavedSuccessfullyBuilding;
        
        #endregion

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@text = 'Next']")]
        public IWebElement ButtonGeneralNext;
        
    }
}
