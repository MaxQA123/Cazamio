using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.EmailPutsBox
{
    public partial class PutsBox
    {
        #region PageListOfLetters

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'HTML')]")]
        public IWebElement ButtonBodyHtml;

        #endregion

        #region BodyLetterOfTenant

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonConfirmEmailForTenant;

        [FindsBy(How = How.XPath, Using = "//table[@class ='es-content']//tbody//tr[3]//table[@class = 'es-content-body']//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonResetPasswordForTenant;

        #endregion
    }
}
