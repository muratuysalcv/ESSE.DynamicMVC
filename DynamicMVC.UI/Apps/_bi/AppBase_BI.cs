using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_BI : BaseApp, IApp{

        public AppBase_BI() {
            this.system_name = "_bi";
            this.id = BaseApp.AppBase_2_BI;
            this.name = "BI";
            this.description = "Business Intelligence";
            this.is_active = true;
            this.icon_id = app_icon.material_all_inclusive.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
