using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class Area {

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
        [Display(Name = Literals.AreaList)]
        public List<Area> AreasList { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.CustomersList)]
        public List<Customer> CustomersList { get; set; }
        

    }
}
