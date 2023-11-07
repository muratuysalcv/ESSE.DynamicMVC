using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_processes")]//, Schema = "core")]
    public partial class app_process:base_entity_name_desc_systemname {
        public app_process() {
            this.app_process_log = new HashSet<app_process_log>();
            this.app_process_datasource = new HashSet<app_process_datasource>();
        }

        // module info
        public int app_module_id { get; set; }
        public app_module app_module { get; set; }


        public string query { get; set; }
        public virtual ICollection<app_process_log> app_process_log { get; set; }
        public virtual ICollection<app_process_datasource> app_process_datasource { get; set; }

        [Required]
        public int app_process_type_id { get; set; }
        public app_process_type app_process_type { get; set; }
        
        public int? app_table_id { get; set; }
        public app_table app_table { get; set; }

        public int? app_table_column_id { get; set; }
        public app_table_column app_table_column { get; set; }
        
        public int? app_page_command_id { get; set; }
        public app_page_command app_page_command { get; set; }

        public int? app_id { get; set; }
        public app app { get; set; }

    }
}