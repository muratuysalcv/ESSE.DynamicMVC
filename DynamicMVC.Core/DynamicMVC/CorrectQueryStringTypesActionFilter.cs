using Microsoft.AspNetCore.Mvc;
using DynamicMVC.Core.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DynamicMVC.Core.DynamicMVC
{
    public class CorrectQueryStringTypesActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            var dynamicController = (DynamicControllerBase) filterContext.Controller;
            dynamicController.CorrectQueryStringTypes();
        }
    }
}