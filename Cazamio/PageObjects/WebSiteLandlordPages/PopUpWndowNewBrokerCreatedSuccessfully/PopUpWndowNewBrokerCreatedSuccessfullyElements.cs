using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.PopUpWndowNewBrokerCreatedSuccessfully
{
    public partial class PopUpWndowNewBrokerCreatedSuccessfully
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = эclose - modalэ]")]
        public IWebElement ButtonClosePopUpWndowNewBrokerCreatedSuccessfully;
    }
}
