using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMVC.UI.Controllers
{
    public class DashboardController : BaseController
    {
        // GET: Dashboard
        public ActionResult Index(string id)
        {
            var dashboard = db.app_dashboards.FirstOrDefault(x => x.system_name == id);


            return View(dashboard);
        }

        public ActionResult App(string id) {
            var app = db.apps.FirstOrDefault(x => x.system_name == id);


            return View(app);
        }
    }
}