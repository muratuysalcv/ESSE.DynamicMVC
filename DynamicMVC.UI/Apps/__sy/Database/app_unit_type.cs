using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB
{
    [Table(name:"app_unit_types")]
    public partial class app_unit_type: base_entity_stringid_namedesc_systemname
    {
        public string view_format { get; set; }

    }
}