using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.Interfaces;
using DynamicMVC.Core.DynamicMVC.ViewModels;

namespace DynamicMVC.Core.DynamicMVC.ViewModelBuilders
{
    public class DynamicDeleteViewModelBuilder : IDynamicDeleteViewModelBuilder
    {
        public DynamicDeleteViewModel Build(DynamicEntityMetadata dynamicEntityMetadata, dynamic deleteModel, string returnUrl)
        {
            var dynamicDeleteViewModel = new DynamicDeleteViewModel();
            dynamicDeleteViewModel.TypeName = dynamicEntityMetadata.TypeName();
            dynamicDeleteViewModel.Header = "Delete " + dynamicEntityMetadata.TypeName();
            dynamicDeleteViewModel.ReturnUrl = returnUrl;
            return dynamicDeleteViewModel;
        }
    }
}
