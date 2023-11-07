using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppTableColumn:BaseEntityNameDescSystemName_IntegerId {

        public int Priority { get; set; }
        public bool IsNullable { get; set; }

        // table
        public int AppTableId { get; set; }
        public AppTable AppTable { get; set; }
        
        // value type
        public int AppTableSqlValueTypeId { get; set; }
        public AppTableSqlValueType AppTableSqlValueType { get; set; }


        // default value
        public int AppTableDefaultValueTypeId { get; set; }
        public AppTableDefaultValueType AppTableDefaultValueType { get; set; }

        
    }
}