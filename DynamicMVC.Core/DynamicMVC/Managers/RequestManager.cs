using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Shared.Enums;
using DynamicMVC.Core.DynamicMVC.Extensions;
using DynamicMVC.Core.DynamicMVC.Interfaces;
using ReflectionLibrary.Enums;
using Microsoft.AspNetCore.Http;

namespace DynamicMVC.Core.DynamicMVC.Managers
{
    public class RequestManager : IRequestManager
    {
        public IHttpContextAccessor httpContextAccessor { get; set; }
        public RequestManager(IHttpContextAccessor _httpContextAccessor) {
            this.httpContextAccessor = _httpContextAccessor;
        }

        private IDictionary<string, object> _routeDataDictionary;
        public IDictionary<string, object> RouteDataDictionary
        {
            get
            {
                // TODO : Check for configutation
                //if (_routeDataDictionary == null)
                //    _routeDataDictionary = httpContextAccessor.HttpContext.Request.RouteData.Values;
                return _routeDataDictionary;
            }
            set { _routeDataDictionary = value; }
        }

      
        private RouteValueDictionaryWrapper _queryStringDictionary;
        
        public RouteValueDictionaryWrapper QueryStringDictionary
        {
            get
            {
                //if (_queryStringDictionary == null)
                //    _queryStringDictionary = HttpContext.Current.Request.QueryString.ToRouteValues();

                return _queryStringDictionary;
            }
            set { _queryStringDictionary = value; }
        }

        private bool _correctedTypes;
        public void CorrectQuerystringTypes(DynamicEntityMetadata dynamicEntityMetadata)
        {
            if (!_correctedTypes)
            {
                foreach (var key in QueryStringDictionary.GetKeys())
                {
                    var property = dynamicEntityMetadata.DynamicPropertyMetadatas.SingleOrDefault(x => x.PropertyName() == key);
                    if (property != null && property.IsSimple())
                    {
                        var origonalValue = QueryStringDictionary.GetValue(key).ToString();
                        //There is an issue with html.checkbox helper.  It sends down true,false when checked
                        if (property.SimpleTypeEnum() == SimpleTypeEnum.Bool && origonalValue == "true,false")
                            origonalValue = "true";
                        var parsedValue = property.ParseValue()(origonalValue);
                        QueryStringDictionary.SetValue(key, parsedValue);
                    }
                }
                _correctedTypes = true;
            }
        }

        public bool PagingParametersDoNotExist()
        {
            return !QueryStringDictionary.ContainsKey("OrderBy") || !QueryStringDictionary.ContainsKey("Page") ||
                   !QueryStringDictionary.ContainsKey("PageSize");
        }

        public void AddPagingParameters(string defaultOrderBy, int page, int pageSize, string keyName)
        {
            if (defaultOrderBy == null)
                defaultOrderBy = keyName + " Desc";

            QueryStringDictionary.SetValue("OrderBy", defaultOrderBy);
            QueryStringDictionary.SetValue("Page", page);
            QueryStringDictionary.SetValue("PageSize", pageSize);
        }

        public RouteValueDictionaryWrapper RouteValueDictionaryWrapper()
        {
            return QueryStringDictionary;
        }

        public string OrderBy()
        {
            return QueryStringDictionary.GetValue("OrderBy").ToString();
        }

        /// <summary>
        /// A Property List found in query string that is used to filter the properties on a view.  This does not override previous scaffolding rules.
        /// </summary>
        /// <returns></returns>
        public string ViewProperties()
        {
            if (QueryStringDictionary.ContainsKey("ViewProperties"))
                return QueryStringDictionary.GetValue("ViewProperties").ToString();
            return null;
        }
    }
}
