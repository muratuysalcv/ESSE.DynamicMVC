using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_transactions")]//, Schema = "core")]
    [DynamicEntity(Key = "id")]
    public class fi_transaction:base_entity {

        // işlem hangi hesap ile ilgili o yazılır
        [ForeignKey("fi_account")]
        public int fi_account_id { get; set; }
        [ForeignKey("fi_account_id")]
        public fi_account fi_account { get; set; }

        // finasal kaynak hedef hesap bilgisi
        [ForeignKey("fi_target_account")]
        public int? fi_target_account_id { get; set; }
        [ForeignKey("fi_target_account_id")]
        public fi_account fi_target_account { get; set; }

        // + ise gelir, - ise giderdir.
        public decimal amount { get; set; }

        // işlemin gerçekleştiği tarih
        public DateTime execution_date { get; set; }

        // transaction status
        [ForeignKey("fi_transaction_status")]
        public string fi_transaction_status_id { get; set; }
        [ForeignKey("fi_transaction_status_id")]
        public app_status fi_transaction_status { get; set; }

        // transaction type
        [ForeignKey("fi_transaction_type")]
        public string fi_transaction_type_id { get; set; }
        [ForeignKey("fi_transaction_type_id")]
        public fi_transaction_type fi_transaction_type { get; set; }

        // payment type
        [ForeignKey("payment_type")]
        public string payment_type_id { get; set; }
        [ForeignKey("payment_type_id")]
        public fi_payment_type payment_type { get; set; }

    }
}