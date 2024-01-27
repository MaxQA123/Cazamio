using CazamioProgect.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class Broker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string EmailAddressBroker { get; set; }
        public string FullUserNameBroker { get; set; }

        public Broker Generate()
        {
            string firsName = "BrokerQA";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumberWithoutZero(3) + GenerateRandomDataHelper.RandomEmail(2);
            string emailAddressBroker = "broker3autotest@putsbox.com";
            string fullUserNameBroker = "Leoautotest Feabroker";

            var broker = new Broker()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + NameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                EmailAddressBroker = emailAddressBroker,
                FullUserNameBroker = fullUserNameBroker,

            };
            return broker;
        }
    }
}
