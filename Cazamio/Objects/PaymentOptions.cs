using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class PaymentOptions
    {
        public DeliverCheckNoteInfo DeliverCheckNote { get; set; }
        public ZelleInfo Zelle { get; set; }

        public class DeliverCheckNoteInfo
        {
            public string ForBuilding { get; set; }
            public string ForApartment { get; set; }
        }

        public class ZelleInfo
        {
            public string ForBuilding { get; set; }
            public string ForApartment { get; set; }
        }

        public PaymentOptions Generate()
        {
            string deliverCheckNoteForBuilding = "Deliver check for Building (12345) (%$#@!) (09876)";
            string deliverCheckNoteForApartment = "Deliver check for Apartment (12345) (%$#@!) (09876)";
            string zelleForBuilding = "screening5building@xitroo.com 2128712345";
            string zelleForApartment = "screening5apart@xitroo.com 5180987123";

            var paymentOptions = new PaymentOptions()
            {
                DeliverCheckNote = new DeliverCheckNoteInfo
                {
                    ForBuilding = deliverCheckNoteForBuilding,
                    ForApartment = deliverCheckNoteForApartment
                },
                Zelle = new ZelleInfo
                {
                    ForBuilding = zelleForBuilding,
                    ForApartment = zelleForApartment
                },
            };
            return paymentOptions;
        }
    }
}
