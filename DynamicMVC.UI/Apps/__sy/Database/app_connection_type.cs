using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_database_connection_types")]//, Schema = "core")]
    // Ms-Sql Data Source
    // Oracle Data Source
    // My-Sql Data Source
    public class app_database_connection_type:base_entity_name_desc_systemname {

        public string connection_string_format { get; set; }

        public bool is_active { get; set; }

    }
}