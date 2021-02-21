using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class Customer {
        [Key]
        [Display(Name = Literals.Id, Prompt = Literals.IdPrompt)]
        public string ID { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Active)]
        public bool Active { get; set; }
        //////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Name)]
        public string Name { get; set; }
        //////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Type)]
        public string Type { get; set; }
        //////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Description)]
        public string Description { get; set; }
        //////////////////////////////////////////////////////////////
        [Display(Name = Literals.LanguageList)]
        public List<Language> LanguageList { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.EmployeesList)]
        public List<Employee> EmployeesList { get; set; }
    }
}
