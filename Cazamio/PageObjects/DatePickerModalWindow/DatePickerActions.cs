using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.DatePickerModalWindow
{
    public partial class DatePicker
    {
        [AllureStep("ClickButtonDropDownYearMonth")]
        public DatePicker ClickButtonDropDownYearMonth()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonDropDownYearMonth);

            return this;
        }

        [AllureStep("ClickButtonArrowPreviousYear")]
        public DatePicker ClickButtonArrowPreviousYear()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonArrowPreviousYear);

            return this;
        }

        [AllureStep("ClickButtonArrowNextYear")]
        public DatePicker ClickButtonArrowNextYear()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonArrowNextYear);

            return this;
        }

        [AllureStep("ClickButtonArrowNextMonth")]
        public DatePicker ClickButtonArrowNextMonth()
        {
            WaitUntil.CustomElementIsVisible(ButtonArrowNextMonth, 10);
            Button.Click(ButtonArrowNextMonth);

            return this;
        }

        #region SelectDay

        private static IWebElement _element;

        [AllureStep("SelectorDaysPickerDaysFirstLine")]
        public static IList<IWebElement> SelectorDaysPickerDaysFirstLine(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//table//tbody[@class = 'mat-calendar-body']//tr[1]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@aria-label, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysSecondLine")]
        public static IList<IWebElement> SelectorDaysPickerDaysSecondLine(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//table//tbody[@class = 'mat-calendar-body']//tr[2]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@aria-label, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysThirdLine")]
        public static IList<IWebElement> SelectorDaysPickerDaysThirdLine(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//table//tbody[@class = 'mat-calendar-body']//tr[3]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@aria-label, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysFourthLine")]
        public static IList<IWebElement> SelectorDaysPickerDaysFourthLine(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//table//tbody[@class = 'mat-calendar-body']//tr[4]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@aria-label, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysFivethLine")]
        public static IList<IWebElement> SelectorDaysPickerDaysFivethLine(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//table//tbody[@class = 'mat-calendar-body']//tr[5]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@aria-label, '{_locationDay}')]"));
        }

        [AllureStep("SelectDayOnDatePickerFirstLine")]
        public DatePicker SelectDayOnDatePickerFirstLine(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysFirstLine(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerSecondLine")]
        public DatePicker SelectDayOnDatePickerSecondLine(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysSecondLine(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerThirdLine")]
        public DatePicker SelectDayOnDatePickerThirdLine(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysThirdLine(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerFourthLine")]
        public DatePicker SelectDayOnDatePickerFourthLine(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysFourthLine(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerFivethLine")]
        public DatePicker SelectDayOnDatePickerFivethLine(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysFivethLine(locationDay);

            _day[day].Click();

            return this;
        }

        #endregion

        #region SelectYear

        [AllureStep("SelectorYearsPickerYearsFirstLine")]
        public static IList<IWebElement> SelectorYearsPickerYearsFirstLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-multi-year-view[@class = 'ng-star-inserted']//tbody[@class = 'mat-calendar-body']//tr";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectorYearsPickerYearsSecondLine")]
        public static IList<IWebElement> SelectorYearsPickerYearsSecondLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-multi-year-view[@class = 'ng-star-inserted']//tbody[@class = 'mat-calendar-body']//tr[2]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectorYearsPickerYearsThirdLine")]
        public static IList<IWebElement> SelectorYearsPickerYearsThirdLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-multi-year-view[@class = 'ng-star-inserted']//tbody[@class = 'mat-calendar-body']//tr[3]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectorYearsPickerYearsFourthLine")]
        public static IList<IWebElement> SelectorYearsPickerYearsFourthLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-multi-year-view[@class = 'ng-star-inserted']//tbody[@class = 'mat-calendar-body']//tr[4]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectorYearsPickerYersFivethLine")]
        public static IList<IWebElement> SelectorYearsPickerYersFivethLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-multi-year-view[@class = 'ng-star-inserted']//tbody[@class = 'mat-calendar-body']//tr[5]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectorYearsPickerYearsFivethLine")]
        public static IList<IWebElement> SelectorYearsPickerYearsSixthLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-multi-year-view[@class = 'ng-star-inserted']//tbody[@class = 'mat-calendar-body']//tr[6]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectYearsPickerYearsFirstLine")]
        public DatePicker SelectYearsPickerYearsFirstLine(int year, string locationYear)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _year = SelectorYearsPickerYearsFirstLine(locationYear);

            _year[year].Click();

            return this;
        }

        [AllureStep("SelectYearsPickerYearsSecondLine")]
        public DatePicker SelectYearsPickerYearsSecondLine(int year, string locationYear)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _year = SelectorYearsPickerYearsSecondLine(locationYear);

            _year[year].Click();

            return this;
        }

        [AllureStep("SelectYearsPickerYearsThirdLine")]
        public DatePicker SelectYearsPickerYearsThirdLine(int year, string locationYear)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _year = SelectorYearsPickerYearsThirdLine(locationYear);

            _year[year].Click();

            return this;
        }

        [AllureStep("SelectYearsPickerYearsFourthLine")]
        public DatePicker SelectYearsPickerYearsFourthLine(int year, string locationYear)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _year = SelectorYearsPickerYearsFourthLine(locationYear);

            _year[year].Click();

            return this;
        }

        [AllureStep("SelectYearsPickerYersFivethLine")]
        public DatePicker SelectYearsPickerYersFivethLine(int year, string locationYear)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _year = SelectorYearsPickerYersFivethLine(locationYear);

            _year[year].Click();

            return this;
        }

        [AllureStep("SelectYearsPickerYearsSixthLine")]
        public DatePicker SelectYearsPickerYearsSixthLine(int year, string locationYear)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _year = SelectorYearsPickerYearsSixthLine(locationYear);

            _year[year].Click();

            return this;
        }

        #endregion

        #region SelectMonth

        [AllureStep("SelectorMonthPickerMonthFirstLine")]
        public static IList<IWebElement> SelectorMonthPickerMonthFirstLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-year-view//tbody//tr[2]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectorMonthPickerMonthSecondLine")]
        public static IList<IWebElement> SelectorMonthPickerMonthSecondLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-year-view//tbody//tr[3]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectorMonthPickerMonthThirdLine")]
        public static IList<IWebElement> SelectorMonthPickerMonthThirdLine(string _locationYear)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//mat-year-view//tbody//tr[4]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationYear}')]"));
        }

        [AllureStep("SelectMonthPickerMonthFirstLine")]
        public DatePicker SelectMonthPickerMonthFirstLine(int month, string locationMonth)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _month = SelectorMonthPickerMonthFirstLine(locationMonth);

            _month[month].Click();

            return this;
        }

        [AllureStep("SelectMonthPickerMonthSecondtLine")]
        public DatePicker SelectMonthPickerMonthSecondtLine(int month, string locationMonth)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _month = SelectorMonthPickerMonthSecondLine(locationMonth);

            _month[month].Click();

            return this;
        }

        [AllureStep("SelectMonthPickerMonthThirdLine")]
        public DatePicker SelectMonthPickerMonthThirdLine(int month, string locationMonth)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _month = SelectorMonthPickerMonthThirdLine(locationMonth);

            _month[month].Click();

            return this;
        }

        #endregion
    }
}
