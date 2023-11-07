using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMVC.UI.Controllers {
    public class MenuController : BaseController {
        public ActionResult AppAdministration(string id, string name)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }

        public ActionResult Home()
        {
            var navigations = db.app_navigations.Include("app_icon").Include("parent_navigation").Where(x => x.activation_status_id == app_status.activation_active && x.app_id == BaseApp.AppBase_25_MAIN);
            return View(navigations.ToList());
        }
    }
}