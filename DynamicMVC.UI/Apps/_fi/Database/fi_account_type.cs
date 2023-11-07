using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [Table("fi_account_types")]//, Schema = "core")]
    public class fi_account_type : base_entity_stringid_namedesc_systemname {

    }
}