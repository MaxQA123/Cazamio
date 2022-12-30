using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ListOfApartmentsTenantPage
{
    public partial class ListOfApartmentsTenant
    {
        private static IWebElement _element;

        [AllureStep("SelectorApartmentCard")]
        public static IList<IWebElement> SelectorApartmentCard(string locationCard)
        {
            WaitUntil.WaitSomeInterval(500);
            var str = $"//div[@class = 'search-collection']//div[contains(text(), '{locationCard}')]";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div"));
        }

        [AllureStep("SelectApartmentCard")]
        public ListOfApartmentsTenant SelectApartmentCard(int card, string locationCard)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _card = SelectorApartmentCard(locationCard);

            _card[card].Click();

            return this;
        }

    }
}
