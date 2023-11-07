using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_table_default_value_types")]//, Schema = "core")]
    public class app_table_default_value_type : base_entity_name_desc {

        public int? app_table_columntype_id { get; set; }
        public app_table_columntype app_table_columntype { get; set; }
    }
}