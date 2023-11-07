using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_PM : BaseApp, IApp{
        public AppBase_PM() {
            this.system_name = "_pm";
            this.id = BaseApp.AppBase_15_PM;
            this.name = "PM";
            this.description = "Plant Maintenance";
            this.is_active = true;
            this.icon_id = app_icon.material_build.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
