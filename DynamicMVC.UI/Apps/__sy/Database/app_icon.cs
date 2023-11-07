using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_icons")]//, Schema = "core")]
    public partial class app_icon : base_entity_stringid  {

        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(500)]
        public string icon_info { get; set; }

        // icon type
        [ForeignKey("icon_type")]
        public string icon_type_id { get; set; }
        [ForeignKey("icon_type_id")]
        public app_icon_type icon_type { get; set; }
    }
}