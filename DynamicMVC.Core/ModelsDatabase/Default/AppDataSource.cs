using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppDataSource:BaseEntityNameDesc_IntegerId {

        public string Parameters { get; set; }
        public string Query { get; set; }
        public string Config { get; set; }
    }
}