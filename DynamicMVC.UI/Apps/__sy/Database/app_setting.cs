using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB
{
    [Table(name:"app_settings")]
    public class app_setting: base_entity_name_desc_systemname
    {
        public string setting_value { get; set; }
    }
}