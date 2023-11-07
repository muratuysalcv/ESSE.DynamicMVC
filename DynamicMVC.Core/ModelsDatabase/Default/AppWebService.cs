using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppWebService:BaseEntityNameDesc_IntegerId {

        public int AppWebServiceTypeId { get; set; }

        public bool IsAuthRequired { get; set; }
        public string AuthUserName { get; set; }
        public string AuthPassword { get; set; }
        
        public AppWebServiceType AppWebServiceType { get; set; }
    }
}