using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowPetPolicies
{
    public partial class ModalWindowPetPolicies
    {
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'Pet policies']")]
        public IWebElement TitlePetPolicies;

        [FindsBy(How = How.XPath, Using = "//button//span[(text() = 'Save')]")]
        public IWebElement ButtonSave;
    }
}
