using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicEditViewModelBuilder
    {
        DynamicEditViewModel Build(DynamicEntityMetadata dynamicEntityMetadata, dynamic editModel, string returnUrl);
    }
}