using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB
{
    [Table(name: "app_statuses")]
    public partial class app_status : base_entity_stringid_namedesc_systemname
    {
        public string status_value { get; set; }

        public string prefix { get; set; }

        public string suffix { get; set; }

        [ForeignKey("app_status_type")]
        public string app_status_type_id { get; set; }

        [ForeignKey("app_status_type_id")]
        public virtual app_status_type app_status_type { get;set;}
    }
}