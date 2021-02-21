using System;
using System.Collections.Generic;

namespace HHRRSupport.Models
{
    public class Campus {
        public string ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public List<AreaN1> AreasN1List { get; set; }
        public DateTime CreationDate { get; set; }
        

    }
}
