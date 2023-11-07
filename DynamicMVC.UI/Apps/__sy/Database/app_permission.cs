using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_permissions")]//, Schema = "core")]
    public partial class app_permission:base_entity {

        public string app_entity_type { get; set; }
        public int app_entity_id { get; set; }
        public int app_role_id { get; set; }

        public virtual app_role app_role { get; set; }
    }
}