using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("hr_user_details")]//, Schema = "core")]
    [DynamicEntity(Key = "id")]
    public class hr_user_detail  {

        [Key]
        public int id { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        public string identity_code { get; set; }

        // natinality
        [ForeignKey("national_country")]
        public int national_country_id { get; set; }
        [ForeignKey("national_country_id")]
        public app_country national_country { get; set; }

        // gender
        [ForeignKey("gender")]
        public string gender_id  { get; set; }
        [ForeignKey("gender_id")]
        public hr_gender gender { get; set; }
        
        // main language
        [ForeignKey("main_language")]
        public int main_language_id { get; set; }
        [ForeignKey("main_language_id")]
        public app_language main_language { get; set; }

        // job
        [ForeignKey("job")]
        public int job_id { get; set; }
        [ForeignKey("job_id")]
        public hr_job job { get; set; }

        // marriage statuses
        [ForeignKey("marriage_status")]
        public string marriage_status_id { get; set; }
        [ForeignKey("marriage_status_id")]
        public hr_marriage_status marriage_status { get; set; }

        // birth date
        public DateTime birth_date { get; set; }

    }
}