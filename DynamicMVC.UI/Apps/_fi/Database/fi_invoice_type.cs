using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_invoice_types")]//, Schema = "core")]
    public class fi_invoice_type : base_entity_stringid_namedesc_systemname {

        // fatura türleri
        public static string sale_invoice = "sale_invoice";
        public static string waybill_invoice = "waybill_invoice";
        public static string proforma_invoice = "proforma_invoice";
        public static string return_invoice = "return_invoice";

    }
}