using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_roles")]//, Schema = "core")]
    public class app_role : base_entity_name_desc_systemname {

        public bool active { get; set; }
    }
}