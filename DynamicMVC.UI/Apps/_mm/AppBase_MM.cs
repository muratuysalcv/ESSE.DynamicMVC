using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_MM : BaseApp, IApp{

        public AppBase_MM() {
            this.system_name = "_mm";
            this.id = BaseApp.AppBase_12_MM;
            this.name = "MM";
            this.description = "Material Management";
            this.is_active = true;
            this.icon_id = app_icon.material_grain.id;
        }

        public void Seed(DBContext db) {

        }
    }
}
