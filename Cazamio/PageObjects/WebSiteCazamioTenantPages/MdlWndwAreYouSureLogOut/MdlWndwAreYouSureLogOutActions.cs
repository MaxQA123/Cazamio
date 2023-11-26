using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteCazamioTenantPages.MdlWndwAreYouSureLogOut
{
    public partial class MdlWndwAreYouSureLogOut
    {
        [AllureStep("LogOutFromAccountViaHeader")]
        public MdlWndwAreYouSureLogOut ClickButtonYesIamSure()
        {
            WaitUntil.CustomElementIsVisible(ButtonYesIamSure);
            Button.Click(ButtonYesIamSure);

            return this;
        }
    }
}
