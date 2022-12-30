using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HomePageCazamioTenant
{
    public partial class HomeCazamioTenant
    {
        [FindsBy(How = How.XPath, Using = "//home//search-input//input[@id = 'search-input']")]
        public IWebElement FieldInputSearch;
    }
}
