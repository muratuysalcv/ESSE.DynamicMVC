using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_SM : BaseApp, IApp{

        public AppBase_SM() {
            this.system_name = "_sm";
            this.id = BaseApp.AppBase_21_SM;
            this.name = "SM";
            this.description = "Service Management";
            this.is_active = true;
            this.icon_id = app_icon.material_extension.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
