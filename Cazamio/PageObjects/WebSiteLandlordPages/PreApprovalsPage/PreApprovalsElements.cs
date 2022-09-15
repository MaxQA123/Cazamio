using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.PreApprovalsPage
{
    public partial class PreApprovals
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= 'Pre-Approvals']")]
        public IWebElement TitlePreApprovalsPage;
    }
}
