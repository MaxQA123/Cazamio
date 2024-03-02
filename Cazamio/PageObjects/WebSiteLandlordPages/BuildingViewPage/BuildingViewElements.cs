using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.BuildingViewPage
{
    public partial class BuildingView
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Building view']"))]
        public IWebElement TitleBuildingViewPage;

        [FindsBy(How = How.XPath, Using = ("//div[@class = 'form-result-wrapper']/div/div[2]"))]
        public IWebElement FieldNotInputAddress;

        [FindsBy(How = How.XPath, Using = ("//building-view//form//div/div"))]
        public IWebElement FieldNotInputBuildingName;

        #region TabsLine

        [FindsBy(How = How.XPath, Using = ("//a[text() = 'Apartments']"))]
        public IWebElement TabApartmentsBldngVwPg;

        #endregion

        #region InTabApartments

        [FindsBy(How = How.XPath, Using = ("//app-building-apartments//span[text() = 'Add']"))]
        public IWebElement ButtonAddInTabApartments;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement ButtonUnitSortingInTabApartmentsBldngVwPg;

        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr//td[text() = '1']"))]
        public IWebElement UnitFourInTabApartmentsBldngVwPg;

        #endregion
    }
}
