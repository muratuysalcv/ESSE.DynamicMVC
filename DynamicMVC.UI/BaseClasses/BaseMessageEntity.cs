using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public class BaseMessageEntity:base_entity {

        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ReadDate { get; set; }

        public string FromEntityName { get; set; }
        public int? FromEntityId { get; set; }

        public string ToEntityName { get; set; }
        public int? ToEntityId { get; set; }

        public bool Delete { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}