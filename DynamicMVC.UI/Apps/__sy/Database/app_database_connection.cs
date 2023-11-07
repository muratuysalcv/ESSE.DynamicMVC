using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_database_connections")]//, Schema = "core")]
    public class app_database_connection:base_entity_name_desc {

        public string database_name { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public bool is_active { get; set; }

        public int port { get; set; }

        [Required]
        public int app_database_connection_type_id { get; set; }
        public app_database_connection_type app_database_connection_type { get; set; }

        [Required]
        public int app_server_id { get; set; }
        public app_server app_server { get; set; }
    }
}