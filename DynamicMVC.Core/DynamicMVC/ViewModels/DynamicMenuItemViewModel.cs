using System.Collections.Generic;

namespace DynamicMVC.Core.DynamicMVC.ViewModels
{
    public class DynamicMenuItemViewModel
    {
        public DynamicMenuItemViewModel()
        {
            DynamicMenuItemViewModels = new List<DynamicMenuItemViewModel>();
        }
        public DynamicMenuItemViewModel(string displayName)
            : this()
        {
            DisplayName = displayName;
        }
        public DynamicMenuItemViewModel(DynamicEntityMetadataLibrary.Core.Models.DynamicEntityMetadata dynamicEntityMetadata)
            : this()
        {
            DynamicEntityMetadata = dynamicEntityMetadata;
        }
        public DynamicMenuItemViewModel(DynamicEntityMetadataLibrary.Core.Models.DynamicEntityMetadata dynamicEntityMetadata, string displayName)
            : this(dynamicEntityMetadata)
        {
            DisplayName = displayName;
        }

        public DynamicEntityMetadataLibrary.Core.Models.DynamicEntityMetadata DynamicEntityMetadata { get; set; }
        public string DisplayName { get; set; }

        public List<DynamicMenuItemViewModel> DynamicMenuItemViewModels { get; set; }
    }
}
