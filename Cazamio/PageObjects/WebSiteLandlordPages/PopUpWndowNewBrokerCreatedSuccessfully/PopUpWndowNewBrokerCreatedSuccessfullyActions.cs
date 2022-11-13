using CazamioProgect.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.PopUpWndowNewBrokerCreatedSuccessfully
{
    public partial class PopUpWndowNewBrokerCreatedSuccessfully
    {
        public PopUpWndowNewBrokerCreatedSuccessfully ClickButtonClocse()
        {
            Button.Click(ButtonClosePopUpWndowNewBrokerCreatedSuccessfully);

            return this;
        }
    }
}
