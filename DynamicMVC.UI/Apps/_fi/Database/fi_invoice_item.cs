using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_invoice_items")]//, Schema = "core")]
    public class fi_invoice_item : base_entity_name_desc {

        [ForeignKey("invoice")]
        public int invoice_id { get; set; }
        [ForeignKey("invoice_id")]
        public fi_invoice invoice { get; set; }

        // invoice item type
        [ForeignKey("invoice_item_type")]
        public string invoice_item_type_id { get; set; }
        [ForeignKey("invoice_item_type_id")]
        public fi_invoice_item_type invoice_item_type { get; set; }

        // tax percentage
        public decimal tax_percentage { get; set; }

        // unit price
        public decimal price_unit_base { get; set; }
        public decimal price_unit_tax_included { get; set; }

        // total price
        public decimal price_total_base { get; set; }
        public decimal price_total_tax_included { get; set; }


        // unit based quantity
        public decimal amount_unit { get; set; }

        public DateTime delivery_date { get; set; }


        // invoice item status
        [ForeignKey("invoice_item_status")]
        public string invoice_item_status_id { get; set; }
        [ForeignKey("invoice_item_status_id")]
        public app_status invoice_item_status { get; set; }

        [MaxLength(150)]
        public string relational_entity_type { get; set; }
        [MaxLength(150)]
        public string relational_entity_id { get; set; }

    }
}