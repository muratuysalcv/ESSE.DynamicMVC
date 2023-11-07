using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("lo_shipment_item_types")]
    public class lo_shipment_item_type : base_entity_name_desc {

        // unit type
        [ForeignKey("unit_type")]
        public string unit_type_id { get; set; }
        [ForeignKey("unit_type_id")]
        public app_unit_type unit_type { get; set; }
    }
}