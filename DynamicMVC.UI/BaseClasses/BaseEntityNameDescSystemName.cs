using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public class base_entity_name_desc_systemname: base_entity {
       
        [Required]
        public string name { get; set; }

        [Required]
        [Index(IsClustered =true,IsUnique =true )]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string system_name { get; set; }

        [DataType(DataType.Text)]
        [MaxLength(4000)]
        public string description { get; set; }

    }
}