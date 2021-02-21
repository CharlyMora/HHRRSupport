using System;
using System.Collections.Generic;

namespace HHRRSupport.Models
{
    public class AreaN1 {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<AreasN2> AreasN1List { get; set; }
        public List<Campaign> CampaignList { get; set; }
        public List<Employee> Employees1List { get; set; }
        

    }
}
