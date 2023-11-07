using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_web_services")]//, Schema = "core")]
    public class app_webservice:base_entity_name_desc {

        public int app_webservice_type_id { get; set; }

        public bool is_auth_required { get; set; }
        public string auth_username { get; set; }
        public string auth_password { get; set; }
        
        public app_webservice_type app_webservice_type { get; set; }
    }
}