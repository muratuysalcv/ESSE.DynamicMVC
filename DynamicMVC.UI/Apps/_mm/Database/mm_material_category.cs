using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("mm_material_groups")]//, Schema = "core")]
    public class mm_material_group : base_entity_name_desc  {

        // parent category
        [ForeignKey("parent")]
        public int? parent_id { get; set; }
        [ForeignKey("parent_id")]
        public mm_material_group parent { get; set; }
    }
}