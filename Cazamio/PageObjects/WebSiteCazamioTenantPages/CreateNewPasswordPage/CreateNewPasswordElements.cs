using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.CreateNewPasswordPage
{
    public partial class CreateNewPassword
    {
        [FindsBy(How = How.XPath, Using = "//input[@id = 'password']")]
        public IWebElement InputFieldPassswordCreateNewPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'show-password-container']//div")]
        public IWebElement IconShowCreateNewPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'large primary-action absolute-loader']")]
        public IWebElement ButtonSaveMyPasswordCreateNewPsswrdPg;
    }
}
