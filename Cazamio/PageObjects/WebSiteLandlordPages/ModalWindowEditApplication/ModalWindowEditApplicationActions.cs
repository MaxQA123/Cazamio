using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowEditApplication
{
    public partial class ModalWindowEditApplication
    {
        [AllureStep("ClickButtonInFormEditApplication")]
        public ModalWindowEditApplication ClickButtonInFormEditApplication()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(ButtonInFormEditApplication);
            Button.Click(ButtonInFormEditApplication);

            return this;
        }

        [AllureStep("GetShortBuidingAddressFromStepOneEditApplication")]
        public string GetShortBuidingAddressFromStepOneEditApplication()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FullUnitAddressStepOneEditApplication);
            string getUnitAddress = FullUnitAddressStepOneEditApplication.Text;
            Regex regexPartUnitAddress = new Regex(@"\b\w+\b");
            MatchCollection matches = regexPartUnitAddress.Matches(getUnitAddress);
            for (int i = 0; i < Math.Min(3, matches.Count); i++)
            {
                Console.WriteLine(matches[i].Value);
            }

            return matches[3].Value;
        }

        public string GetDemo()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(FullUnitAddressStepOneEditApplication);
            string getUnitAddress = FullUnitAddressStepOneEditApplication.Text;
            // Определите регулярное выражение для поиска слов
            Regex regex = new Regex(@"\b\w+\b");

            // Найдите все совпадения в строке
            MatchCollection matches = regex.Matches(getUnitAddress);

            // Создайте массив для хранения слов
            string[] firstThreeWords = new string[Math.Min(3, matches.Count)];

            // Сохраните первые три слова в массиве
            for (int i = 0; i < firstThreeWords.Length; i++)
            {
                firstThreeWords[i] = matches[i].Value;
            }

            // Объедините слова в одну строку
            string result = string.Join(" ", firstThreeWords);

            Console.WriteLine(result);

            return result;
        }
    }
}
