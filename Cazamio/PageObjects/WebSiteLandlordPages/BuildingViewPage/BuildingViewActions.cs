using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.BuildingViewPage
{
    public partial class BuildingView
    {
        #region TabsLine

        [AllureStep("ClickTabApartmentsBldngVwPg")]
        public BuildingView ClickTabApartmentsBldngVwPg()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(TabApartmentsBldngVwPg);

            return this;
        }

        #endregion

        #region InTabApartments

        [AllureStep("ClickButtonAddInTabApartmentsBldngVwPg")]
        public BuildingView ClickButtonAddInTabApartmentsBldngVwPg()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddInTabApartmentsBldngVwPg, 10);
            Button.Click(ButtonAddInTabApartmentsBldngVwPg);

            return this;
        }

        #endregion
    }
}
