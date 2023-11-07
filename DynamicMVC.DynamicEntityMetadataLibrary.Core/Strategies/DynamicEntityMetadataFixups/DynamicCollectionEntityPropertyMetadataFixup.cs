using System.Collections.Generic;
using System.Linq;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
// ReSharper disable PossibleMultipleEnumeration

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Strategies.DynamicEntityMetadataFixups
{
    public class DynamicCollectionEntityPropertyMetadataFixup : IDynamicEntityMetadataPropertyFixup
    {
        private readonly INavigationPropertyManager _navigationPropertyManager;

        public DynamicCollectionEntityPropertyMetadataFixup(INavigationPropertyManager navigationPropertyManager)
        {
            _navigationPropertyManager = navigationPropertyManager;
        }

        public void Fixup(IEnumerable<DynamicEntityMetadata> dynamicEntityMetadatas)
        {
            foreach (var dynamicEntityMetadata in dynamicEntityMetadatas)
            {
                //assign DynamicComplexPropertyMetadata property for each DynamicCollectionPropertyMetadata
                foreach (var dynamicPropertyMetadata in dynamicEntityMetadata.DynamicPropertyMetadatas)
                {
                    if (dynamicPropertyMetadata.GetType() == typeof(DynamicCollectionEntityPropertyMetadata))
                    {
                        var dynamicCollectionEntityPropertyMetadata = (DynamicCollectionEntityPropertyMetadata)dynamicPropertyMetadata;
                        var collectionDynamicEntityMetadata = dynamicEntityMetadatas.Single(x => x.TypeName() == dynamicCollectionEntityPropertyMetadata.CollectionItemTypeName());

                        //collectionEntityMetadata should have complex property of dynamicentity type or inverse property name
                        var foreignKeyNameList = _navigationPropertyManager.GetForiegnKeyNameByCollectionProperty(collectionDynamicEntityMetadata, dynamicEntityMetadata.TypeName(), dynamicCollectionEntityPropertyMetadata);
                        var foreignKeyName = foreignKeyNameList.FirstOrDefault();
                        dynamicCollectionEntityPropertyMetadata.ForiegnKeyPropertyName = foreignKeyName;
                    }
                }
            }
           
        }

        public int Order()
        {
            return 3;
        }
    }
}
