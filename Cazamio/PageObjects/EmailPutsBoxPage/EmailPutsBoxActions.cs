using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
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

        [AllureStep("ClickButtonBodyHtml")]
        public PutsBox ClickButtonBodyHtml()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonBodyHtml);

            return this;
        }

        #endregion

        #region BodyLetterOfTenant

        [AllureStep("ClickButtonConfirmEmailForTenant")]
        public PutsBox ClickButtonConfirmEmailForTenant()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonConfirmEmailForTenant.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickButtonResetPasswordForTenant")]
        public PutsBox ClickButtonResetPasswordForTenant()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonResetPasswordForTenant.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        #endregion
    }
}
