﻿using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            WaitUntil.WaitSomeInterval(250);
            element.Click();
        }
    }

    public class KeyBoardActions
    {
        //[AllureStep("InputFunctionWithoutClearSec")]
        //public static void InputFunctionWithoutClearSec(IWebElement element)
        //{
        //    WaitUntil.ElementIsClickable(element);
        //    element.SendKeys(Keys.Enter);
        //}

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
    }

}
