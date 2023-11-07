using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMVC.UI.Controllers
{
    public class AppHelperController : BaseController
    {
        // GET: AppHelper
        public ActionResult AdminMenu(string id)
        {
            var app = db.apps.FirstOrDefault(x => x.system_name == id);
            return View(app);
        }
    }
}