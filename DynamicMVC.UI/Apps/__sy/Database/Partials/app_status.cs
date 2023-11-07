using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public partial class app_status {

        public static string activation_active = "activation_active";
        public static string activation_passive = "activation_passive";

        public static string availability_available = "availability_available";
        public static string availability_notavailable = "availability_notavailable";

        public static string level_high = "level_high";
        public static string level_normal = "level_normal";
        public static string level_low = "level_low";


    }
}