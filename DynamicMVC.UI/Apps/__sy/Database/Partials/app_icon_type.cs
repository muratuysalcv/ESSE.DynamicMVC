using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    public partial class app_icon_type {

        public static app_icon_type font_awesome = new app_icon_type()
        {
            id = "font_awesome",
            name = "Font Awesome",
            html_format = "<i class='fa fa-{icon_info}'></i>"
        };

        public static app_icon_type material_icons = new app_icon_type()
        {
            id = "material_icons",
            name = "Material",
            html_format = "<i class='material-icons'>{icon_info}</i>"
        };
    }
}