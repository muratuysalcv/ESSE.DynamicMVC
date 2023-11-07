using System;
using System.Collections.Generic;
using System.Linq;
using DynamicMVC.DynamicEntityMetadataLibrary.Interfaces;
using DynamicMVC.DynamicEntityMetadataLibrary.Models;
using DynamicMVC.Shared.Interfaces;

// ReSharper disable PossibleMultipleEnumeration

namespace DynamicMVC.DynamicEntityMetadataLibrary.Strategies.DynamicEntityMetadataFixups {
    public class DynamicForiegnKeyPropertyMetadataFixup : IDynamicEntityMetadataPropertyFixup {
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
                    try
                    {
                        dynamicProperty.ComplexEntityPropertyMetadata = dynamicEntityMetadata.DynamicPropertyMetadatas.Single(x => x.IsDynamicEntity() && _namingConventionManager.GetForiegnKeyByComplexProperty(dynamicEntityMetadata.TypeName(), x.PropertyName()).Contains(dynamicProperty.PropertyName()));
                    }
                    catch (System.Exception ex)
                    {
                        throw new  Exception(dynamicEntityMetadata.ReflectedClass.Name+" tablosundaki " + dynamicProperty.PropertyName() + " foreign key tanýmlamalarýný kontrol ediniz."+ex.Message);
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
