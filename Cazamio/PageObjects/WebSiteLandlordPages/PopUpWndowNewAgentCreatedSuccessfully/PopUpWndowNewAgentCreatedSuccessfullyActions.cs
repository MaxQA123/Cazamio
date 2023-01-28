using CazamioProgect.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.PopUpWndowNewAgentCreatedSuccessfully
{
    public partial class PopUpWndowNewAgentCreatedSuccessfully
    {
        public PopUpWndowNewAgentCreatedSuccessfully ClickButtonClose()
        {
            Button.Click(ButtonClosePopUpWndowNewAgentCreatedSuccessfully);

            return this;
        }
    }
}
