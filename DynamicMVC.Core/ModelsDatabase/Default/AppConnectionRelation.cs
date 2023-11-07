using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppConnectionRelation:BaseEntity_IntegerId {

        public int AppId { get; set; }
        public App App { get; set; }

        public int AppConnectionId { get; set; }
        public AppConnection AppConnection { get; set; }

        public bool IsActive { get; set; }
    }
}