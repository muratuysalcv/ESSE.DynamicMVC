using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_users")]//, Schema = "core")]
    public class app_user:base_entity {
        
        //[Required]
        //public string first_name { get; set; }

        //[Required]
        //public string last_name { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string email_address { get; set; }

        [Required]
        public bool active { get; set; }

        public Guid userguid { get; set; }

        [Required]
        public DateTime create_date { get; set; }

    }
}