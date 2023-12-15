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

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'companyName']"))]
        public IWebElement FieldInputCompanyName;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'ownerName']"))]
        public IWebElement FieldInputOwnerName;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'ownerEmail']"))]
        public IWebElement FieldInputOwnerEmail;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'officeLocation']"))]
        public IWebElement FieldInputOfficeLocation;

        [FindsBy(How = How.XPath, Using = ("//div//ng-select[@id = 'broker']"))]
        public IWebElement ButtonSelectUser;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//span[text() = 'Marie Urmstrong']"))]
        public IWebElement ItemAgentUser;

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'note']"))]
        public IWebElement FieldInputInternalNotes;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Add phone number']"))]
        public IWebElement ButtonAddPhoneNumber;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'phoneNumber']"))]
        public IWebElement FieldInputPhoneNumber;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'extension']"))]
        public IWebElement FieldInputExtensionNumber;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Add Commission Structure']"))]
        public IWebElement ButtonAddCommissionStructure;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'commissionStructures']//span[@class = 'ng-arrow-wrapper']"))]
        public IWebElement ButtonPayType;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'commissionStructures']//span[text() = 'Owner and Tenant Pays']"))]
        public IWebElement ItemOwnerAndTenantPays;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'commissionStructures']//span[text() = 'Tenant Pays']"))]
        public IWebElement ItemTenantPays;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'commissionStructures']//span[text() = 'Owner Pays']"))]
        public IWebElement ItemOwnerPays;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'owner-number-of-months']"))]
        public IWebElement FieldInputOwnerNumberOfMonths;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'tenant-number-of-months']"))]
        public IWebElement FieldInputTenantNumberOfMonths;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'ownerPercentage']"))]
        public IWebElement FieldInputOwnerPercentage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'tenantPercentage']"))]
        public IWebElement FieldInputTenantPercentage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'take-off']"))]
        public IWebElement FieldInputTakeOff;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Add mgmt']"))]
        public IWebElement ButtonAddMgmt;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'managements']//input[@formcontrolname = 'name']"))]
        public IWebElement FieldInputMgmtName;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'managements']//input[@formcontrolname = 'email']"))]
        public IWebElement FieldInputMgmtEmail;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'managements']//input[@formcontrolname = 'phoneNumber']"))]
        public IWebElement FieldInputPhoneNumberMgmt;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'managements']//input[@formcontrolname = 'extension']"))]
        public IWebElement FieldInputMgmtExtensionNumber;

        [FindsBy(How = How.XPath, Using = ("//div[@formarrayname = 'managements']//input[@formcontrolname = 'officeLocation']"))]
        public IWebElement FieldInputMgmtOfficeLocation;

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = 'Create']"))]
        public IWebElement ButtonCreate;
    }
}
