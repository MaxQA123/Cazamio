using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.DatePickerModalWindow
{
    public partial class DatePicker
    {
        [FindsBy(How = How.XPath, Using = "//mat-datepicker-content//span[@class = 'mat-button-wrapper']")]
        public IWebElement ButtonDropDownYearMonth;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label = 'Previous year']")]
        public IWebElement ButtonArrowPreviousYear;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label = 'Next year']")]
        public IWebElement ButtonArrowNextYear;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label = 'Next month']")]
        public IWebElement ButtonArrowNextMonth;
    }
}
