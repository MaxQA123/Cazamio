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

        #region SelectDay

        private static IWebElement _element;

        [AllureStep("SelectorDaysPickerDaysFirstWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysFirstWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-container']//tbody[@class = 'mat-calendar-body']//tr[2]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysSecondWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysSecondWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'cdk-overlay-container']//tbody[@class = 'mat-calendar-body']//tr[3]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysThirdWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysThirdWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-container']//tbody[@class = 'mat-calendar-body']//tr[4]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysFourthWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysFourthWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-container']//tbody[@class = 'mat-calendar-body']//tr[5]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysFivethWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysFivethWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-container']//tbody[@class = 'mat-calendar-body']//tr[6]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectDayOnDatePickerFirstWeek")]
        public DatePicker SelectDayOnDatePickerFirstWeek(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysFirstWeek(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerSecondWeek")]
        public DatePicker SelectDayOnDatePickerSecondWeek(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysSecondWeek(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerThirdWeek")]
        public DatePicker SelectDayOnDatePickerThirdWeek(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysThirdWeek(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerFourthWeek")]
        public DatePicker SelectDayOnDatePickerFourthWeek(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysFourthWeek(locationDay);

            _day[day].Click();

            return this;
        }

        [AllureStep("SelectDayOnDatePickerFivethWeek")]
        public DatePicker SelectDayOnDatePickerFivethWeek(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorDaysPickerDaysFivethWeek(locationDay);

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
