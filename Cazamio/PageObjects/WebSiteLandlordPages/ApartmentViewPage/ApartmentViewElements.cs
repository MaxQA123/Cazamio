using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Apartment view']"))]
        public IWebElement TitleApartmentViewPg;

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = '+Application']"))]
        public IWebElement ButtonPlusApplication;
    }
}
