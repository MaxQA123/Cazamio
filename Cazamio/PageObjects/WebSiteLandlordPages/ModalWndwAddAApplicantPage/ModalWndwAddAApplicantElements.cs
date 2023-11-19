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
        public IWebElement TitleAddApplicantMdlWndwAddAApplicant;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Look up existing lead or create new']")]
        public IWebElement FirstFieldInputEmailAddressMdlWndwAddAApplicant;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'step applicants ng-star-inserted']//div[@class = 'email-input no-margin ng-star-inserted'][2]//input[@placeholder = 'Look up existing lead or create new']")]
        public IWebElement SecondFieldInputEmailAddressMdlWndwAddAApplicant;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'step applicants ng-star-inserted']//div[@class = 'checkbox-input ng-star-inserted'][2]//input[@class = 'checkbox-field ng-untouched ng-pristine ng-valid']")]
        public IWebElement SecondCheckTheBoxThisIGuarantorMdlWndwAddAApplicant;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' + Add another applicant ']")]
        public IWebElement ButtonPlusAnotherApplicantMdlWndwAddAApplicant;

        [FindsBy(How = How.XPath, Using = "//cazamio-mobile-button//button//span[text() = 'Add']")]
        public IWebElement ButtonAddMdlWndwAddAApplicant;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Added applicants to application']")]
        public IWebElement MessageAddedApplicantsToApplicationMdlWndwAddAApplicant;
    }
}
