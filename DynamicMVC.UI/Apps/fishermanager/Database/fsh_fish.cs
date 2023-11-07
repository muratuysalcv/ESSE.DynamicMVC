using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace DynamicMVC.UI.Apps.fishermanager.Database {
    [Table("fsh_fish")]
    public class fsh_fish : base_entity_name_desc_systemname {

        public int count { get; set; }
        public DateTime create_date { get; set; }
        public int fsh_fish_type_id { get; set; }
        public fsh_fish_type fsh_fish_type { get; set; }

    }
}