using System;
using System.Collections.Generic;

namespace HHRRSupport.Models
{
    public class Business {
        public string BusinessID {get; set;}
        public string BusinessName { get; set; }
        public List<LocalBusiness> LocalBusinesses { get; set; }
    }
}