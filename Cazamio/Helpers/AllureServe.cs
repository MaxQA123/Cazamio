﻿using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using Cazamio.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class AllureServe
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Perevalov Maksim")]
        [AllureSuite("WebSite")]
        [AllureSubSuite("Client")]


        public void GoToAllureResults()
        {
            AllureConfigFilesHelper.CreateBatFile();
            Process.Start(Browser.RootPath() + "allure serve.bat");
        }
    }
}