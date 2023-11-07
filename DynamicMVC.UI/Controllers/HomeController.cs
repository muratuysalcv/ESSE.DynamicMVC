using DynamicMVC.UI.DB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMVC.UI.Controllers {
    public class HomeController : BaseController {
        public ActionResult Index() {

            //string oradb = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            //OracleConnection conn = new OracleConnection(oradb);
            ////var cmd = new OracleCommand("select * from app_bases", conn);

            //conn.Open();
            ////var adp = new OracleDataAdapter(cmd);
            ////var dt = new DataTable();
            ////adp.Fill(dt);
            //conn.Close();

            var apps = db.apps.Include("app_icon").Where(x=>x.is_active).ToList();
            return View(apps);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ResetResources(int id, string returnUrl) {

            var app = db.apps.Single(x => x.id == id);

            var builder = new Resources.Utility.ResourceBuilder();
            string filePath = builder.Create(new DbResourceProvider(),
                summaryCulture: "tr-TR",
                filePath: Server.MapPath("~/") + "Apps\\" + app.system_name + "\\AppResource" + app.system_name + ".cs",
                namespaceName: "DynamicMVC.UI.Apps.AppResources",
                className: "AppResource" + app.system_name
                );

            Response.Redirect("~/" + this.CurrentCulture + returnUrl);
            return View();
        }
    }
}