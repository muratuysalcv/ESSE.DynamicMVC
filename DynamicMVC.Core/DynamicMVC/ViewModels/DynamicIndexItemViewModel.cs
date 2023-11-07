using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels;

namespace DynamicMVC.Core.DynamicMVC.ViewModels
{
    public class DynamicIndexItemViewModel
    {
        public DynamicIndexItemViewModel()
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
    }
}
