using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_modules")]//, Schema = "core")]
    public class app_module : base_entity_name_desc_systemname {

        public int? app_dashboard_id { get; set; }

        public virtual app_dashboard app_dashboard { get; set; }

        public virtual List<app_table> app_tables { get; set; }

        [Required]
        public int app_id { get; set; }
        
        public virtual app app { get; set; }

    }
}