using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("lo_shipments")]
    public class lo_shipment : base_entity_name_desc {

        // shipping type
        [ForeignKey("shipment_type")]
        public int shipment_type_id { get; set; }
        [ForeignKey("shipment_type_id")]
        public lo_shipment_type shipment_type { get; set; }

    }
}