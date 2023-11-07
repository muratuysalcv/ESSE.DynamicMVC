using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {

    public class AppModule : BaseEntityNameDescSystemName_StringId {

        public int AppDashboardId { get; set; }

        public AppDashboard AppDashboard { get; set; }

        public List<AppTable> AppTables { get; set; }

    }
}