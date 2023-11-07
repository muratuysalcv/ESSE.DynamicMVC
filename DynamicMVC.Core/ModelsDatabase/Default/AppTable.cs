using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppTable:BaseEntityNameDescSystemName_IntegerId {

        // module
        public int AppModuleId { get; set; }
        public AppModule AppModule { get; set; }

        // dashboard
        public int? AppDashboardId { get; set; }
        public AppDashboard AppDashboard { get; set; }

        public int Priority { get; set; }

    }
}