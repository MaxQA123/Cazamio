using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers.CustomEnums
{
    public enum DateFormat
    {
        Short,
        Full,
        Initials
    }


    public enum When
    {
        Today = 0,
        Tomorrow = 1,
        DayAfterTomorrow = 2,
        Yesterday = -1
    }

    public enum PassYear
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5
    }
}
