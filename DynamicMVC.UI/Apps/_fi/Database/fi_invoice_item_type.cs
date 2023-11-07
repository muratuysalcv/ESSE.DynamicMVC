using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_invoice_item_types")]//, Schema = "core")]
    public partial class fi_invoice_item_type : base_entity_stringid_namedesc_systemname {

        // unit type
        [ForeignKey("unit_type")]
        public string unit_type_id { get; set; }
        [ForeignKey("unit_type_id")]
        public app_unit_type unit_type { get; set; }

        // vergi oranı 18, 8 v.s
        public decimal tax_percentage { get; set; }

    }
}