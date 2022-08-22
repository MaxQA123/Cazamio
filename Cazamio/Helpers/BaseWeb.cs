using NUnit.Framework;
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
            Browser.Initialize();
        }

        [OneTimeTearDown]
        public void DoAfterAllTheTests()
        {

        }

        [TearDown]

        public void DoAfterEach()
        {
            Browser.Quit();
        }

    }
}
