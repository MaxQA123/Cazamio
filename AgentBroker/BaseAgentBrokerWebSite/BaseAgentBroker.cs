using CazamioProgect.Helpers;
using NUnit.Framework;

namespace AgentBrokerTests
{
    public class BaseAgentBroker : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(EndPoints.URL_LOGIN_ADMIN_WEBSITE);
        }
    }
}