using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers.Base
{
    public class SpanButton : By
    {
        public SpanButton(string locator)
        {
            FindElementMethod = (context) => context.FindElement(XPath($"//span[text()='{locator}']/ancestor::button"));
        }
    }

    public class AnyFormControlName : By
    {
        public AnyFormControlName(string locator)
        {
            FindElementMethod = (context) => context.FindElement(XPath($"//*[@formcontrolname='{locator}']"));
        }
    }

    public class InputFormControlName : By
    {
        public InputFormControlName(string locator)
        {
            FindElementMethod = (context) => context.FindElement(XPath($"//input[@formcontrolname='{locator}']"));
        }
    }

    public class CazamioButton : By
    {
        public CazamioButton(string locator)
        {
            FindElementMethod = (context) => context.FindElement(XPath($"//cazamio-button[@text='{locator}']/button"));
        }
    }

    public class ButtonWithText : By
    {
        public ButtonWithText(string locator)
        {
            FindElementMethod = (context) => context.FindElement(XPath($"//span[text()='{locator}']/ancestor::button"));
        }
    }
}
