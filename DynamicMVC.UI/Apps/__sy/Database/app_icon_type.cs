using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_icon_types")]//, Schema = "core")]
    public partial class app_icon_type : base_entity_stringid  {

        [MaxLength(150)]
        public string name { get; set; }

        [MaxLength(500)]
        public string html_format { get; set; }
    }
}