﻿using CazamioProgect.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceAdminTests
{
    public class BaseMarketplaceAdmin : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_LOGIN_ADMIN_WEBSITE);
        }
    }
}
