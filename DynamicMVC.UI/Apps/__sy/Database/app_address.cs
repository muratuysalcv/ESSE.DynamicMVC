using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_addresses")]//, Schema = "core")]
    public class app_address:base_entity_name_desc   {

        [MaxLength(10)]
        public string postal_code { get; set; }

        [MaxLength(150)]
        public string city_location { get; set; }

        [MaxLength(500)]
        public string address_detail { get; set; }

        // country
        [ForeignKey("country")]
        public int country_id { get; set; }
        [ForeignKey("country_id")]
        public app_country country { get; set; }

        // city
        [ForeignKey("city")]
        public int city_id { get; set; }
        [ForeignKey("city_id")]
        public app_city city { get; set; }


        public DateTime create_date { get; set; }
        [MaxLength(100)]
        public string create_source { get; set; }

        // address type
        [ForeignKey("address_type")]
        public int address_type_id { get; set; }
        [ForeignKey("address_type_id")]
        public app_address_type address_type { get; set; }

        public int owner_id { get; set; }

        [MaxLength(150)]
        public string owner_type { get; set; }

        public DateTime? delete_date { get; set; }

    }
}