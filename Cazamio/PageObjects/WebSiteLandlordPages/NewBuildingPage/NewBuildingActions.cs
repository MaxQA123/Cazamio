using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        private static IWebElement _tabsForSwitchingOnPage;

        [AllureStep("SelectorTabsOnNewBuildingsPg")]
        public static IList<IWebElement> SelectorTabsOnNewBuildingsPg(string _locationTab)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'wizard-navigation']//ul";
            _tabsForSwitchingOnPage = Browser._Driver.FindElement(By.XPath(str));
            return _tabsForSwitchingOnPage.FindElements(By.XPath($".//li//a[contains(@role, '{_locationTab}')]"));
        }

        [AllureStep("SelectTabOnNewBuildingsPg")]
        public NewBuilding SelectTabOnNewBuildingsPg(int tab, string locationTab)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _tab = SelectorTabsOnNewBuildingsPg(locationTab);

            _tab[tab].Click();

            return this;
        }

        #region NewBuilding the tab Basic Details

        [AllureStep("ClickDropDownMenuBrokerSelect")]
        public NewBuilding ClickDropDownMenuBrokerSelect()
        {
            Button.Click(DropDownMenuBrokerSelect);
            KeyBoardActions.ClickEnterButton();

            return this;
        }

        [AllureStep("EnterMandatoryAddressNewBuilding")]
        public NewBuilding EnterMandatoryAddressNewBuilding()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddressNwBldngPg, TestDataForWebSiteAdmin.ADDRESS_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCityNwBldngPg, TestDataForWebSiteAdmin.CITY_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputStateNwBldngPg, TestDataForWebSiteAdmin.STATE_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZipNwBldngPg, TestDataForWebSiteAdmin.ZIP_BUILDING);

            return this;
        }

        [AllureStep("EnterAddressNewBuilding")]
        public NewBuilding EnterAddressNewBuilding()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddressNwBldngPg, TestDataForWebSiteAdmin.ADDRESS_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCityNwBldngPg, TestDataForWebSiteAdmin.CITY_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputStateNwBldngPg, TestDataForWebSiteAdmin.STATE_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZipNwBldngPg, TestDataForWebSiteAdmin.ZIP_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhoodNwBldngPg, TestDataForWebSiteAdmin.NEIGHBORHOOD_BUILDING);

            return this;
        }

        [AllureStep("EnterBuildingLlcNamesDescription")]
        public NewBuilding EnterBuildingLlcNamesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBuildingNameNwBldngPg, TestDataForWebSiteAdmin.BUILDING_NAME_NEW_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLlcNameNwBldngPg, TestDataForWebSiteAdmin.BUILDING_LLC_NAME_NEW_BUILDING);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroptionNwBldngPg, TestDataForWebSiteAdmin.DESCRIPTION_NEW_BUILDING + TestDataForWebSiteAdmin.TEXT_LOREM);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotesNwBldngPg, TestDataForWebSiteAdmin.INTERNAL_NOTES_NEW_BUILDING + TestDataForWebSiteAdmin.TEXT_LOREM);

            return this;
        }

        [AllureStep("ClickButtonSelectPetPolicies")]
        public NewBuilding ClickButtonSelectPetPolicies()
        {
            Button.Click(ButtonSelectPetPolicies);

            return this;
        }

        [AllureStep("EnterCreditScreeningFee")]
        public NewBuilding EnterCreditScreeningFee()
        {
            InputGeneral.InputFunctionWithClear(FieldInputCreditScreeningFee, GenerateRandomDataHelper.RandomNumber(2));

            return this;
        }

        [AllureStep("SelectPaymentsMethodsNwBldngPage")]
        public NewBuilding SelectPaymentsMethodsNwBldngPage()
        {
            Button.Click(ButtonSelectPaymentsMethodsNwBldngPg);
            Pages.ModalWindowPaymentOptions
                .VerifyTitlePaymentOptionsMdlWndwOptns();
            Pages.ModalWindowPaymentOptions
                .SelectPaymentsMethodsNwBldngPg();

            return this;
        }

        [AllureStep("ClickButtonGeneralNextNwBldngPg")]
        public NewBuilding ClickButtonGeneralNextNwBldngPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonGeneralNextNwBldngPg);

            return this;
        }

        #endregion

        #region Amenities

        [AllureStep("ClickFieldInputSearchForAmenitiesNwBldngPg")]
        public NewBuilding ClickFieldInputSearchForAmenitiesNwBldngPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(FieldInputSearchForAmenitiesNwBldngPg);

            return this;
        }

        private static IWebElement _elementAmenitiesForBuilding;

        [AllureStep("SelectorAmenitiesForBuilding")]
        public static IList<IWebElement> SelectorAmenitiesForBuilding(string _itemAmenity)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'search-choice-wrapper']";
            _elementAmenitiesForBuilding = Browser._Driver.FindElement(By.XPath(str));
            return _elementAmenitiesForBuilding.FindElements(By.XPath($".//div[contains(text(), '{_itemAmenity}')]"));
        }

        [AllureStep("SelectAmenitiesForBuilding")]
        public NewBuilding SelectAmenitiesForBuilding(int numberItem, string itemAmenity)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorAmenitiesForBuilding(itemAmenity);

            _numberItem[numberItem].Click();

            return this;
        }

        #endregion

        #region Amenities

        [AllureStep("ClickButtonAddLockForAccessNwBldngPg")]
        public NewBuilding ClickButtonAddLockForAccessNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddLockForAccessNwBldngPg, 10);
            Button.Click(ButtonAddLockForAccessNwBldngPg);

            return this;
        }

        [AllureStep("ClickButtonAccessTypeForAccessNwBldngPg")]
        public NewBuilding ClickButtonAccessTypeForAccessNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAccessTypeForAccessNwBldngPg, 10);
            Button.Click(ButtonAccessTypeForAccessNwBldngPg);

            return this;
        }

        private static IWebElement _itemAccessTypeForBuilding;

        [AllureStep("SelectorAmenitiesForBuilding")]
        public static IList<IWebElement> SelectorAccessTypeForBuilding(string _itemAccessType)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'ng-dropdown-panel-items scroll-host']";
            _itemAccessTypeForBuilding = Browser._Driver.FindElement(By.XPath(str));
            return _itemAccessTypeForBuilding.FindElements(By.XPath($".//span[contains(text(), '{_itemAccessType}')]"));
        }

        [AllureStep("SelectAmenitiesForBuilding")]
        public NewBuilding SelectAccessTypeForBuilding(int numberItem, string itemAccessType)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorAccessTypeForBuilding(itemAccessType);

            _numberItem[numberItem].Click();

            return this;
        }

        #endregion

    }
}
