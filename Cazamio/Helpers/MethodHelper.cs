using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimuTec.Faker;

namespace CazamioProgect.Helpers
{
    public class InputGeneral
    {
        [AllureStep("InputFunctionWithClear")]
        public static void InputFunctionWithClear(IWebElement element, string text)
        {
            WaitUntil.WaitSomeInterval(250);
            WaitUntil.ElementIsClickable(element);
            element.Clear();
            element.SendKeys(text);
        }

        [AllureStep("InputFunctionWithoutClear")]
        public static void InputFunctionWithoutClear(IWebElement element, string text)
        {
            WaitUntil.ElementIsClickable(element);
            element.SendKeys(text);
        }
    }

    public class Button
    {
        [AllureStep("Click")]
        public static void Click(IWebElement element)
        {
            WaitUntil.CustomElementIsVisible(element);
            WaitUntil.WaitSomeInterval(500);
            element.Click();
        }
    }

    public class KeyBoardActions
    {
        [AllureStep("ClickArrowUp")]
        public static void ClickArrowUp()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowUp)
                .Build()
                .Perform();
        }

        [AllureStep("ClickArrowDown")]
        public static void ClickArrowDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowDown)
                .Build()
                .Perform();
        }

        [AllureStep("ClickArrowLeft")]
        public static void ClickArrowLeft()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowLeft)
                .Build()
                .Perform();
        }

        [AllureStep("ClickArrowRight")]
        public static void ClickArrowRight()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowRight)
                .Build()
                .Perform();
        }

        [AllureStep("ClickEnterButton")]
        public static void ClickEnterButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
        }

        [AllureStep("ClickEscapeButton")]
        public static void ClickEscapeButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Escape)
                .Build()
                .Perform();
        }

        [AllureStep("ClickSpaceButton")]
        public static void ClickSpaceButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Space)
                .Build()
                .Perform();
        }

        [AllureStep("ScrollToElement")]
        public static void ScrollToElement(IWebElement element)
        {
            new Actions(Browser._Driver)
                .ScrollToElement(element)
                .Build()
                .Perform();
        }

        [AllureStep("ScrollToDown")]
        public static void ScrollToDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.End)
                .Build()
                .Perform();
        }

        [AllureStep("ScrollToUp")]
        public static void ScrollToUp()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Home)
                .Build()
                .Perform();
        }

        [AllureStep("ClickTab")]
        public static void ClickTab()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Tab)
                .Build()
                .Perform();
        }

        //[AllureStep("EnterData")]
        //public static void EnterData()
        //{
        //    new Actions(Browser._Driver)
        //        .SendKeys()
        //        .Build()
        //        .Perform();
        //}

        [AllureStep("ClickBackspace")]
        public static void ClickBackspace()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Backspace)
                .Build()
                .Perform();
        }

        [AllureStep("ClickInsert")]
        public static void ClickInsert()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Insert)
                .Build()
                .Perform();
        }

        [AllureStep("ClearValue")]
        public static void ClearValue()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Delete)
                .Build()
                .Perform();
        }
    }

    public class Errors
    {
        public static Boolean IsInvisible(IWebElement element)
        {
            WaitUntil.WaitSomeInterval(1000);
            try
            {
                if (element.Enabled == true)
                {
                    Console.WriteLine(element.Text);

                    return false;
                }

                return true;
                
                
            }
            catch (NoSuchElementException) { return true; }
            
            catch (StaleElementReferenceException) { return true; }
        }
    }

    public class Successfully
    {
        public static Boolean IsVisible(IWebElement element)
        {
            WaitUntil.WaitSomeInterval(1000);
            try
            {
                if (element.Enabled == true)
                {
                    Console.WriteLine(element.Text);

                    return true;
                }

                return false;


            }
            catch (NoSuchElementException) { return false; }

            catch (StaleElementReferenceException) { return false; }
        }
    }

    public class SuccessfullyTwo
    {
        public static Boolean IsVisible(IWebElement element)
        {
            WaitUntil.WaitSomeInterval(1000);
            try
            {
                if (element.Enabled == true)
                {
                    Console.WriteLine(element.GetAttribute("value"));

                    return true;
                }

                return false;


            }
            catch (NoSuchElementException) { return false; }

            catch (StaleElementReferenceException) { return false; }
        }
    }

    public class SwitchingTabs
    {
        public static void SwitchTabOne()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
        }
    }
}
