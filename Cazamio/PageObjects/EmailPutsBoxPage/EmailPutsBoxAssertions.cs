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
            Assert.IsTrue(Successfully.IsVisible(TitleLetterCreateAdmin));

            return this;
        }
    }
}
