using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_process_datasources")]//, Schema = "core")]
    public class app_process_datasource:base_entity_name_desc {

        public int app_process_id { get; set; }
        public int app_datasource_id { get; set; }

        public app_process app_process { get; set; }
        public app_datasource app_datasource { get; set; }
    }
}