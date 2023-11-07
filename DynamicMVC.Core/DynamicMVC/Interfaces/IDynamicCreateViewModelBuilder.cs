using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicCreateViewModelBuilder
    {
        DynamicCreateViewModel Build(DynamicEntityMetadata dynamicEntityMetadata, dynamic createModel, string returnUrl);
    }
}