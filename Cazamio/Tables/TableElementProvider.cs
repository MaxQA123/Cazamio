using CazamioProgect.Helpers;
using OpenQA.Selenium;
using System;
using CazamioProject.Helpers.CustomEnums.LocatorEnums;
using CazamioProject.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Tables
{
    public class TableElementProvider
    {
        private IWebElement _webTable;
        public TableElementProvider()
        {
            _webTable = Browser.Driver.FindElement(By.TagName("table"));
        }
        public TableElementProvider(IWebElement webTable)
        {
            _webTable = webTable;
        }


        public IWebElement GetCellElement<TEnum>(TEnum column, int rowNumber) where TEnum : Enum
        {
            IWebElement element = _webTable.
               FindXPath(Tags.Tbody).
               FindXPath(Tags.Tr, rowNumber).
               FindXPath(Tags.Td, (int)(object)column);
            return element;
        }

        public string GetCellValue<TEnum>(TEnum column, int rowNumber) where TEnum : Enum
        {
            IWebElement element = _webTable.
               FindXPath(Tags.Tbody).
               FindXPath(Tags.Tr, rowNumber).
               FindXPath(Tags.Td, (int)(object)column);
            return element.Text;
        }

        public IWebElement GetCellButton<TEnum>(TEnum column, int rowNumber) where TEnum : Enum
        {
            IWebElement element = _webTable.
               FindXPath(Tags.Tbody).
               FindXPath(Tags.Tr, rowNumber).
               FindXPath(Tags.Td, (int)(object)column).
               FindXPath(Tags.Button);
            return element;
        }
    }
}
