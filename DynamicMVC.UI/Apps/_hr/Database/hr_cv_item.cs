using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_cv_items")]//, Schema = "core")]
    public class hr_cv_item:base_entity_name_desc  {

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

        // location information
        public string location_name { get; set; }

        public string department { get; set; }

        // value fields - > average note, salary
        public int value_integer { get; set; }
        public string value_text { get; set; }

        // start / end date
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }

        public int order_no { get; set; }

        // item type
        [ForeignKey("item_type")]
        public int item_type_id { get; set; }
        [ForeignKey("item_type_id")]
        public hr_cv_item_type item_type { get; set; }
    }
}