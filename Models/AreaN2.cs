using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class AreaN2 {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public List<AreasN3> AreasN1List { get; set; }
        public List<Customer> CustomersList { get; set; }
        public List<Employee> EmployeesList { get; set; }
        

    }
}
