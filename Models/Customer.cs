using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRRSupport.Models
{
    public class Customer {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<Language> LanguageList { get; set; }
        

    }
}
