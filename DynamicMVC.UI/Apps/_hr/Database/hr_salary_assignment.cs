using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_salary_assignments")]//, Schema = "core")]
    public class hr_salary_assignment: base_entity   {

        // commecial account info
        [ForeignKey("fi_account")]
        public int fi_account_id { get; set; }
        [ForeignKey("fi_account_id")]
        public fi_account fi_account { get; set; }

        // start / end date
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }

        public decimal amount { get; set; }

        // currency
        [ForeignKey("currency")]
        public int currency_id { get; set; }
        [ForeignKey("currency_id")]
        public app_currency currency { get; set; }

        // user detail
        [ForeignKey("user_detail")]
        public int user_detail_id { get; set; }
        [ForeignKey("user_detail_id")]
        public hr_user_detail user_detail { get; set; }
    }
}