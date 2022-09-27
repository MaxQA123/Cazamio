using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class GenerateRandomDataHelper
    {
        [AllureStep("RandomPhoneNumber")]
        public static string RandomPhoneNumber(int size)
        {
            Random random = new Random();
            const string chars = "1234567890";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [AllureStep("RandomEmail")]
        public static string RandomEmail(int size)
        {
            Random random = new Random();
            const string chars = "qwertyuiopasdfghjklzxcvbnm";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [AllureStep("RandomCostRentMortgageCost")]
        public static string RandomCostRentMortgageCost(int size)
        {
            Random random = new Random();
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [AllureStep("RandomPriceCreditScreeningFee")]
        public static string RandomPriceCreditScreeningFee(int size)
        {
            Random random = new Random();
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [AllureStep("RandomPriceMinInteger")]
        public static string RandomPriceMinInteger(int size)
        {
            Random random = new Random();
            const string chars = "11";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
