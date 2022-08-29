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
        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonDropDownYearMonth;
    }
}
