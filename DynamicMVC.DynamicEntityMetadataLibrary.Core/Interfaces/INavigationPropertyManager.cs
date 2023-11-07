using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using ReflectionLibrary.Interfaces;
using System.Collections.Generic;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface INavigationPropertyManager
    {
        DynamicForiegnKeyPropertyMetadata GetDynamicForiegnKeyPropertyMetadata(DynamicEntityMetadata dynamicEntityMetadata, DynamicComplexPropertyMetadata dynamicComplexPropertyMetadata);
        DynamicPropertyMetadata GetCollectionProperty(DynamicEntityMetadata dynamicEntityMetadata, DynamicPropertyMetadata dynamicPropertyMetadata);
        List<string> GetForiegnKeyNameByCollectionProperty(DynamicEntityMetadata entityMetadata, string typeName, DynamicCollectionEntityPropertyMetadata dynamicCollectionEntityPropertyMetadata);
        bool IsForeignKey(IReflectedProperty reflectedProperty, IReflectedClass reflectedClass);
    }
}