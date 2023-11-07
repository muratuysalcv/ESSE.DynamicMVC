using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_permission_assignments")]//, Schema = "core")]
    public class hr_permission_assignment:base_entity   {

        // user
        [ForeignKey("user_detail")]
        public int user_detail_id { get; set; }
        [ForeignKey("user_detail_id")]
        public hr_user_detail user_detail { get; set; }

        
        public DateTime create_date { get; set; }

        // start / end dates
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }

    }
}