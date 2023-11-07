using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("mm_material_types")]//, Schema = "core")]
    public class mm_material_type : base_entity_stringid_namedesc_systemname  {

        // bir materyal türü varsayılan olarak bir kategoride bulunması sağlanmak
        // isternise tanımlanabilir.
        [ForeignKey("default_category")]
        public int? default_category_id { get; set; }
        [ForeignKey("default_category_id")]
        public mm_material_group default_category { get; set; }

        // unit type
        [ForeignKey("unit_type")]
        public string unit_type_id { get; set; }
        [ForeignKey("unit_type_id")]
        public app_unit_type unit_type { get; set; }

    }
}