using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {

    public partial class AppProcess:BaseEntityNameDescSystemName_IntegerId {
        public AppProcess() {
            this.AppProcessLog = new HashSet<AppProcessLog>();
        }

        // module info
        public int AppModuleId { get; set; }
        public AppModule AppModule { get; set; }


        public string Query { get; set; }
        public virtual ICollection<AppProcessLog> AppProcessLog { get; set; }

    }
}