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
        private static IWebElement _element;

        [AllureStep("SelectorDaysPickerDaysFirstWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysFirstWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-3']//tbody[@class = 'mat-calendar-body']//tr[2]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysSecondWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysSecondWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-3']//tbody[@class = 'mat-calendar-body']//tr[3]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysThirdWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysThirdWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-3']//tbody[@class = 'mat-calendar-body']//tr[4]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysFourthWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysFourthWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-3']//tbody[@class = 'mat-calendar-body']//tr[5]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectorDaysPickerDaysFivethWeek")]
        public static IList<IWebElement> SelectorDaysPickerDaysFivethWeek(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id = 'cdk-overlay-3']//tbody[@class = 'mat-calendar-body']//tr[6]";
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
    }
}
