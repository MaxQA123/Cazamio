using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.PaginationPickerPage
{
    public partial class PaginationPicker
    {
        [FindsBy(How = How.XPath, Using = "//ul[@aria-label = 'Pagination']//li[@class = 'pagination-next']")]
        public IWebElement ButtonNext;

        [FindsBy(How = How.XPath, Using = "//ul[@role= 'navigation']//li[last()-1]")]
        public IWebElement ButtonLastNumberPage;
    }
}
