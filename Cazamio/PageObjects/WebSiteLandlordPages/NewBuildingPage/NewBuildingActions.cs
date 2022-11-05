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
        [AllureStep("EnterMandatoryAddressNewBuilding")]
        public NewBuilding EnterMandatoryAddressNewBuilding()
        {
            InputGeneral.InputFunctionWithClear(FieldInputAddressNwBldngPg, Address.FullAddress());
            InputGeneral.InputFunctionWithClear(FieldInputCityNwBldngPg, Address.City());
            InputGeneral.InputFunctionWithClear(FieldInputStateNwBldngPg, Address.State());
            InputGeneral.InputFunctionWithClear(FieldInputZipNwBldngPg, Address.ZipCode());

            return this;
        }

        [AllureStep("EnterBuildingLlcNamesDescription")]
        public NewBuilding EnterBuildingLlcNamesDescription()
        {
            InputGeneral.InputFunctionWithClear(FieldInputBuildingNameNwBldngPg, TestDataForWebSiteAdmin.BUILDING_NAME);
            InputGeneral.InputFunctionWithClear(FieldInputLlcNameNwBldngPg, TestDataForWebSiteAdmin.BUILDING_LLC_NAME);
            InputGeneral.InputFunctionWithClear(FieldInputDescroptionNwBldngPg, Lorem.Sentence());
            InputGeneral.InputFunctionWithClear(FieldInputCreditScreeningFeeNwBldngPg, GenerateRandomDataHelper.RandomPriceCreditScreeningFee(2));

            return this;
        }

        [AllureStep("SelectPaymentsMethodsNwBldngPage")]
        public NewBuilding SelectPaymentsMethodsNwBldngPage()
        {
            Button.Click(ButtonSelectPeymentsMethodsNwBldngPg);
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
