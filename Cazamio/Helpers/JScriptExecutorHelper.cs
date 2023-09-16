using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        public void OpenPutsBox(IWebElement element, string partEmailPutsBox)
        {
            WaitUntil.WaitSomeInterval(1000);
            WebDriverWait wait = new(Browser._Driver, TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromSeconds(2);
            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (element.Enabled == true)
                        {

                            return true;
                        }

                        return false;

                    }
                    catch (Exception)
                    {
                        Browser._Driver.Navigate().GoToUrl(($"https://putsbox.com/{partEmailPutsBox}/inspect"));

                        return false;
                    }
                });
            }
            catch (NoSuchElementException) { }

            catch (StaleElementReferenceException) { }
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
        public static IWebElement ClickOnHiddenElement(IWebElement hiddenElement)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver.FindElement(By.Id("ID_OF_ELEMENT"));
            js.ExecuteScript("аргументы[0].click();", hiddenElement);

            return hiddenElement;
        }

    }
    
}
