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
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Application detail']"))]
        public IWebElement TitleApplicationDetail;

        [FindsBy(How = How.XPath, Using = ("//cazamio-button[@text = 'Edit application']"))]
        public IWebElement ButtonEditApplication;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'net-price']"))]
        public IWebElement FieldInputNetRentApplctnDtlPg;
    }
}
