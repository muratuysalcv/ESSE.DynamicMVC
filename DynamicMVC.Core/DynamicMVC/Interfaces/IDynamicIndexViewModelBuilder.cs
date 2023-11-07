using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicIndexViewModelBuilder
    {
        DynamicIndexViewModel Build(DynamicEntityMetadata dynamicEntityMetadata);
    }
}