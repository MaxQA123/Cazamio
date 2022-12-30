using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.ApartmentDetailsTenantPage
{
    public partial class ApartmentDetailsTenant
    {
        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Submit Application']")]
        public IWebElement ButtonSubmitApplication;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Complete Full Application']")]
        public IWebElement ButtonCompleteFullApplication;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Hold this apartment']")]
        public IWebElement ButtonHoldThisApartment;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Edit']")]
        public IWebElement ButtonEdit;
    }
}
