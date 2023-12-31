using System.Collections.Generic;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Strategies.DynamicEntityMetadataFixups
{
    public class DynamicComplexEntityPropertyMetadataFixup : IDynamicEntityMetadataPropertyFixup
    {
        private readonly INavigationPropertyManager _navigationPropertyManager;

        public DynamicComplexEntityPropertyMetadataFixup(INavigationPropertyManager navigationPropertyManager)
        {
            _navigationPropertyManager = navigationPropertyManager;
        }

        public void Fixup(IEnumerable<DynamicEntityMetadata> dynamicEntityMetadatas)
        {
            foreach (var dynamicEntityMetadata in dynamicEntityMetadatas)
            {
                //assign DynamicForiegnKeyPropertyMetadata property for each DynamicComplexPropertyMetadata
                foreach (var dynamicPropertyMetadata in dynamicEntityMetadata.DynamicPropertyMetadatas)
                {
                    if (dynamicPropertyMetadata.GetType() == typeof(DynamicComplexPropertyMetadata))
                    {
                        var dynamicComplexEntityPropertyMetadata = (DynamicComplexPropertyMetadata)dynamicPropertyMetadata;
                        dynamicComplexEntityPropertyMetadata.DynamicForiegnKeyPropertyMetadata = _navigationPropertyManager.GetDynamicForiegnKeyPropertyMetadata(dynamicEntityMetadata, dynamicComplexEntityPropertyMetadata);
                    }
                }
            }
        }

        public int Order()
        {
            return 2;
        }
    }
}
