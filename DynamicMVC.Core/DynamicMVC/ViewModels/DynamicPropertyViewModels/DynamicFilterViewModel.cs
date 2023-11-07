using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.Interfaces;

namespace DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels
{
    public class DynamicFilterViewModel : DynamicPropertyViewModel
    {

        public DynamicFilterViewModel(DynamicPropertyMetadata dynamicPropertyMetadata) : base(dynamicPropertyMetadata)
        {
        }

        public string DynamicFilterViewName { get; set; }
        public IDynamicFilter FilterModel { get; set; }
    }
}