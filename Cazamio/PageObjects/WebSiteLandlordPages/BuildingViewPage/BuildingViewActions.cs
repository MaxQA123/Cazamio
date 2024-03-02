using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.BuildingViewPage
{
    public partial class BuildingView
    {
        #region TabsLine

        [AllureStep("ClickTabApartments")]
        public BuildingView ClickTabApartments()
        {
            WaitUntil.CustomElementIsVisible(TabApartmentsBldngVwPg);
            WaitUntil.CustomElementIsClickable(TabApartmentsBldngVwPg);
            Button.Click(TabApartmentsBldngVwPg);

            return this;
        }

        [AllureStep("GetValueFromFieldNotInputAddress")]
        public string GetValueFromFieldNotInputAddress()
        {
            WaitUntil.CustomElementIsVisible(FieldNotInputAddress);
            string getValue = FieldNotInputAddress.Text;
            string getValueActual = getValue.ToString();

            return getValueActual;
        }

        [AllureStep("GetValueFromFieldNotInputBuildingName")]
        public string GetValueFromFieldNotInputBuildingName()
        {
            WaitUntil.CustomElementIsVisible(FieldNotInputBuildingName);
            string getValue = FieldNotInputBuildingName.Text;
            string getValueActual = getValue.ToString();

            return getValueActual;
        }

        #endregion

        #region InTabApartments

        [AllureStep("ClickButtonAddInTabApartments")]
        public BuildingView ClickButtonAddInTabApartments()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddInTabApartments);
            WaitUntil.CustomElementIsClickable(ButtonAddInTabApartments);
            Button.Click(ButtonAddInTabApartments);

            return this;
        }

        [AllureStep("SelectUnitFourInTabApartmentsBldngVwPg")]
        public BuildingView SelectUnitFourInTabApartmentsBldngVwPg()
        {
            WaitUntil.CustomElementIsVisible(UnitFourInTabApartmentsBldngVwPg);
            Button.Click(UnitFourInTabApartmentsBldngVwPg);

            return this;
        }

        //private static IWebElement _element;

        //[AllureStep("SelectorDaysPickerDaysFirstLine")]
        //public static IList<IWebElement> SelectorUnitsListOfUnits(string _locationUnit)
        //{
        //    WaitUntil.WaitSomeInterval(1000);
        //    var str = "//table//tbody";
        //    _element = Browser._Driver.FindElement(By.XPath(str));
        //    return _element.FindElements(By.XPath($".//table//tbody//tr[@ng-reflect-router-link = '/apartments/apartment-view/537']//td"));
        //    //tr[contains(@ng-reflect-router-link, '{_locationDay}')]
        //}

        //[AllureStep("SelectUnitFromListOfUnits")]
        //public BuildingView SelectUnitFromListOfUnits(int unit, string locationUnit)
        //{
        //    WaitUntil.WaitSomeInterval(500);
        //    IList<IWebElement> _unit = SelectorUnitsListOfUnits(locationUnit);

        //    _unit[unit].Click();

        //    return this;
        //}

        #endregion
    }
}
