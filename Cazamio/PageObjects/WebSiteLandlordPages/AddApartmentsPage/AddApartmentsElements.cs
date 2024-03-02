using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Add Apartments']"))]
        public IWebElement TitleAddApartmentsPage;

        #region TabUnits

        [FindsBy(How = How.XPath, Using = ("//ng-select[@bindlabel = 'buildingName']//div[@aria-haspopup = 'listbox']"))]
        public IWebElement ButtonBuildingNameAddApartmentsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'unit']"))]
        public IWebElement FieldInputUnitNumberAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//div[@aria-selected = 'true']//span"))]
        public IWebElement GetValueFromFieldBuildingName;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'bedrooms']"))]
        public IWebElement FieldInputBedroomsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'half-bedrooms']"))]
        public IWebElement FieldInputHalfBedroomsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'bathrooms']"))]
        public IWebElement FieldInputBathroomsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'half-bathrooms']"))]
        public IWebElement FieldInputHalfBathroomsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'sqFoot']"))]
        public IWebElement FieldInputSqFootAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'leastPrice']"))]
        public IWebElement FieldInputLeasePriceAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'depositPrice']"))]
        public IWebElement FieldInputSecurityDepositAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'paidMonths']"))]
        public IWebElement FieldInputMonthlyRentsPrePaymentAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'floor']"))]
        public IWebElement FieldInputFloorAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'status']"))]
        public IWebElement ButtonApartmentStatusAddAprtmntsUnitsPage;

        //[FindsBy(How = How.XPath, Using = ("//div[@id = 'a306793add00']"))]
        //public IWebElement ItemOffMarketAddAprtmntsUnitsPage;

        //[FindsBy(How = How.XPath, Using = ("//div[@id = 'a071ad8d5d53']"))]
        //public IWebElement ItemOccupiedAddAprtmntsUnitsPage;

        //[FindsBy(How = How.XPath, Using = ("//div[@id = 'a306793add00']"))]
        //public IWebElement ItemVacantAddAprtmntsUnitsPage;

        //[FindsBy(How = How.XPath, Using = ("//div[@id = 'a306793add00']"))]
        //public IWebElement ItemDepositReceivedAddAprtmntsUnitsPage;

        //[FindsBy(How = How.XPath, Using = ("//div[@id = 'a306793add00']"))]
        //public IWebElement ItemApplicationSubmittedAddAprtmntsUnitsPage;

        //[FindsBy(How = How.XPath, Using = ("//div[@id = 'a306793add00']"))]
        //public IWebElement ItemSignedLeaseAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'broker']"))]
        public IWebElement ButtonAssignedAgentAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'availableFrom']"))]
        public IWebElement FieldInputAvailableFromAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'MultiFamily']"))]
        public IWebElement ItemApartmentTypeMultiFamilyAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'holdingDeposit']"))]
        public IWebElement FieldInputApartmentHoldDepositAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Set default']"))]
        public IWebElement ButtonSetDefaultAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Payment methods']"))]
        public IWebElement ButtonPaymentMethodsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//mat-chip-list[@id = 'mat-chip-list-1']"))]
        public IWebElement FieldInputRentalTermsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//mat-chip[text() =  ' 12 months ']"))]
        public IWebElement ItemTwelveMonthsRentalTermsAddAprtmntsUnitsPage;

        #region RequiredDocuments

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' 3 Recent paystubs ']"))]
        public IWebElement ItemThreeRecentPaystubsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' Photo ID ']"))]
        public IWebElement ItemPhotoIdPaystubsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' 2 Most recent bank statements ' ]"))]
        public IWebElement ItemTwoMostRecentBankStatementsAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' Most recent W-2 or 1099 ' ]"))]
        public IWebElement ItemrMostRecentWTwoOrOneZeroNineNineAddAprtmntsUnitsPage;

        #endregion

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'description' ]"))]
        public IWebElement FieldInputDescriptionAddAprtmntsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'internalNotes' ]"))]
        public IWebElement FieldInputInternalNotesAddAprtmntsUnitsPage;

        #region Amenities

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-amenity']")]
        public IWebElement FieldInputSearchForAmenitiesAddAprtmntsgPg;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-included-amenity']")]
        public IWebElement FieldInputSearchForDefaultIncludedInMonthlyRentAmenitiesAddAprtmntsgPg;

        #endregion

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@text = 'Next']")]
        public IWebElement ButtonGeneralNextAddAprtmntsgPg;

        #endregion
    }
}
