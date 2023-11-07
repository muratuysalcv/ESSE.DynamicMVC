using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_server_list")]//, Schema = "core")]
    public class app_server:base_entity_name_desc_systemname {

        [Required]
        public string ip_address { get; set; }

        public bool is_active { get; set; }
    }
}