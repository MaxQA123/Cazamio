using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.IO;
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
            InputGeneral.InputFunctionWithClear(FieldInputDescroptionNwBldngPg, TestDataForWebSiteAdmin.DESCRIPTION_NEW_BUILDING + GeneralTestDataForAllUsers.TEXT_LOREM);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotesNwBldngPg, TestDataForWebSiteAdmin.INTERNAL_NOTES_NEW_BUILDING + GeneralTestDataForAllUsers.TEXT_LOREM);

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

        #region Access

        [AllureStep("ClickButtonAddLockForAccessNwBldngPg")]
        public NewBuilding ClickButtonAddLockForAccessNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddLockForAccessNwBldngPg, 10);
            Button.Click(ButtonAddLockForAccessNwBldngPg);

            return this;
        }

        [AllureStep("AddItemAccessTypePinCodeForAccessNwBldngPg")]
        public NewBuilding AddItemAccessTypePinCodeForAccessNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAccessTypeForAccessNwBldngPg, 10);
            Button.Click(ButtonAccessTypeForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPinCodeForAccessNwBldngPg, GenerateRandomDataHelper.RandomNumber(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForAccessNwBldngPg, GenerateRandomDataHelper.RandomNumber(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForAccessNwBldngPg, GenerateRandomDataHelper.RandomNumber(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForAccessNwBldngPg, GenerateRandomDataHelper.RandomNumber(1));
            KeyBoardActions.ClickSpaceButton();
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccessNwBldngPg, GeneralTestDataForAllUsers.TEXT_LOREM);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccessNwBldngPg.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_LOCK_OK));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CheckBoxTimeRestrictionEnabledForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForAccessNwBldngPg);

            return this;
        }

        [AllureStep("AddItemAccessTypeNoteForAccessNwBldngPg")]
        public NewBuilding AddItemAccessTypeNoteForAccessNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAccessTypeForAccessNwBldngPg, 10);
            Button.Click(ButtonAccessTypeForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccessNwBldngPg, GeneralTestDataForAllUsers.TEXT_LOREM);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccessNwBldngPg.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_LOCK_OK));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CheckBoxTimeRestrictionEnabledForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForAccessNwBldngPg);

            return this;
        }

        [AllureStep("AddItemAccessTypeCabForAccessNwBldngPg")]
        public NewBuilding AddItemAccessTypeCabForAccessNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAccessTypeForAccessNwBldngPg, 10);
            InputGeneral.InputFunctionWithClear(FieldInputLocationForAccessNwBldngPg, TestDataForWebSiteAdmin.THIRD_NAME_LOCATION);
            Button.Click(ButtonAccessTypeForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLockGuideForAccessNwBldngPg, GenerateRandomDataHelper.RandomNumber(5));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccessNwBldngPg, GeneralTestDataForAllUsers.TEXT_LOREM);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccessNwBldngPg.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_LOCK_OK));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CheckBoxTimeRestrictionEnabledForAccessNwBldngPg);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForAccessNwBldngPg);

            return this;
        }

        #endregion

        #region Specials

        [AllureStep("ClickButtonAddSpecialsNwBldngPg")]
        public NewBuilding ClickButtonAddSpecialsNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddSpecialsNwBldngPg, 10);
            Button.Click(ButtonAddSpecialsNwBldngPg);

            return this;
        }

        [AllureStep("AddConcessionSpecialsNwBldngPg")]
        public NewBuilding AddConcessionSpecialsNwBldngPg()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecialsNwBldngPg, 10);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecialsNwBldngPg, TestDataForWebSiteAdmin.CONCESSION_NAME);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFreeSpecialsNwBldngPg, TestDataForWebSiteAdmin.CONCESSION_MONTHS_FREE);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTermsSpecialsNwBldngPg, TestDataForWebSiteAdmin.CONCESSION_LEASE_TERMS);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecialsNwBldngPg);

            return this;
        }

        #endregion

    }
}
