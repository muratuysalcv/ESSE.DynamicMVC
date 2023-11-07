using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    public partial class app_icon {

        public static app_icon fa_fish = new app_icon()
        {
            id = "fa_fish",
            name = "Material fish",
            icon_info = "fish",
            icon_type_id = app_icon_type.font_awesome.id
        };

    }
}