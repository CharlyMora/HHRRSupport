using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class Employee {

        [Key]
        [Display(Name = Literals.Id, Prompt = Literals.IdPrompt)]
        public string ID { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Names)]
        public string Name { get; set; }
        
        
        

    }
}
