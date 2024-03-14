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

        public static IWebElement FindXPath(this IWebElement element, Tags tag, string condition) =>
            element.FindElement(By.XPath($".//{tag}[{condition}]"));

        public static IWebElement FindXPath(this IWebElement element, Tags tag) =>
            element.FindElement(By.XPath($".//{tag}"));

        public static IWebElement FindXPath(this IWebElement element, Tags tag, int index) =>
            element.FindElement(By.XPath($".//{tag}[{index}]"));

        public static IWebElement FindXPath(this IWebElement element, string condition) =>
            element.FindElement(By.XPath($".{condition}"));





        public static IList<IWebElement> FindXPaths(this IWebElement element, Tags tag, string condition) =>
            element.FindElements(By.XPath($".//{tag}[{condition}]"));

        public static IList<IWebElement> FindXPaths(this IWebElement element, Tags tag) =>
            element.FindElements(By.XPath($".//{tag}"));

        public static IList<IWebElement> FindXPaths(this IWebElement element, Tags tag, int index) =>
            element.FindElements(By.XPath($".//{tag}[{index}]"));


    }
}
