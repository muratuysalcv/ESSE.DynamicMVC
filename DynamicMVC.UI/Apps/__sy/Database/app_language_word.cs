using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("app_language_words")]//, Schema = "core")]
    public class app_language_word : base_entity {

        public string resource_key { get; set; }
        public string resource_value { get; set; }
        public int app_language_id { get; set; }
        public app_language app_language { get; set; }
    }
}