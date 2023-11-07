using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("mm_materials")]//, Schema = "core")]
    public class mm_material : base_entity_name_desc  {
        
        public DateTime create_date { get; set; }

        // category
        [ForeignKey("category")]
        public int category_id { get; set; }
        [ForeignKey("category_id")]
        public mm_material_group category { get; set; }

        // status
        [ForeignKey("material_status")]
        public string material_status_id { get; set; }
        [ForeignKey("material_status_id")]
        public app_status material_status { get; set; }

    }
}