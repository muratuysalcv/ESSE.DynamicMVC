using System.Collections.Generic;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using ReflectionLibrary.Interfaces;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface IDynamicEntityMetadataBuilder
    {
        IEnumerable<DynamicEntityMetadata> Build(IEnumerable<IReflectedDynamicClass> reflectedClasses);
    }
}