using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_payment_types")]//, Schema = "core")]
    public class fi_payment_type : base_entity_stringid_namedesc_systemname {

        // ödeme türleri
        public static string credit_card = "credit_card";
        public static string mail_order = "mail_order";
        public static string future = "future";
        public static string cash = "cash";
    }
}