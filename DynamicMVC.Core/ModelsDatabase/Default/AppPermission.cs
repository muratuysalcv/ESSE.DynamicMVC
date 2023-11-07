using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    
    public partial class AppPermission:BaseEntity_IntegerId {

        public string AppEntityType { get; set; }
        public int AppEntityId { get; set; }
        public int AppRoleId { get; set; }

        public virtual AppRole AppRole { get; set; }
    }
}