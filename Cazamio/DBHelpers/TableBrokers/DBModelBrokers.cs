using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableBrokers
{
    public class DBModelBrokers
    {
        // Brokers table = role "Agent"
        public object? Id { get; set; } // this might be another data type
        public object? UserId { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? MarketplaceId { get; set; }
        public object? BrokerCommission { get; set; }
        public object? AgentCommission { get; set; }
    }

    public class DBModelBrokersCombined
    {
        public object? UserId { get; set; } // this might be another data type
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? MarketplaceId { get; set; }
        public object? BrokerCommission { get; set; }
        public object? AgentCommission { get; set; }
        public object? FirstName { get; set; }
        public object? LastName { get; set; }
        public object? Email { get; set; }
    }
}
