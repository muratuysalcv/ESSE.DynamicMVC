using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class BaseEntityNameDesc_StringId : BaseEntity_StringId {

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}