using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_navigations")]//, Schema = "core")]
    public class app_navigation : base_entity_name_desc_systemname {


        // use url
        public string url { get; set; }
        public bool use_url { get; set; }

        // parent navigation
        [ForeignKey("parent_navigation")]
        public int? parent_navigation_id { get; set; }
        [ForeignKey("parent_navigation_id")]
        public virtual app_navigation parent_navigation { get; set; }

        // app dashboard
        [ForeignKey("app_dashboard")]
        public int? app_dashboard_id { get; set; }
        [ForeignKey("app_dashboard_id")]
        public virtual app_dashboard app_dashboard { get; set; }

        // app
        [ForeignKey("app")]
        public int? app_id { get; set; }
        [ForeignKey("app_id")]
        public virtual app app { get; set; }

        // app module
        [ForeignKey("app_module")]
        public int? app_module_id { get; set; }
        [ForeignKey("app_module_id")]
        public virtual app_module app_module { get; set; }

        // app activation status
        [ForeignKey("activation_status")]
        public string activation_status_id { get; set; }
        [ForeignKey("activation_status_id")]
        public virtual app_status activation_status { get; set; }

        // app icon 
        [ForeignKey("app_icon")]
        public string app_icon_id { get; set; }
        [ForeignKey("app_icon_id")]
        public app_icon app_icon { get; set; }
    }
}