using CazamioProgect.Helpers;
using CazamioProject.Helpers.CustomEnums.LocatorEnums;
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
        public static IWebElement Write(this IWebElement element, string text)
        {
            element.SendKeys(text);
            return element;
        }

        public static IWebElement Erase(this IWebElement element)
        {
            element.Clear();
            return element;
        }
        public static IWebElement ClearWithJs(this IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.Driver;
            js.ExecuteScript("arguments[0].value = '';", element);
            return element;
        }

        public static IWebElement Press(this IWebElement element)
        {
            element.Click();
            return element;
        }




        public static string GetValue(this IWebElement element, int seconds = 10) => element.WaitUntilVisible(seconds).GetAttribute("value");
        public static string GetText(this IWebElement element, int seconds = 10) => element.WaitUntilVisible(seconds).Text;
        public static string GetHref(this IWebElement element) => element.GetAttribute("href");
        public static string GetTrimmedText(this IWebElement element) => element.WaitUntilVisible().Text.Trim();

        public static string Substring(this IWebElement element, string specificSymbols)
        {
            string text = element.WaitUntilVisible().Text.Trim();
            int index = text.IndexOf(specificSymbols);
            int length = specificSymbols.Length;
            string result = text.Substring(index + length);
            return result;
        }






        public static IWebElement SelectOption(this IWebElement element, string value, Tags tags = Tags.Span)
        {
            element.WaitUntilClickable().Press().WaitMilliseconds();
            string tag = string.Empty;
            switch (tags)
            {
                case Tags.Span: tag = "span"; break;
                case Tags.Div: tag = "div"; break;
                case Tags.Label: tag = "label"; break;
                case Tags.Any: tag = "any"; break;
            }

            By option = By.XPath($".//*[@role='listbox']//div[@role='option']//{tag}[contains(text(), '{value}')]");
            WaitUntil.WaitLocator(option, 40);

            element
                .FindElement(option)
                .Press();

            return element;
        }
    }
}
