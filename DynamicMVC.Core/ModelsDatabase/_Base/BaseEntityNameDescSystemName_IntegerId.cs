using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class BaseEntityNameDescSystemName_IntegerId: BaseEntity_IntegerId {
       
        [Required]
        public string Name { get; set; }

        [Required]
        public string SystemName { get; set; }

        public string Description { get; set; }

    }
}