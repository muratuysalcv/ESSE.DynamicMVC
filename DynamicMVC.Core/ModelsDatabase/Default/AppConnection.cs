using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppConnection:BaseEntityNameDesc_IntegerId {

        public string ConnectionText { get; set; }

        [Required]
        public string AppConnectionTypeId { get; set; }
        public AppConnectionType AppConnectionType { get; set; }
    }
}