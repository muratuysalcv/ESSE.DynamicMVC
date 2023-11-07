using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_process_logs")]//, Schema = "core")]
    public partial class app_process_log:base_entity_name_desc {
       
        public int app_process_id { get; set; }
        public int app_user_id { get; set; }

        public string used_parameter_info { get; set; }
        public string executed_query { get; set; }


        public bool is_success { get; set; }
        public string error_message { get; set; }
        public string error_stacktrace { get; set; }

        public DateTime execution_date { get; set; }

        public virtual app_process app_process { get; set; }
        public virtual app_user app_user { get; set; }
    }
}