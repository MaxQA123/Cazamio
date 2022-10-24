using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PractisingPrivileges.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CazamioProgect.Helpers
{
    public class Browser
    {
        public IWebDriver WebDriver { get; set; }

        private static IWebDriver _webDriver;

        internal static void FindElement(object actualUserNameLog)
        {
            throw new NotImplementedException();
        }

        public Browser(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public static void Initialize()
        {
            AllureConfigFilesHelper.CreateJsonConfigFile();
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
            _Driver.Manage().Cookies.DeleteAllCookies();
            _Driver.Manage().Window.Maximize();

            Assert.NotNull(_webDriver);
        }


        public static string RootPath()
        {
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            return mainpath;
        }
        public static ISearchContext Driver { get { return _webDriver; } }
        public static IWebDriver _Driver { get { return _webDriver; } }
        public static string Title
        {
            get { return _webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return _webDriver.Url; }
        }

        public static void Close()
        {
            _webDriver.Close();
        }

        public static void Quit()
        {
            _webDriver.Quit();
        }

    }
}
