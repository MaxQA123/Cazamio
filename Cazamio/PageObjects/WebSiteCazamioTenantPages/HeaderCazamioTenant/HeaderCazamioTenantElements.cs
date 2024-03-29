﻿using CazamioProgect.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.HeaderCazamioTenant
{
    public partial class HeaderCazamioTenant
    {
        [FindsBy(How = How.XPath, Using = "//a[@href = '/account/signup']")]
        public IWebElement ButtonSignUpHdrCzmTnnt;

        public IWebElement ButtonLogInHdrCzmTnnt => Browser._Driver.FindElement(_ButtonLogInHdrCzmTnnt);
        public static readonly By _ButtonLogInHdrCzmTnnt = By.XPath("//a[@href = '/account/signin']");

        public IWebElement ButtonMyApplicationsHdrCzmTnnt => Browser._Driver.FindElement(_ButtonMyApplicationsHdrCzmTnnt);
        public static readonly By _ButtonMyApplicationsHdrCzmTnnt = By.XPath("//a[@href= '/my-info/applications']");

        [FindsBy(How = How.XPath, Using = "//logged-in-header//header//div[@class = 'user-panel']//ul//li[@class = 'avatar']")]
        public IWebElement ButtonInFormAvatarHdrCzmTnnt;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label= 'My account']")]
        public IWebElement ButtonMyAccountHdrCzmTnnt;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Sign Out']")]
        public IWebElement ButtonSignOutHdrCzmTnnt;
    }
}
