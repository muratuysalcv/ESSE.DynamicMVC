using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_cv_list")]//, Schema = "core")]
    public class hr_cv : base_entity  {

        public string first_name { get; set; }
        public string last_name { get; set; }

        // country
        [ForeignKey("country")]
        public int country_id { get; set; }
        [ForeignKey("country_id")]
        public app_country country { get; set; }

        // result
        public DateTime create_date { get; set; }
        public DateTime? result_date { get; set; }
        public string result_note { get; set; }

        // status
        [ForeignKey("cv_status")]
        public string cv_status_id { get; set; }
        [ForeignKey("cv_status_id")]
        public app_status cv_status { get; set; }

    }
}