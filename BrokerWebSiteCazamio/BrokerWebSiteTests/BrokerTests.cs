using Allure.Commons;
using BrokerTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace BrokerTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseWeb : BaseBroker
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("LogInAsBroker")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as admin.
        //Comment: 

        public void LogInAsBroker()
        {

        }

    }
}