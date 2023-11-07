using System.Collections.Generic;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using ReflectionLibrary.Interfaces;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface IDynamicPropertyMetadataBuilder
    {
        IEnumerable<DynamicPropertyMetadata> Build(IReflectedClass reflectedClass, IEnumerable<IReflectedClass> reflectedClasses);
    }
}
