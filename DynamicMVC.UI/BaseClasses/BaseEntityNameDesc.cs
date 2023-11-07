using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public class base_entity_name_desc: base_entity {
       
        [Required]
        public string name { get; set; }

        public string description { get; set; }
    }
}