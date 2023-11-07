using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB
{
    [Table(name:"app_status_types")]
    public partial class app_status_type: base_entity_stringid_namedesc_systemname
    {
    }
}