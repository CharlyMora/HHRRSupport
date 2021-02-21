using System;
using System.Collections.Generic;

namespace HHRRSupport.Models
{
    public class LocalBusiness {
        public string ID { get; set; }
        public string CommercialName { get; set; }
        public string LegalName { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public List<Campus> CampusList { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
