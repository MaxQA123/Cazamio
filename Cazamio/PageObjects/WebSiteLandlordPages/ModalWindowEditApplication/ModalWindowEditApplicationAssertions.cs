using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowEditApplication
{
    public partial class ModalWindowEditApplication
    {
        [AllureStep("VerifyTitleEditApplicationMdlWndwEdtApplctn")]
        public ModalWindowEditApplication VerifyTitleEditApplicationMdlWndwEdtApplctn()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleEditApplication));

            return this;
        }
    }
}
