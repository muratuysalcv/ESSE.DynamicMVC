using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_phones")]//, Schema = "core")]
    public class app_phone : base_entity {

        [MaxLength(5)]
        public string country_code { get; set; }

        [MaxLength(15)]
        public string phone_number { get; set; }
        public DateTime create_date { get; set; }

        // phone type
        [ForeignKey("phone_type")]
        public int phone_type_id { get; set; }
        [ForeignKey("phone_type_id")]
        public app_phone_type phone_type { get; set; }

        // owner
        public int owner_id { get; set; }
        [MaxLength(150)]
        public string owner_type { get; set; }
        public DateTime? delete_date { get; set; }
    }
}