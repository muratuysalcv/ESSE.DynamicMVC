using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_entity_relations")]//, Schema = "core")]
    // App Dashboard
    // Module Dashboard
    // 
    public class app_entity_relation : base_entity_name_desc {

        public DateTime create_date { get; set; }

        [MaxLength(150)]
        public string relation_name { get; set; }

        // any entity
        [MaxLength(150)]
        public string entity_name { get; set; }
        [MaxLength(150)]
        public string entity_id { get; set; }

        // related to entity
        [MaxLength(150)]
        public string entity_related_name { get; set; }
        [MaxLength(150)]
        public string entity_related_id { get; set; }

    }
}