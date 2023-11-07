using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppFile:BaseEntityNameDesc_IntegerId {

        public string ModuleName { get; set; }
        public string EntityName { get; set; }
        public string EntityId { get; set; }

        public int AppFileCategoryId { get; set; }
        public AppFileCategory AppFileCategory { get; set; }

        public int AppFileTypeId { get; set; }
        public AppFileType AppFileType { get; set; }
    }
}