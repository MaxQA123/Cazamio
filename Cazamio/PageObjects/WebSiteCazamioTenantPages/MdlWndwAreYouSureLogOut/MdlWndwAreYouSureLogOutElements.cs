using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteCazamioTenantPages.MdlWndwAreYouSureLogOut
{
    public partial class MdlWndwAreYouSureLogOut
    {
        [FindsBy(How = How.XPath, Using = "//button[text() = 'Yes, I am sure']")]
        public IWebElement ButtonYesIamSure;
    }
}
