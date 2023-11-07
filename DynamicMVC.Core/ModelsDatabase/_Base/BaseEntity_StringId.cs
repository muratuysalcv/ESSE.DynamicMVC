using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class BaseEntity_StringId: BaseEntity {
        [Key]
        [Required]
        public string Id { get; set; }
    }
}