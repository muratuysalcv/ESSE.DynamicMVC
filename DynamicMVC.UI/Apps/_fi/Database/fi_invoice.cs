using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_invoices")]//, Schema = "core")]
    public class fi_invoice:base_entity {

        // prepared account
        [ForeignKey("from")]
        public int? from_id { get; set; }
        [ForeignKey("from_id")]
        public fi_account from { get; set; }

        public string test { get; set; }

        //target account
        [ForeignKey("to")]
        public int? to_id { get; set; }
        [ForeignKey("to_id")]
        public fi_account to { get; set; }

        public DateTime? delivery_date { get; set; }

        // fatura tarihi
        public DateTime? invoice_date { get; set; }

        // seri no
        [MaxLength(100)]
        public string serial_no { get; set; }
        // sıra no
        [MaxLength(100)]
        public string order_no { get; set; }

        // invoice status
        [ForeignKey("invoice_status")]
        public string invoice_status_id { get; set; }
        [ForeignKey("invoice_status_id")]
        public app_status invoice_status { get; set; }

        // account type
        [ForeignKey("account_type")]
        public string account_type_id { get; set; }
        [ForeignKey("account_type_id")]
        public fi_account_type account_type { get; set; }


        // payment type
        [ForeignKey("payment_type")]
        public string payment_type_id { get; set; }
        [ForeignKey("payment_type_id")]
        public fi_payment_type payment_type { get; set; }

        // invoice post type
        [ForeignKey("invoice_post_type")]
        public string invoice_post_type_id { get; set; }
        [ForeignKey("invoice_post_type_id")]
        public fi_invoice_post_type invoice_post_type { get; set; }


    }
}