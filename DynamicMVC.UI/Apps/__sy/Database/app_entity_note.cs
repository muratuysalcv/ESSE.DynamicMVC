using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_entity_notes")]//, Schema = "core")]
    // App Dashboard
    // Module Dashboard
    // 
    public class app_entity_note : base_entity_name_desc {

        public DateTime create_date { get; set; }

        // entity name and id
        [MaxLength(150)]
        public string entity_name { get; set; }
        [MaxLength(150)]
        public string entity_id { get; set; }

    }
}