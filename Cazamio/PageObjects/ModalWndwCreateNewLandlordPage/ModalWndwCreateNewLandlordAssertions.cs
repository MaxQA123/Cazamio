using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateNewLandlordPage
{
    public partial class ModalWndwCreateNewLandlord
    {
        [AllureStep("VerifyTitleMdlWndwCreateNewLandlord")]
        public ModalWndwCreateNewLandlord VerifyTitleMdlWndwCreateNewLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleMdlWndwCreateNewLandlord));

            return this;
        }
    }
}
