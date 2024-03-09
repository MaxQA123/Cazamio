using CazamioProgect.Helpers;
using CazamioProject.Objects;
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

        public IWebElement ItemFullNameAgent;

        public IWebElement SetItemAgent()
        {
            // Создание экземпляра класса Owner
            Agent agent = new Agent().Generate();

            // Использование переменной экземпляра owner для построения XPath
            var xpath = "//span[text() = '" + agent.FullNameAgent + "']";

            // Присвоение значения ItemForAutotestForBroker
            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        [FindsBy(How = How.XPath, Using = ("//ng-select[@bindlabel = 'buildingName']//div[@aria-haspopup = 'listbox']"))]
        public IWebElement ButtonBuildingNameAddApartmentsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'unit']"))]
        public IWebElement FieldInputUnitNumber;

        [FindsBy(How = How.XPath, Using = ("//div[@aria-selected = 'true']//span"))]
        public IWebElement GetValueFromFieldBuildingName;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'bedrooms']"))]
        public IWebElement FieldInputBedrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'half-bedrooms']"))]
        public IWebElement FieldInputHalfBedrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'bathrooms']"))]
        public IWebElement FieldInputBathrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'half-bathrooms']"))]
        public IWebElement FieldInputHalfBathrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'sqFoot']"))]
        public IWebElement FieldInputSqFoot;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'leastPrice']"))]
        public IWebElement FieldInputLeasePrice;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'depositPrice']"))]
        public IWebElement FieldInputSecurityDeposit;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'paidMonths']"))]
        public IWebElement FieldInputMonthlyRentsPrePayment;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'floor']"))]
        public IWebElement FieldInputFloor;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'status']"))]
        public IWebElement ButtonApartmentStatus;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'status']//div[@aria-selected= 'true']//span"))]
        public IWebElement InputStatus;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Off market']"))]
        public IWebElement ItemOffMarket;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Occupied']"))]
        public IWebElement ItemOccupied;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Vacant']"))]
        public IWebElement ItemVacant;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Deposit received']"))]
        public IWebElement ItemDepositReceived;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Application submitted']"))]
        public IWebElement ItemApplicationSubmitted;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Signed lease']"))]
        public IWebElement ItemSignedLease;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'broker']"))]
        public IWebElement ButtonAssignedAgent;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'availableFrom']"))]
        public IWebElement FieldInputAvailableFrom;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'apartmentType']"))]
        public IWebElement ButtonApartmentType;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'MultiFamily']"))]
        public IWebElement ItemMultiFamily;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'SingleFamily']"))]
        public IWebElement ItemSingleFamily;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'Duplex']"))]
        public IWebElement ItemDuplex;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'Plex']"))]
        public IWebElement ItemPlex;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'Loft']"))]
        public IWebElement ItemLoft;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'holdingDeposit']"))]
        public IWebElement FieldInputApartmentHoldDeposit;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Set default']"))]
        public IWebElement ButtonSetDefault;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Payment methods']"))]
        public IWebElement ButtonPaymentMethods;

        [FindsBy(How = How.XPath, Using = ("//mat-chip-list[@id = 'mat-chip-list-1']"))]
        public IWebElement FieldInputRentalTerms;

        [FindsBy(How = How.XPath, Using = ("//mat-chip[text() =  ' 12 months ']"))]
        public IWebElement ItemTwelveMonthsRentalTerms;

        #region RequiredDocuments

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' 3 Recent paystubs ']"))]
        public IWebElement ItemThreeRecentPaystubs;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' Photo ID ']"))]
        public IWebElement ItemPhotoIdPaystubs;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' 2 Most recent bank statements ' ]"))]
        public IWebElement ItemTwoMostRecentBankStatements;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//span[text() = ' Most recent W-2 or 1099 ' ]"))]
        public IWebElement ItemrMostRecentWTwoOrOneZeroNineNine;

        #endregion

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'description' ]"))]
        public IWebElement FieldInputDescription;

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'internalNotes' ]"))]
        public IWebElement FieldInputInternalNotes;

        #region Amenities

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-amenity']")]
        public IWebElement FieldInputSearchForAmenities;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-included-amenity']")]
        public IWebElement FieldInputSearchForDefaultIncludedInMonthlyRentAmenities;

        #endregion

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@text = 'Next']")]
        public IWebElement ButtonGeneralNext;

        #endregion
    }
}
