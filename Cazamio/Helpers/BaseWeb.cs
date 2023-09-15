using NUnit.Framework;
using NUnit.Framework.Interfaces;
using CazamioProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class BaseWeb
    {
        [OneTimeSetUp]
        public void DobeforeAllTheTests()
        {
            
        }

        [OneTimeTearDown]
        public void DoAfterAllTheTests()
        {
            Browser.Quit();

            ForceCloseDriver.ForceClose();
        }

        [TearDown]

        public void DoAfterEach()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                ScreenShotHelper.MakeScreenShot();
                Browser.Close();
            }
            else if (Browser._Driver != null)
            {
                Browser.Close();
            }

        }

    }
}
