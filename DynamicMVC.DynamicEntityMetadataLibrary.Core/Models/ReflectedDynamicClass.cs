using DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces;
using ReflectionLibrary.Interfaces;
using ReflectionLibrary.Models;
#pragma warning disable 1591

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Models
{
    public class ReflectedDynamicClass : ReflectedClass, IReflectedDynamicClass
    {
        public ReflectedDynamicClass(IAttributeMergeManager attributeMergeManager) : base(attributeMergeManager)
        {
        }

        public IReflectedClass ControllerReflectedClass { get; set; }

        
    }
}
