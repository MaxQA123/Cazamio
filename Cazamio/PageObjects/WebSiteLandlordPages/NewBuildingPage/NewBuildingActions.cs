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
            Button.Click(ButtonSelectPeymentsMethodsNwBldngPg);
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

        private static IWebElement _element;

        [AllureStep("SelectorTabsOnNewBuildingsPg")]
        public static IList<IWebElement> SelectorTabsOnNewBuildingsPg(string _locationTab)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'wizard-navigation']//ul";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//li//a[contains(@role, '{_locationTab}')]"));
        }

        [AllureStep("SelectTabOnNewBuildingsPg")]
        public NewBuilding SelectTabOnNewBuildingsPg(int tab, string locationTab)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _tab = SelectorTabsOnNewBuildingsPg(locationTab);

            _tab[tab].Click();

            return this;
        }

    }
}
