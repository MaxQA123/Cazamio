using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class WaitUntil
    {
        public static void ShouldLocate(By location)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(60)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(location));
        }

        public static void ElementIsClickable(IWebElement element, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void CustomElementIsClickable(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);

            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            while (DateTime.Now < endTime)
            {
                try
                {
                    if (ExpectedConditions.ElementToBeClickable(element).Invoke(Browser._Driver) != null)
                    {
                        return; // элемент кликабельный
                    }
                }
                catch (NoSuchElementException)
                {
                    // Обработка исключения или прокидывание дальше
                }
                catch (StaleElementReferenceException)
                {
                    // Обработка исключения или прокидывание дальше
                }

                Thread.Sleep(100); // подождать 100 миллисекунд перед следующей проверкой
            }

            // Если элемент так и не стал кликабельным в течение указанного времени
            // Обработка или выброс исключения
        }

        public static void WaitSomeInterval(int milliSeconds)
        {
            Task.Delay(TimeSpan.FromMilliseconds(milliSeconds)).Wait();
        }

        public static void ElementIsVesible(By element, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(element));
        }

        public static void CustomElementIsVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
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
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }

                });
            }
            catch (NoSuchElementException) { }
            catch (StaleElementReferenceException) { }
        }

        public static void SuccessCustomElementIsVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (element.Enabled == true)
                        {
                            Console.WriteLine(element.Text);

                            return true;
                        }
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }

                });
            }
            catch (NoSuchElementException) { }
            catch (StaleElementReferenceException) { }
        }

        public static void CustomElementIsInVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (element.Enabled == false)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        return true;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return true;
                    }

                });
            }
            catch (NoSuchElementException) { }
            catch (StaleElementReferenceException) { }
        }

        public static void WaitForElementToDisappear(IWebElement element, int seconds = 10)
        {
            Task.Delay(TimeSpan.FromMilliseconds(550)).Wait();
            IWait<IWebDriver> wait = new DefaultWait<IWebDriver>(Browser._Driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(100),
                Message = $"The search element is still visible after {seconds} sec"
            };
            try
            {
                wait.Until(driver =>
                {
                    try
                    {
                        if (element.Enabled == false || element.Displayed == false)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (Exception) { return true; }
                });
                Task.Delay(TimeSpan.FromMilliseconds(350)).Wait();
            }
            catch (Exception) { throw new ArgumentException(wait.Message); }
        }

        public static void WaitSeconds(int seconds = 2) => Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        public static void WaitMilliseconds(int milliseconds = 500) => Task.Delay(TimeSpan.FromMilliseconds(milliseconds)).Wait();


        public static void ToBeVisible(IWebElement element, int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).
                Until(Expected.ElementIsVisible(element));

        public static void ToBeClickable(IWebElement element, int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).
                Until(ExpectedConditions.ElementToBeClickable(element));

        public static void ToBeVisibleByLocator(By locator, int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).
                Until(ExpectedConditions.ElementIsVisible(locator));

        public static void ToBeHidden(IWebElement element, int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).
                Until(Expected.ElementIsInvisible(element));

        public static void ContainsText(IWebElement element, string value, int seconds = 10)
        {
            WebDriverWait wait = new(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(Expected.ElementTextIsEqualTo(element, value));
        }

        public static void ContainsValue(IWebElement element, string value, int seconds = 10)
        {
            WebDriverWait wait = new(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(Expected.ElementValueIsEqualTo(element, value));
        }





        public static WebDriverWait WaitDriver(int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));






        public static IWebElement VisibleThenHidden(IWebElement element, int seconds = 10)
        {
            ToBeVisible(element, seconds);
            ToBeHidden(element, seconds);
            return element;
        }



        public static void RowsNumberIs(int count, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).
                Until(x => x.FindElements(By.XPath("//table/tbody/tr")).Count == count);
        }



        public static void WaitLocator(By locator, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).
               Until(ExpectedConditions.ElementToBeClickable(locator));
        }


        public static void WaitForAtLeastOneElementVisible(IList<IWebElement> elements, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver =>
            {
                foreach (var element in elements)
                {
                    try
                    {
                        if (element.Displayed)
                        {
                            return true;
                        }
                    }
                    catch (NoSuchElementException) { }
                }
                return false;
            });
        }

        public static bool WaitForElementToBeAbsent(By locator, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            try
            {
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
                return true;
            }
            catch (NoSuchElementException)
            {
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}
