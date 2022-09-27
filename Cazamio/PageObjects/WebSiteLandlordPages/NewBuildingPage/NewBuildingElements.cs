using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        #region TabBasicDetails

        [FindsBy(How = How.XPath, Using = "//div[@class = 'navigation-title']")]
        public IWebElement TitleNewBuildingPage;

        [FindsBy(How = How.CssSelector, Using = "input#inputAddress")]
        public IWebElement FieldInputAddressNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#city")]
        public IWebElement FieldInputCityNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#state")]
        public IWebElement FieldInputStateNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#zip")]
        public IWebElement FieldInputZipNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#buildingName")]
        public IWebElement FieldInputBuildingNameNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "input#llcName")]
        public IWebElement FieldInputLlcNameNwBldngPg;

        [FindsBy(How = How.CssSelector, Using = "textarea#description")]
        public IWebElement FieldInputDescroptionNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname= 'screeningFee']")]
        public IWebElement FieldInputCreditScreeningFeeNwBldngPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'middle important']")]
        public IWebElement ButtonSelectPeymentsMethodsNwBldngPg;

        #endregion


    }
}
