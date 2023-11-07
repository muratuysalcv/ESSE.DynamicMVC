using DynamicMVC.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    [DynamicEntity(Key = "id")]
    public class base_entity {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Index(IsClustered =true,IsUnique =true,Order =0)]
        public int id { get; set; }
    }

    [DynamicEntity(Key = "id")]
    public class base_entity_stringid
    {
        [Key]
        //[Index(IsClustered =true,IsUnique =true,Order =0)]
        public string id { get; set; }
    }

    [DynamicEntity(Key = "id")]
    public class base_entity_stringid_namedesc_systemname
    {
        [Key]
        //[Index(IsClustered =true,IsUnique =true,Order =0)]
        [MaxLength(100)]
        public string id { get; set; }

        [DataType(DataType.Text)]
       // [Column(TypeName = "varchar2")]
        [MaxLength(100)]
        public string name { get; set; }


        [DataType(DataType.Text)]
       // [Column(TypeName = "varchar2")]
        [MaxLength(4000)]
        public string description { get; set; }

        [DataType(DataType.Text)]
       // [Column(TypeName = "varchar2")]
        [MaxLength(100)]
        public string system_name { get; set; }

    }

}