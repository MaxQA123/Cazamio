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

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Original ZIP Manhattan Creator Chui Assigned Martin']"))]
        public IWebElement ButtonBuildingNameAddApartmentsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'unit']"))]
        public IWebElement FieldInputUnitNumberAddAprtmntsUnitsPage;

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

        #endregion
    }
}
