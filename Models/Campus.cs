using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class Campus {
        [Key]
        [Display(Name = Literals.IdB, Prompt = Literals.IdBPrompt)]
        public string ID { get; set; }
        //////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Name)]
        public string Name { get; set; }
        //////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.City)]
        public string City { get; set; }
        //////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Adress)]
        public string Adress { get; set; }
        //////////////////////////////////////////////////////////////
        public List<AreaN1> AreasN1List { get; set; }
        //////////////////////////////////////////////////////////////
        public DateTime CreationDate { get; set; }
        

    }
}
