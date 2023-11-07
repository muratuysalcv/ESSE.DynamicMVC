using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_file_types")]//, Schema = "core")]
    public class app_file_type : base_entity_name_desc_systemname {

        public string mime_type_name { get; set; }
        public bool is_active { get; set; }
    }
}