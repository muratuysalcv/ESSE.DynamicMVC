using System.Collections.Generic;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels;

namespace DynamicMVC.Core.DynamicMVC.ViewModels
{
    public class DynamicIndexMobileItemViewModel
    {
        public DynamicIndexMobileItemViewModel()
        {
            DynamicPropertyIndexViewModels = new List<DynamicPropertyIndexViewModel>();
        }

        public bool ShowDelete { get; set; }
        public bool ShowEdit { get; set; }
        public bool ShowDetails { get; set; }
        public dynamic Item { get; set; }
        public string TypeName { get; set; }
        public RouteValueDictionaryWrapper RouteValueDictionaryWrapper { get; set; }

        public List<DynamicPropertyIndexViewModel> DynamicPropertyIndexViewModels { get; set; }
        public DynamicPropertyIndexViewModel DefaultDynamicPropertyViewModel { get; set; }

        public string EntityName { get; set; }
    }
}
