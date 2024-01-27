using CazamioProgect.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class Agent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Cell { get; set; }
        public string BrokerCommission { get; set; }
        public string AgentCommission { get; set; }
        public string EmailAddressAgent { get; set; }
        public string FullNameAgent { get; set; }

        public Agent Generate()
        {
            string firsName = "AgentQA";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumberWithoutZero(3) + GenerateRandomDataHelper.RandomEmail(2);
            string phoneNumber = "212" + GenerateRandomDataHelper.RandomPhoneNumber(7);
            string cell = "518" + GenerateRandomDataHelper.RandomPhoneNumber(7);
            string brokerCommission = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string agentCommission = GenerateRandomDataHelper.RandomNumberWithoutZero(2);
            string emailAddressAgent = "agent5lula@putsbox.com";
            string fullNameAgent = "Lula AgentQA";

            var agent = new Agent()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + NameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                PhoneNumber = phoneNumber,
                Cell = cell,
                BrokerCommission = brokerCommission,
                AgentCommission = agentCommission,
                EmailAddressAgent = emailAddressAgent,
                FullNameAgent = fullNameAgent,
            };
            return agent;
        }
    }
}
