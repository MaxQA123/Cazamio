using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.EmailXitrooPage
{
    public partial class EmailXitroo
    {
        [AllureStep("CopiedForEnterEmail")]
        public EmailXitroo CopiedForEnterEmail(string _email)
        {
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, _email);

            return this;
        }

        [AllureStep("ClickSearchButton")]
        public EmailXitroo ClickSearchButton()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonSearchEmail);

            return this;
        }

        [AllureStep("OpenNewlyLetter")]
        public EmailXitroo OpenNewlyLetter()
        {
            WaitUntil.WaitSomeInterval(10000);
            Button.Click(SelectLetterNumberOneNew);

            return this;
        }

        [AllureStep("OpenNewlyLetter")]
        public EmailXitroo ClickButtonBackEmail()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonBackEmail);

            return this;
        }
    }
}
