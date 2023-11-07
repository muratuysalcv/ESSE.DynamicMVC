using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_organization")]//, Schema = "core")]
    public class hr_organization:base_entity_name_desc  {

        // commecial account id
        [ForeignKey("fi_account")]
        public int fi_account_id { get; set; }
        [ForeignKey("fi_account_id")]
        public fi_account fi_account { get; set; }

        public DateTime create_date { get; set; }


        // start / end dates
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }

        // organization
        [ForeignKey("parent_organization")]
        public int? parent_organization_id { get; set; }
        [ForeignKey("parent_organization_id")]
        public hr_organization parent_organization { get; set; }
    }
}