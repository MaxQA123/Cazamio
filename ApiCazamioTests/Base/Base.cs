using CazamioProgect.Helpers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using PractisingPrivileges.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.Base
{
    public class Base
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AllureConfigFilesHelper.CreateJsonConfigFile();
        }

        [SetUp]

        public void SetUp()
        {

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {

        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Console.WriteLine(TestContext.CurrentContext.Result.Outcome.Status);
            }
        }
    }
}
