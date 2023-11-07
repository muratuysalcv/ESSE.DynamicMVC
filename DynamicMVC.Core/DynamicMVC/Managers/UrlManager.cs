using System.Web;
using DynamicMVC.Core.DynamicMVC.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;

namespace DynamicMVC.Core.DynamicMVC.Managers
{
    public class UrlManager : IUrlManager
    {
        public IHttpContextAccessor _httpContextAccessor;
        public UrlManager(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
            Url = new UrlHelper(null);
        }

        public UrlHelper Url { get; set; }
    }
}
