using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.EmailPutsBox
{
    public partial class PutsBox
    {
        public PutsBox RandomEndPointPutsBoxEmail(string emailPutsBox)
        {
            var randomEmailPutsBox = ($"https://putsbox.com/{emailPutsBox}/inspect");

            return this;
        }
    }
}
