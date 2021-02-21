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
        [Display(Name = Literals.Active)]
        public bool Active { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Names)]
        public string Name { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.LastName1)]
        public string LastName1 { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.LastName2)]
        public string LastName2 { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Dob)]
        public DateTime Dob { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.ContractStart)]
        public DateTime ContractStart { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.PositionChange)]
        public bool PositionChange { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.HasStaff)]
        public bool HasStaff { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.Position)]
        public DateTime Position { get; set; }
        //////////////////////////////////////////////////////////
        [Required]
        [Display(Name = Literals.email)]
        public DateTime email { get; set; }
        //////////////////////////////////////////////////////////////
        [Display(Name = Literals.LanguageList)]
        public List<Language> LanguageList { get; set; }
        //////////////////////////////////////////////////////////////
        [Display(Name = Literals.Adress)]
        public string Adress { get; set; }
        //////////////////////////////////////////////////////////////
        [Display(Name = Literals.Experience)]
        public List<Experience> Experience { get; set; }
        
        
        
        

    }
}
