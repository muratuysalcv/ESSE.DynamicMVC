using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMVC.UI.Helpers.Views {

    public class CustomViewEngine : RazorViewEngine {
        public CustomViewEngine() {
            var viewLocations = new[] {
            "~/Views/{1}/{0}.cshtml",
            "~/Views/Shared/{0}.cshtml"
        }.ToList();
            var type = typeof(BaseApp);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));
            foreach (var a in types) {
                if (a.Name != "IApp") {
                    var obj = (BaseApp)Activator.CreateInstance(a);
                    viewLocations.Add("~/Apps/" + obj.system_name + "/Views/{1}/{0}.cshtml");
                    viewLocations.Add("~/Apps/" + obj.system_name + "/Views/Shared/{0}.cshtml");
                }
            }
            this.FileExtensions = new[] { "cshtml" };
            this.PartialViewLocationFormats = viewLocations.ToArray();
            this.ViewLocationFormats = viewLocations.ToArray();
        }
    }
}