using CazamioProgect.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantAbodeTests
{
    public class BaseTenantAbode : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_HOME_PAGETENANT_WEBSITE_ABIDEO);
        }
    }
}
