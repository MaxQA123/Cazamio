using CazamioProgect.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers
{
    public static partial class SeleniumExtensions
    {
        public static IWebElement WaitSeconds(this IWebElement element, int seconds = 2)
        {
            WaitUntil.WaitSeconds(seconds);
            return element;
        }

        public static IWebElement WaitMilliseconds(this IWebElement element, int milliseconds = 500)
        {
            WaitUntil.WaitMilliseconds(milliseconds);
            return element;
        }
        public static IWebElement WaitUntilClickable(this IWebElement element, int seconds = 10)
        {
            WaitUntil.ToBeClickable(element, seconds);
            return element;
        }
        public static IWebElement WaitUntilVisible(this IWebElement element, int seconds = 10)
        {
            WaitUntil.ToBeVisible(element, seconds);
            return element;
        }
        public static IWebElement WaitUntilHidden(this IWebElement element, int seconds = 10)
        {
            WaitUntil.ToBeHidden(element, seconds);
            return element;
        }

        public static IWebElement WaitLoaderIsHidden(this IWebElement element, int seconds = 10)
        {
            IWebElement webElement = Browser.Driver.FindElement(By.CssSelector("div.loader-overlay div.load"));
            WaitUntil.ToBeHidden(webElement, seconds);
            return element;
        }

        public static IWebElement WaitLoaderIsVisibleThenHidden(this IWebElement element, int seconds = 10)
        {
            IWebElement webElement = Browser.Driver.FindElement(By.CssSelector("div.loader-overlay div.load"));
            WaitUntil.ToBeVisible(webElement, seconds);
            WaitUntil.ToBeHidden(webElement, seconds);
            return element;
        }

        public static IList<IWebElement> WaitAtLeastOneElementVisible(this IList<IWebElement> elements, int seconds = 10)
        {
            WaitUntil.WaitForAtLeastOneElementVisible(elements, seconds);
            return elements;
        }
    }
}
