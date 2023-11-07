using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_dashboards")]//, Schema = "core")]
    public class app_dashboard:base_entity_name_desc_systemname {

        [DataType(DataType.MultilineText)]
        public string page_source { get; set; }
        public bool is_active { get; set; }

        [ForeignKey("app_icon")]
        public string app_icon_id { get; set; }
        [ForeignKey("app_icon_id")]
        public app_icon app_icon { get; set; }


    }
}