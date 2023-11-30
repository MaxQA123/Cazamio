using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowEditApplication
{
    public partial class ModalWindowEditApplication
    {
        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Edit application']"))]
        public IWebElement TitleEditApplication;

        [FindsBy(How = How.XPath, Using = ("//div[@class = 'edit-address-icon ng-star-inserted']"))]
        public IWebElement ButtonInFormEditApplication;
    }
}
