using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase.Default {
    public class AppProcessDatasource:BaseEntityNameDesc_IntegerId {
        
        public int AppProcessId { get; set; }
        public int AppDataSourceId { get; set; }

        public AppProcess AppProcess { get; set; }
        public AppDataSource AppDataSource { get; set; }

    }
}