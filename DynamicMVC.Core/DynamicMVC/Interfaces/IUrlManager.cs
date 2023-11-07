using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IUrlManager
    {
        UrlHelper Url { get; set; }
    }
}