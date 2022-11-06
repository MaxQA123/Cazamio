using CazamioProgect.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantCazamioTests
{
    public class BaseTenantCazamio : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_HOME_PAGE_TENANT_WEBSITE_CAZAMIO);
        }
    }
}
