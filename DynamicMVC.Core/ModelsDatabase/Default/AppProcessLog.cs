using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {

    public partial class AppProcessLog:BaseEntityNameDesc_IntegerId {
       
        public int AppProcessId { get; set; }
        public int AppUserId { get; set; }

        public string UsedParameterInfo { get; set; }
        public string ExecutedQuery { get; set; }


        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorStackTrace { get; set; }

        public DateTime ExecutionDate { get; set; }

        public virtual AppProcess AppProcess { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}