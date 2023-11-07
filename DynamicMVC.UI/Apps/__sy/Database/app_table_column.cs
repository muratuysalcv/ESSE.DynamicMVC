using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_table_columns")]//, Schema = "core")]
    public class app_table_column:base_entity_name_desc_systemname {

        public int priority { get; set; }
        public bool is_nullable { get; set; }

        // table
        public int app_table_id { get; set; }
        public app_table app_table { get; set; }
        
        // value type
        public int app_table_columntype_id { get; set; }
        public app_table_columntype app_table_columntype { get; set; }


        // default value
        public int app_table_default_value_type_id { get; set; }
        public app_table_default_value_type app_table_default_value_type { get; set; }

        
    }
}