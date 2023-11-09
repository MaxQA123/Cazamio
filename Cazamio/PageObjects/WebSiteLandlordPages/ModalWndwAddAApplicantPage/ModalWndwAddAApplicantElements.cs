using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWndwAddAApplicantPage
{
    public partial class ModalWndwAddAApplicant
    {
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'Add Applicant']")]
        public IWebElement TitleAddApplicantMdlWndw;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Look up existing lead or create new']")]
        public IWebElement FirstFieldInputEmailAddressMdlWndw;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'step applicants ng-star-inserted']//div[@class = 'email-input no-margin ng-star-inserted'][2]//input[@placeholder = 'Look up existing lead or create new']")]
        public IWebElement SecondFieldInputEmailAddressMdlWndw;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' + Add another applicant ']")]
        public IWebElement ButtonPlusAnotherApplicantMdlWndw;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement CheckTheBoxThisIGuarantorMdlWndw;
    }
}
