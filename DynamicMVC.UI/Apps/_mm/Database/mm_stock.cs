using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("mm_stocks")]//, Schema = "core")]
    public class mm_stock : base_entity_name_desc  {

        // oluşturma tarihi
        public DateTime create_date { get; set; }

        // stoğa alım işlemi tarihi
        public DateTime execution_date { get; set; }

        // material
        [ForeignKey("material")]
        public int material_id { get; set; }
        [ForeignKey("material_id")]
        public mm_material material { get; set; }

        // miktar
        public decimal amount { get; set; }

        // transaction
        [ForeignKey("transaction")]
        public int? transaction_id { get; set; }
        [ForeignKey("transaction_id")]
        public fi_transaction transaction { get; set; }
    }
}