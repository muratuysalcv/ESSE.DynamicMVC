using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {

    public class AppFileType:BaseEntityNameDescSystemName_StringId {

        public string MimeTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}