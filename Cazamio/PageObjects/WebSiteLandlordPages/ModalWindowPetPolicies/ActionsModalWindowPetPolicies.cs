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
        public static IList<IWebElement> SelectorPetPolicies()
        {
            WaitUntil.WaitSomeInterval(1000);
            return _elementPetPolicies.FindElements(By.XPath($".//div//mat-checkbox]"));
        }

        [AllureStep("SelectItemPetPolocies")]
        public ModalWindowPetPolicies SelectItemPetPolocies(int numberItem)
        {
            Button.Click(PetPoliciesList[numberItem]);

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
