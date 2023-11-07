using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI {
    /// <summary>
    /// Summary description for DbCon
    /// </summary>
    public static class DBCon {
        public static string Getir(bool EfMode = true) {
            string conStr = "metadata=res://*/App_Code.DatabaseModels.Model.csdl|res://*/App_Code.DatabaseModels.Model.ssdl|res://*/App_Code.DatabaseModels.Model.msl;provider=System.Data.SqlClient;provider connection string=\";data source=.;initial catalog=earge_fishermanager_[DBNAME];user id=sa;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";
            if (!EfMode) {
                conStr = "data source=.;initial catalog=earge_fishermanager_[DBNAME];user id=sa;password=1;MultipleActiveResultSets=True";
            }
            try {
                if (HttpContext.Current.Session["DB"] != null)
                    conStr = conStr.Replace("[DBNAME]", HttpContext.Current.Session["DB"] + "");
                else
                    conStr = conStr.Replace("[DBNAME]", "v1");
            } catch (Exception) {
                conStr = conStr.Replace("[DBNAME]", "v1");
            }

            return conStr;
        }
    }
}
