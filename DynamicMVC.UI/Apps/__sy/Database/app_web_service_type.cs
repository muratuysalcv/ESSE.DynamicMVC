using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_webservice_types")]//, Schema = "core")]
    public class app_webservice_type: base_entity_name_desc {

        public string result_type { get; set; }

    }
}