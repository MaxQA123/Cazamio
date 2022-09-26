using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class JScriptExecutorHelper
    {
        [AllureStep("OpenNewTab")]
        public JScriptExecutorHelper OpenNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.open();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.Last());

            return this;
        }

        [AllureStep("CloseNewTab")]
        public JScriptExecutorHelper CloseNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.close();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.First());

            return this;
        }
    }

    public class ScrollingJScriptExecutorHelper
    {
        [AllureStep("ScrollToElement")]
        public static IWebElement ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

            return element;
        }

        [AllureStep("ScrollToDownWebPage")]
        public static void ScrollToDownWebPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
        }

        [AllureStep("ScrollToUpWebPage")]
        public static void ScrollToUpWebPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("window.scrollBy(0, -1500)");
        }
    }

    public class ButtonJScriptExecutorHelper
    {
        //public JScriptExecutorHelper ClickOnHiddenElement()
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
        //    js.ExecuteScript("arguments[0].scrollIntoView();", element);

        //    WebElement hiddenElement = Browser._Driver.FindElement(By.Id("ID_OF_ELEMENT")); 
        //    jscriptExecutor.executeScript("аргументы[0].click();", hiddenElement);

        //}

        public static IWebElement ClickOnHiddenElement(IWebElement hiddenElement)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver.FindElement(By.Id("ID_OF_ELEMENT"));
            js.ExecuteScript("аргументы[0].click();", hiddenElement);

            return hiddenElement;
        }

    }
    
}
