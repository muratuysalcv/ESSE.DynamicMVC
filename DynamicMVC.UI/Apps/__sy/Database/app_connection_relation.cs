using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_connection_relations")]//, Schema = "core")]
    public class app_connection_relation:base_entity {

        public int app_id { get; set; }
        public app app { get; set; }

        public int app_connection_id { get; set; }
        public app_database_connection app_connection { get; set; }

        public bool is_active { get; set; }
    }
}