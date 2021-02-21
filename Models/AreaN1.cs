using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class AreaN1 {

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
        [Display(Name = Literals.AreaN2List)]
        public List<AreaN2> AreasN2List { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.CustomersList)]
        public List<Customer> CustomersList { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.EmployeesList)]
        public List<Employee> EmployeesList { get; set; }
        

    }
}
