using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowPetPolicies
{
    public partial class ModalWindowPetPolicies
    {
        private static IWebElement _elementPetPolicies;

        [AllureStep("SelectorPetPolicies")]
        public static IList<IWebElement> SelectorPetPolicies(string _itemPetPolocie)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'select-values ng-star-inserted']";
            _elementPetPolicies = Browser._Driver.FindElement(By.XPath(str));
            return _elementPetPolicies.FindElements(By.XPath($".//li//span[contains(text(), '{_itemPetPolocie}')]"));
        }

        [AllureStep("SelectItemPetPolocies")]
        public ModalWindowPetPolicies SelectItemPetPolocies(int numberItem, string itemPetPolocie)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorPetPolicies(itemPetPolocie);

            _numberItem[numberItem].Click();

            return this;
        }

        [AllureStep("ClickButtonSave")]
        public ModalWindowPetPolicies ClickButtonSave()
        {
            Button.Click(ButtonSave);

            return this;
        }
    }
}
