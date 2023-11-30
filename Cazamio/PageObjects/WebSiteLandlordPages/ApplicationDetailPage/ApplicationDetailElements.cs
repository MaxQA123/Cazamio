using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ApplicationDetailPage
{
    public partial class ApplicationDetail
    {
        [FindsBy(How = How.XPath, Using = ("//cazamio-button[@text = 'Edit application']"))]
        public IWebElement ButtonEditApplication;
    }
}
