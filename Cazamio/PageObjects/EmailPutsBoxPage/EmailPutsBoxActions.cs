using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using PutsboxWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            WaitUntil.CustomElementIsVisible(ButtonBodyHtml);
            WaitUntil.CustomElementIsClickable(ButtonBodyHtml);
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

        #region BodyLetterOfAdmin

        [AllureStep("ClickButtonResetPasswordForAdmin")]
        public PutsBox ClickButtonResetPasswordForAdmin()
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

        [AllureStep("ClickButtonConfirmEmailForAdmin")]
        public PutsBox ClickButtonConfirmEmailForAdmin()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            BtnCofirmEmailLandlord.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        public string CopyPasswordFromEmailForCreateAdmin()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            string getTextPassword = TextPasswordForConfirmAdmin.Text;
            Regex regexgGetTextPassword = new Regex(@"[^\s]+$");
            string textPasswordActual = regexgGetTextPassword.Match(getTextPassword).ToString();

            return textPasswordActual;
        }

        #endregion

    }

    public class VerifyPutsBox
    {
        public static void VerifyVisibilityOfToaster(string email)
        {
            string s = Putsbox.GetLinkFromEmailWithValue(email, "Confirm Email");
            Browser._Driver.Navigate().GoToUrl(s);
            //WaitUntil.CustomElementIsVisible(toasterSuccessMessage);

        }
    }
}
