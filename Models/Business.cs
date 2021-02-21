using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class Business {
        [Key]
        [Display(Name = Literals.IdB, Prompt = Literals.IdBPrompt)]
        public string BusinessID {get; set;}
        [Display(Name = Literals.Name)]
        public string BusinessName { get; set; }
        [Display(Name = Literals.LocalBusinesses)]
        public List<LocalBusiness> LocalBusinesses { get; set; }
    }
}