using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicDeleteViewModelBuilder
    {
        DynamicDeleteViewModel Build(DynamicEntityMetadata dynamicEntityMetadata, dynamic deleteModel, string returnUrl);
    }
}