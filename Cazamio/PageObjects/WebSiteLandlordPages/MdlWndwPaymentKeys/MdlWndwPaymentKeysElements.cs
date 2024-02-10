using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.MdlWndwPaymentKeys
{
    public partial class MdlWndwPaymentKeysActions
    {
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Cardknox']")]
        public IWebElement ItemCardknox;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'czmodev359376936c0543b58126c97f9ff55c68']")]
        public IWebElement ItemApiKeyCardknox;
    }
}
