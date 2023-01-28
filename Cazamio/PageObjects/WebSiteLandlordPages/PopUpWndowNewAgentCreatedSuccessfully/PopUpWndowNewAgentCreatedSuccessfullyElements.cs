using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.PopUpWndowNewAgentCreatedSuccessfully
{
    public partial class PopUpWndowNewAgentCreatedSuccessfully
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'close - modal']")]
        public IWebElement ButtonClosePopUpWndowNewAgentCreatedSuccessfully;
    }
}
