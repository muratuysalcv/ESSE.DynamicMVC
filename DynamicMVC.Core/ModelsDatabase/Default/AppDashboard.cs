using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppDashboard:BaseEntityNameDescSystemName_IntegerId {

        public string PageSource { get; set; }
        public bool IsActive { get; set; }

        public int AppIconId { get; set; }
        public AppIcon AppIcon { get; set; }

    }
}