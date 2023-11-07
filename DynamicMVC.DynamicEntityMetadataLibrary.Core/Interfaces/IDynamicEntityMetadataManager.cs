using System.Collections.Generic;
using ReflectionLibrary.Interfaces;
#pragma warning disable 1591

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface IDynamicEntityMetadataManager
    {
        IEnumerable<Models.DynamicEntityMetadata> GetDynamicEntityMetadatas();
        IEnumerable<Models.DynamicEntityMetadata> GetDynamicEntityMetadatas(IEnumerable<IReflectedDynamicClass> reflectedClasses);
    }
}