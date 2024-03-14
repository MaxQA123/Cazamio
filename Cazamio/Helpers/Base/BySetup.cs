using CazamioProject.Helpers.CustomEnums.LocatorEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers.Base
{
    public static class BySetup
    {
        public static string Condition(Attr attribute, string value) =>
            $"@{attribute}='{value}'";

        public static string WithAttribute(Attr attribute) =>
            $"@{attribute}";


        public static string ContainsCondition(Attr attribute, string value) =>
            $"contains(@{attribute}, '{value}')";

        public static string ContainsText(string value) =>
            $"contains(text(), '{value}')";

    }
}
