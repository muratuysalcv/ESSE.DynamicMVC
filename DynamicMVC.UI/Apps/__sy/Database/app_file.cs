using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_files")]//, Schema = "core")]
    public class app_file:base_entity_name_desc {

        public string module_name { get; set; }
        public string entity_name { get; set; }
        public string entity_id { get; set; }

        public int app_file_category_id { get; set; }
        public app_file_category app_file_category { get; set; }

        public int app_file_type_id { get; set; }
        public app_file_type app_file_type { get; set; }
    }
}