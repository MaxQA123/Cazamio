using CazamioProgect.Helpers;
using CazamioProgect.PageObjects;
using CazamioProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        Building building = new Building().Generate();

        #region TabUnits     

        [AllureStep("EnterUnitNumberBedsBathsSqFoot")]
        public AddApartments EnterLeasePriceSecurityDeposit()
        //SecurityDeposit autofill
        {
            WaitUntil.CustomElementIsVisible(FieldInputLeasePriceAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePriceAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumberWithoutZero(4));

            return this;
        }

        [AllureStep("EnterFieldInputFloorAddAprtmntsUnitsPage")]
        public AddApartments EnterFieldInputFloorAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFloorAddAprtmntsUnitsPage, 10);
            InputGeneral.InputFunctionWithClear(FieldInputFloorAddAprtmntsUnitsPage, GenerateRandomDataHelper.RandomNumberWithoutZero(2));

            return this;
        }

        [AllureStep("ClickButtonPaymentMethodsAddAprtmntsUnitsPage")]
        public AddApartments ClickButtonPaymentMethodsAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(ButtonPaymentMethodsAddAprtmntsUnitsPage, 10);
            Button.Click(ButtonPaymentMethodsAddAprtmntsUnitsPage);
            
            return this;
        }

        #endregion

        #region TabAmenities

        [AllureStep("ClickFieldInputSearchForAmenitiesAddAprtmntsgPg")]
        public AddApartments ClickFieldInputSearchForAmenitiesAddAprtmntsgPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(FieldInputSearchForAmenitiesAddAprtmntsgPg);

            return this;
        }

        private static IWebElement _elementAmenitiesForApartment;

        [AllureStep("SelectorAmenitiesForBuilding")]
        public static IList<IWebElement> SelectorAmenitiesForApartment(string _itemAmenity)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'search-choice-wrapper']";
            _elementAmenitiesForApartment = Browser._Driver.FindElement(By.XPath(str));
            return _elementAmenitiesForApartment.FindElements(By.XPath($".//div[contains(text(), '{_itemAmenity}')]"));
        }

        [AllureStep("SelectAmenitiesForBuilding")]
        public AddApartments SelectAmenitiesForApartment(int numberItem, string itemAmenity)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorAmenitiesForApartment(itemAmenity);

            _numberItem[numberItem].Click();

            return this;
        }

        [AllureStep("ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenitiesAddAprtmntsgPg")]
        public AddApartments ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenitiesAddAprtmntsgPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(FieldInputSearchForDefaultIncludedInMonthlyRentAmenitiesAddAprtmntsgPg);

            return this;
        }

        private static IWebElement _elementDefaultIncludedInMonthlyRentAmenitiesForApartment;

        [AllureStep("SelectorIncludedInMonthlyRentAmenitiesForApartmentForApartment")]
        public static IList<IWebElement> SelectorIncludedInMonthlyRentAmenitiesForApartmentForApartment(string _itemAmenity)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'search-choice-wrapper']";
            _elementDefaultIncludedInMonthlyRentAmenitiesForApartment = Browser._Driver.FindElement(By.XPath(str));
            return _elementDefaultIncludedInMonthlyRentAmenitiesForApartment.FindElements(By.XPath($".//div[contains(text(), '{_itemAmenity}')]"));
        }

        [AllureStep("SelectIncludedInMonthlyRentAmenitiesForApartmentForApartment")]
        public AddApartments SelectIncludedInMonthlyRentAmenitiesForApartmentForApartment(int numberItem, string itemAmenity)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorIncludedInMonthlyRentAmenitiesForApartmentForApartment(itemAmenity);

            _numberItem[numberItem].Click();

            return this;
        }

        #endregion

        [AllureStep("ClickButtonGeneralNextAddAprtmntsgPg")]
        public AddApartments ClickButtonGeneralNextAddAprtmntsgPg()
        {
            WaitUntil.WaitSomeInterval(3000);
            Button.Click(ButtonGeneralNextAddAprtmntsgPg);

            return this;
        }
    }
}
