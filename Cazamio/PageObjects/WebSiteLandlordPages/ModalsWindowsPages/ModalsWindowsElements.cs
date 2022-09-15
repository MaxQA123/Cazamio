using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalsWindowsPages
{
    public partial class ModalsWindowsLandlordBroker
    {
        #region ModalWindowAreYouSure

        [FindsBy(How = How.XPath, Using = "//button[@class = 'swal2-confirm btn btn-success']")]
        public IWebElement ButtonYesIAmSureOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'swal2-cancel btn btn-danger']")]
        public IWebElement ButtonCancelOnMdlwndw;

        #endregion
    }
}
