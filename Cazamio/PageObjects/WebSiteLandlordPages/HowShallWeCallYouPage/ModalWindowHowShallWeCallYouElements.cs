using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.HowShallWeCallYouPage
{
    public partial class ModalWindowHowShallWeCallYou
    {
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'How shall we call you?']")]
        public IWebElement TitleHowShallWeCallYouMdlWndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstNameMdlWndw;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastNameMdlWndw;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Save']")]
        public IWebElement ButtonSaveMdlWndw;
    }
}
