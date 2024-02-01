using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static void ElementVisibileAndClickable(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (NoSuchElementException)
            {
                // Обработка исключения или прокидывание дальше
            }
            catch (StaleElementReferenceException)
            {
                // Обработка исключения или прокидывание дальше
            }
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
    }
}
