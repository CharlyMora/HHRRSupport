using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HHRRSupport.Models
{
    public class Campus {
        //Also known as site, venues, seats, offices or headquarters
        [Key]
        [Required]
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
        [Display(Name = Literals.AreaList)]
        public List<Area> AreasList { get; set; }
        //////////////////////////////////////////////////////////////
        public DateTime CreationDate { get; set; }
        /////////////////////////////////////////////////////////////////
        public string LocalBusinessId { get; set; }
        /////////////////////////////////////////////////////////////////
        //parece que no se usa en la practica aunque si parece
        //estar referenciado en otras partes del codigo
        //public LocalBusiness LocalBusiness { get; set; }
    }
        

    
}
