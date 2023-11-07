using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class App:BaseEntityNameDescSystemName_IntegerId {
       
        public bool Active { get; set; }
        public string ConfigJson { get; set; }

        public int AppIconId { get; set; }
        public AppIcon AppIcon { get; set; }

        public int AppDefaultConnectionId { get; set; }
        public AppConnection AppDefaultConnection { get; set; }
    }
}