using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI {
    public interface IApp {
        void Seed(DBContext db);
    }
}