using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public class AppLanguageWord : BaseEntity_IntegerId {

        public string ResourceKey { get; set; }
        public string ResourceValue { get; set; }
        public string AppLanguageId { get; set; }
        public AppLanguage AppLanguage { get; set; }
    }
}