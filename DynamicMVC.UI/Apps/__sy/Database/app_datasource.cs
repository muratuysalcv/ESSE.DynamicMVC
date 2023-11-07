using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_datasources")]//, Schema = "core")]
    public class app_datasource:base_entity_name_desc {

        public string parameters { get; set; }
        public string query { get; set; }
        public string config { get; set; }
        
        // app connection
        // if null, use app connection source
        public int? app_database_connection_id { get; set; }
        public app_database_connection app_database_connection { get; set; }

        public int? app_id { get; set; }
        public app app { get; set; }

        public int? app_module_id { get; set; }
        public app_module app_module { get; set; }

    }
}