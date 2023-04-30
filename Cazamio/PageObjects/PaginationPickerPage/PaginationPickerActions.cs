using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.PaginationPickerPage
{
    public partial class PaginationPicker
    {
        private static IWebElement _element;

        [AllureStep("SelectorNumberPageListOfMarketplaceAdmins")]
        public static IList<IWebElement> SelectorNumberPageListOfMarketplaceAdmins(string _locationButton)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//ul[@role= 'navigation']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//li//a[contains(@tabindex, '{_locationButton}]')]"));
        }

        [AllureStep("SelectNumberPage")]
        public PaginationPicker SelectorNumberPageListOfMarketplaceAdmins(int page, string locationPage)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _page = SelectorNumberPageListOfMarketplaceAdmins(locationPage);

            _page[page].Click();

            return this;
        }

        [AllureStep("SctollToButtonNext")]
        public PaginationPicker SctollToButtonNext()
        {
            WaitUntil.WaitSomeInterval(1000);
            ScrollingJScriptExecutorHelper.ScrollToElement(ButtonNext);

            return this;
        }

        [AllureStep("ClickButtonLastNumberPage")]
        public PaginationPicker ClickButtonLastNumberPage()
        {
            WaitUntil.WaitSomeInterval(250);
            Button.Click(ButtonLastNumberPage);

            return this;
        }

        [AllureStep("ClickButtonNextOnce")]
        public PaginationPicker ClickButtonNextOnce()
        {
            WaitUntil.WaitSomeInterval(250);
            Button.Click(ButtonNext);

            return this;
        }

        [AllureStep("ClickButtonNextTwice")]
        public PaginationPicker ClickButtonNextTwice()
        {
            WaitUntil.WaitSomeInterval(250);
            Button.Click(ButtonNext);
            WaitUntil.WaitSomeInterval(250);
            Button.Click(ButtonNext);

            return this;
        }

        [AllureStep("ClickButtonNextThree")]
        public PaginationPicker ClickButtonNextThree()
        {
            WaitUntil.WaitSomeInterval(250);
            Button.Click(ButtonNext);
            WaitUntil.WaitSomeInterval(250);
            Button.Click(ButtonNext);
            WaitUntil.WaitSomeInterval(250);
            Button.Click(ButtonNext);

            return this;
        }
    }
}
