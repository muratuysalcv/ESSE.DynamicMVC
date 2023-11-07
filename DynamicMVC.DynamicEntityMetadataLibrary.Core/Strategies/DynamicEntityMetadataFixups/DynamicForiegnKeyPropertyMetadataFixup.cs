using System.Collections.Generic;
using System.Linq;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Shared.Interfaces;

// ReSharper disable PossibleMultipleEnumeration

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Strategies.DynamicEntityMetadataFixups
{
    public class DynamicForiegnKeyPropertyMetadataFixup : IDynamicEntityMetadataPropertyFixup
    {
        private readonly INamingConventionManager _namingConventionManager;

        public DynamicForiegnKeyPropertyMetadataFixup(INamingConventionManager namingConventionManager)
        {
            _namingConventionManager = namingConventionManager;
        }

        public void Fixup(IEnumerable<DynamicEntityMetadata> dynamicEntityMetadatas)
        {
            foreach (var dynamicEntityMetadata in dynamicEntityMetadatas)
            {
                foreach (var dynamicProperty in dynamicEntityMetadata.DynamicPropertyMetadatas.OfType<DynamicForiegnKeyPropertyMetadata>())
                {
                    try {
                        dynamicProperty.ComplexEntityPropertyMetadata = dynamicEntityMetadata.DynamicPropertyMetadatas.Single(x => x.IsDynamicEntity() && _namingConventionManager.GetForiegnKeyByComplexProperty(dynamicEntityMetadata.TypeName(), x.PropertyName()).Contains(dynamicProperty.PropertyName()));

                    } catch (System.Exception ex) {
                        throw ex;
                    }
                }
                
                foreach (var dynamicProperty in dynamicEntityMetadata.DynamicPropertyMetadatas.OfType<DynamicForiegnKeyPropertyMetadata>())
                {
                    dynamicProperty.ComplexDynamicEntityMetadata = dynamicEntityMetadatas.Single(x => x.TypeName() == dynamicProperty.ComplexEntityPropertyMetadata.TypeName());
                }
            }
        }

        public int Order()
        {
            return 1;
        }
    }
}
