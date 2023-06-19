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
        #region PageNewBuilging

        [FindsBy(How = How.XPath, Using = "//div[@class = 'navigation-title']")]
        public IWebElement TitleNewBuildingPage;

        #endregion

        #region TabBasicDetails

        [FindsBy(How = How.XPath, Using = "//ng-select[@bindlabel= 'fullName']")]
        public IWebElement DropDownMenuBrokerSelect;

        [FindsBy(How = How.CssSelector, Using = "input#inputAddress")]
        public IWebElement FieldInputAddressNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#city")]
        public IWebElement FieldInputCityNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#state")]
        public IWebElement FieldInputStateNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#zip")]
        public IWebElement FieldInputZipNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@id= 'neighborhood']")]
        public IWebElement FieldInputNeighborhoodNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#buildingName")]
        public IWebElement FieldInputBuildingNameNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#llcName")]
        public IWebElement FieldInputLlcNameNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "textarea#description")]
        public IWebElement FieldInputDescroptionNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//textarea[@id= 'internalNotes']")]
        public IWebElement FieldInputInternalNotesNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Select Pet Policies']")]
        public IWebElement ButtonSelectPetPolicies;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname= 'screeningFee']")]
        public IWebElement FieldInputCreditScreeningFee;

        [FindsBy(How = How.XPath, Using = "//button//span[text()= 'Select Payment Methods']")]
        public IWebElement ButtonSelectPaymentsMethodsNwBldngPg;

        #endregion

        #region Amenities

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-amenity']")]
        public IWebElement FieldInputSearchForAmenitiesNwBldngPg;

        #endregion

        #region Access

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add lock']")]
        public IWebElement ButtonAddLockForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'location']")]
        public IWebElement FieldInputLocationForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'accessType']")]
        public IWebElement ButtonAccessTypeForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@autocomplete = 'ab6a07d3a4cb']")]
        public IWebElement FieldInputLockForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Pin term']")]
        public IWebElement FieldInputPinCodeForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'lockGuid']")]
        public IWebElement FieldInputLockGuideForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//textarea[@formcontrolname = 'customNote']")]
        public IWebElement FieldInputCustomNoteForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'add-note-image']")]
        public IWebElement ButtonSelectImageForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Image was upload successfully.']")]
        public IWebElement MessageSuccessUploadImageForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Time Restriction Enabled ']")]
        public IWebElement CheckBoxTimeRestrictionEnabledForAccessNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Save']")]
        public IWebElement ButtonSaveForAccessNwBldngPg;

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

        [FindsBy(How = How.XPath, Using = "//div[@class = 'building-specials-container ng-star-inserted']//a[text() = 'Concessions']")]
        public IWebElement TabConcessionsSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'building-specials-container ng-star-inserted']//a[text() = 'Free Stuff']")]
        public IWebElement TabFreeStuffSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add']")]
        public IWebElement ButtonAddSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'name']")]
        public IWebElement FieldInputNameSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'monthsFree']")]
        public IWebElement FieldInputMonthsFreeSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'leaseTerms']")]
        public IWebElement FieldInputLeaseTermsSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//mat-button-toggle-group//mat-button-toggle[2]")]
        public IWebElement ButtonYesSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'dateFrom']")]
        public IWebElement FieldInputDateFromSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'dateTo']")]
        public IWebElement FieldInputDateToSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Save']")]
        public IWebElement ButtonSaveSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Cancel']")]
        public IWebElement ButtonCancelSpecialsNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'building-specials-container ng-star-inserted'] //table//tbody//td[1]")]
        public IWebElement RecordNameInTableConcessionNwBldngPg;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement FieldInputSelectItemsSpecialsNwBldngPg;

        #endregion

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@text = 'Next']//button[@type = 'button']")]
        public IWebElement ButtonGeneralNextNwBldngPg;
        
    }
}
