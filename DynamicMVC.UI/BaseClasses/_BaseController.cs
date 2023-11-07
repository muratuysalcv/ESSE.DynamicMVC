using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace DynamicMVC.UI.Controllers {

    public class BaseController : Controller
    {
        public DBContext db = new DBContext();
        public string CurrentCulture {
            get {
                return Thread.CurrentThread.CurrentCulture.Name;
            }
        }
    }
}