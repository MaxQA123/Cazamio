using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.EmailPutsBox
{
    public partial class PutsBox
    {
        [AllureStep("VerifyTitleLetterCreateAdmin")]
        public PutsBox VerifyTitleLetterCreateAdmin()
        {
            WaitUntil.CustomElementIsVisible(TitleLetterCreateAdmin);
            Assert.IsTrue(TitleLetterCreateAdmin.Displayed);
            Console.WriteLine(TitleLetterCreateAdmin.Text);

            return this;
        }

        [AllureStep("VerifyTitleLetterCreateBroker")]
        public PutsBox VerifyTitleLetterCreateBroker()
        {
            WaitUntil.CustomElementIsVisible(TitleLetterCreateAdmin);
            Assert.IsTrue(TitleLetterCreateAdmin.Displayed);
            Console.WriteLine(TitleLetterCreateAdmin.Text);

            return this;
        }

        [AllureStep("VerifyTitleLetterCreateTenant")]
        public PutsBox VerifyTitleLetterCreateTenant()
        {
            WaitUntil.CustomElementIsVisible(TitleLetterCreateTenant);
            Assert.IsTrue(TitleLetterCreateTenant.Displayed);
            Console.WriteLine(TitleLetterCreateTenant.Text);

            return this;
        }
    }
}
