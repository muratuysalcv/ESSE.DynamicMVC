using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_invoice_post_types")]//, Schema = "core")]
    public class fi_invoice_post_type : base_entity_stringid_namedesc_systemname {

        // fatura türleri
        public static string printed_invoice = "printed_invoice";
        public static string e_invoice = "e_invoice";
        public static string digital_invoice = "digital_invoice";
        public static string e_archieve_invoice = "e_archieve_invoice";

    }
}