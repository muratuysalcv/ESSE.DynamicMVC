using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_transaction_types")]//, Schema = "core")]
    public class fi_transaction_type : base_entity_stringid_namedesc_systemname {

        public static string outcome = "outgoing";
        public static string income = "income";
        public static string income_sale = "income_sale";
        public static string outgoing_buy = "outgoing_buy";
        public static string outgoing_salary = "outgoing_salary";
    }
}