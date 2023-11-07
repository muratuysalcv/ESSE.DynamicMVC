using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_accounts")]//, Schema = "core")]
    public class fi_account:base_entity {

        [MaxLength(250)]
        public string commercial_title { get; set; }

        [MaxLength(100)]
        public string tax_identity { get; set; }

        [MaxLength(250)]
        public string tax_office { get; set; }

        // adress
        [ForeignKey("address")]
        public int address_id { get; set; }
        [ForeignKey("address_id")]
        public app_address address { get; set; }

        [MaxLength(250)]
        public string email { get; set; }
        public int owner_id { get; set; }

        [MaxLength(150)]
        public string owner_type { get; set; }
        public DateTime delete_date { get; set; }

        // account status
        [ForeignKey("account_status")]
        public string account_status_id { get; set; }
        [ForeignKey("account_status_id")]
        public app_status account_status { get; set; }

        // eksi ise borçlu, + ise alacaklı
        public decimal amount_summary { get; set; }

        // account type
        [ForeignKey("account_type")]
        public string account_type_id { get; set; }
        [ForeignKey("account_type_id")]
        public fi_account_type account_type { get; set; }

        // invoice post type
        [ForeignKey("invoice_post_type")]
        public string invoice_post_type_id { get; set; }
        [ForeignKey("invoice_post_type_id")]
        public fi_invoice_post_type invoice_post_type { get; set; }

    }
}