using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_jobs")]//, Schema = "core")]
    public class hr_job:base_entity_name_desc_systemname  {

        // parent job
        [ForeignKey("parent_job")]
        public int? parent_job_id { get; set; }
        [ForeignKey("parent_job_id")]
        public hr_job parent_job { get; set; }

    }
}