using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class AreaN2 {
        [Key]
        [Display(Name = Literals.IdB, Prompt = Literals.IdBPrompt)]
        public string ID { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Name)]
        public string Name { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.Description)]
        public string Description { get; set; }
        //////////////////////////////////////////////////////////
        //public List<AreasN3> AreasN1List { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.CustomersList)]
        public List<Customer> CustomersList { get; set; }
        [Display(Name = Literals.EmployeesList)]
        public List<Employee> EmployeesList { get; set; }
        

    }
}
