using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteCazamioTenantPages.MyAccountPageCazamioTenant
{
    public partial class MyAccountCazamioTenant
    {

        #region TabsOnMyAccountPage

        [AllureStep("ClickTabAccountOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabAccountOnMyAccntPg()
        {
            Button.Click(TabAccount);

            return this;
        }

        [AllureStep("ClickTabApplicationsOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabApplicationsOnMyAccntPg()
        {
            Button.Click(TabApplications);

            return this;
        }

        [AllureStep("ClickTabFavoritesOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabFavoritesOnMyAccntPg()
        {
            Button.Click(TabFavorites);

            return this;
        }

        [AllureStep("ClickTabHistoryOnMyAccntPg")]
        public MyAccountCazamioTenant ClickTabHistoryOnMyAccntPg()
        {
            Button.Click(TabHistory);

            return this;
        }

        #endregion

    }
}
