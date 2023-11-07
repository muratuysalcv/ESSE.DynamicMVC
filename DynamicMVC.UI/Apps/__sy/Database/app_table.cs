using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_tables")]//, Schema = "core")]
    public class app_table:base_entity_name_desc_systemname {

        // module
        public int app_module_id { get; set; }
        public app_module app_module { get; set; }

        // dashboard
        public int? app_dashboard_id { get; set; }
        public app_dashboard app_dashboard { get; set; }

        public int priority { get; set; }

    }
}