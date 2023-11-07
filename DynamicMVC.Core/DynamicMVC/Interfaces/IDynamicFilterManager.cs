using System.Collections.Generic;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicFilterManager
    {
        IEnumerable<DynamicFilterViewModel> GetFilterPropertyViewModels(DynamicEntityMetadata dynamicEntityMetadata, RouteValueDictionaryWrapper routeValueDictionaryWrapper);
        string GetFilterMessage(DynamicEntityMetadata dynamicEntityMetadata, RouteValueDictionaryWrapper routeValueDictionaryWrapper);
        IEnumerable<IDynamicFilter> GetDynamicFilters(DynamicEntityMetadata dynamicEntityMetadata, RouteValueDictionaryWrapper routeValueDictionaryWrapper);
    }
}