using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_countries")]//, Schema = "core")]
    public class app_country:base_entity_name_desc_systemname {

        [MaxLength(5)]
        public string phone_code { get; set; }
    }
}