using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class Experience {

        [Key]
        public string ID { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.BusinessName)]
        public string BusinessName { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.Position)]
        public string Position { get; set; }
        //////////////////////////////////////////////////////////
        [Display(Name = Literals.MontsOnPlace)]
        public string MontsOnPlace { get; set; }
        
        

    }
}
