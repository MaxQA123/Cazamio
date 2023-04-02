﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'List of brokers']"))]
        public IWebElement TitleListOfBrokers;

    }
}
