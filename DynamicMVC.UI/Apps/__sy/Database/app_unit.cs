using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB
{
    [Table(name: "app_units")]
    public class app_unit : base_entity_stringid_namedesc_systemname
    {
        public decimal unit_value { get; set; }

        public string prefix { get; set; }

        public string suffix { get; set; }

        [ForeignKey("app_unit_type")]
        public string app_unit_type_id { get; set; }

        [ForeignKey("app_unit_type_id")]
        public virtual app_unit_type app_unit_type { get;set;}
    }
}