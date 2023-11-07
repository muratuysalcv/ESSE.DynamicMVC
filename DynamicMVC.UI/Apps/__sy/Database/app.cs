using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_bases")]
    public class app : base_entity_name_desc_systemname {

        public bool is_active { get; set; }
        public string config_json { get; set; }

        // app icon
        [ForeignKey("app_icon")]
        public string app_icon_id { get; set; }
        [ForeignKey("app_icon_id")]
        public app_icon app_icon { get; set; }

        // app default connection
        [ForeignKey("app_default_database_connection")]
        public int? app_default_database_connection_id { get; set; }
        [ForeignKey("app_default_database_connection_id")]
        public app_database_connection app_default_database_connection { get; set; }
    }

   
}