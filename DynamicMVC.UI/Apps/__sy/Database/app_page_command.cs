using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_page_commands")]//, Schema = "core")]
    public class app_page_command: base_entity_name_desc_systemname {

        public bool is_active { get; set; }
    }
}