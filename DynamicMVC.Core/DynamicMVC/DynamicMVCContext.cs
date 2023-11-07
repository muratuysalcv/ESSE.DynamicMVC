using System;
using System.Collections.Generic;
using System.Linq;
using DynamicMVC.Core.DynamicMVC.Interfaces;

namespace DynamicMVC.Core.DynamicMVC
{
    public static class DynamicMVCContext
    {
        static DynamicMVCContext()
        {
            Options = new DynamicMVCContextOptions();
        }

        public static DynamicMVCContextOptions Options { get; set; }

        public static IEnumerable<DynamicEntityMetadataLibrary.Core.Models.DynamicEntityMetadata> DynamicEntityMetadatas { get; set; }
        
        public static IEnumerable<Type> DynamicFilterViewModels { get; set; }

        public static DynamicEntityMetadataLibrary.Core.Models.DynamicEntityMetadata GetDynamicEntityMetadata(string typeName)
        {
            return DynamicEntityMetadatas.Single(x => x.TypeName() == typeName);
        }

        public static IDynamicMvcManager DynamicMvcManager;
    }
}
