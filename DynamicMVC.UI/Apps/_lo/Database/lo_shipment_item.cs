using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("lo_shipment_items")]
    public class lo_shipment_item : base_entity_name_desc {

        [MaxLength(500)]
        public string note { get; set; }

        // shipment item type
        [ForeignKey("shipment_item_type")]
        public int shipment_item_type_id { get; set; }
        [ForeignKey("shipment_item_type_id")]
        public lo_shipment_item_type shipment_item_type { get; set; }

        // unit amount
        public decimal unit_amount { get; set; }
    }
}