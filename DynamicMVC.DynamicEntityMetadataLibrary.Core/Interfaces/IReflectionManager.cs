using System.Collections.Generic;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface IReflectionManager
    {
        IEnumerable<IReflectedDynamicClass> GetReflectedDynamicClasses();
    }
}