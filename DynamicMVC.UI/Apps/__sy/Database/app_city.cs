using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_cities")]//, Schema = "core")]
    public class app_city:base_entity_name_desc_systemname {

        [Required]
        [MaxLength(10)]
        public string city_code { get; set; }

        // country
        [ForeignKey("country")]
        public int country_id { get; set; }
        [ForeignKey("country_id")]
        public app_country country { get; set; }
    }
}