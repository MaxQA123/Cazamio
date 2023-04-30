using CazamioProgect.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        public ListOfBrokers ClickButtonCreateBroker()
        {
            WaitUntil.CustomElementIsVisible(ButtonCreateBroker);
            Button.Click(ButtonCreateBroker);

            return this;
        }
    }
}
