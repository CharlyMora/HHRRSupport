using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class LocalBusiness {
        [Key]
        [Display(Name = Literals.IdB, Prompt = Literals.IdBPrompt)]
        public string Id { get; set; }
        /////////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Name)]
        public string CommercialName { get; set; }
        /////////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.LegalName)]
        public string LegalName { get; set; }
        /////////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Country)]
        public string Country { get; set; }
        /////////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Region)]
        public string Region { get; set; }
        /////////////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.City)]
        public string City { get; set; }
        /////////////////////////////////////////////////////////////////
        public List<Campus> CampusList { get; set; }
        /////////////////////////////////////////////////////////////////
        public DateTime CreationDate { get; set; }
        /////////////////////////////////////////////////////////////////
        public string BusinessId { get; set; }
        /////////////////////////////////////////////////////////////////
        //parece que no se usa en la practica aunque si parece
        //estar referenciado en otras partes del codigo
        //public Business Business { get; set; }
    }
}
