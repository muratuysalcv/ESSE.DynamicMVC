using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {

    [DynamicEntity]
    public class AppUser {

        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public bool Active { get; set; }

        public Guid UserGuid { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

    }
}