using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class BaseEntity_IntegerId:BaseEntity {
        [Key]
        public int Id { get; set; }
    }
}