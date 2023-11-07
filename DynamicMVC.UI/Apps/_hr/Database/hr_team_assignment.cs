using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_team_assignments")]//, Schema = "core")]
    public class hr_team_assignment : base_entity_name_desc_systemname  {

        // user detail
        [ForeignKey("user_detail")]
        public int user_detail_id { get; set; }
        [ForeignKey("user_detail_id")]
        public hr_user_detail user_detail { get; set; }

        // job
        [ForeignKey("job")]
        public int job_id { get; set; }
        [ForeignKey("job_id")]
        public hr_job job { get; set; }

        // team
        [ForeignKey("team")]
        public int team_id { get; set; }
        [ForeignKey("team_id")]
        public hr_team team { get; set; }

        // dates
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }

        // team leader
        [ForeignKey("leader")]
        public int leader_id { get; set; }
        [ForeignKey("leader_id")]
        public hr_user_detail leader { get; set; }

        // organization
        [ForeignKey("organization")]
        public int? organization_id { get; set; }
        [ForeignKey("organization_id")]
        public hr_organization organization  { get; set; }
    }
}