using CazamioProgect.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant
{
    public partial class MyAccountCazamioTenant
    {
        public static IList<IWebElement> SelectorTabsOnMyAccountPage(string locationPlace)
        {
            WaitUntil.WaitSomeInterval(500);
            return Browser._Driver.FindElements(By.XPath($".//div[@class= 'info-tabs']/ul"));
        }


        //public static readonly By _TabMyAccountMyAccntCzmTnnt = By.XPath("")

        #region TabMyAccount

        //public static readonly By _Tab

        #endregion
    }
}
