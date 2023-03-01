using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateNewOwner
{
    public partial class ModalWndwCreateNewOwner
    {
        [FindsBy(How = How.XPath, Using = ("//app-owner-create-update//h2[text() = 'Create a new Owner']"))]
        public IWebElement TitleCreateANewOwner;
    }
}
