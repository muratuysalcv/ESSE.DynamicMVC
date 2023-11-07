using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_PC : BaseApp, IApp{

        public AppBase_PC() {
            this.system_name = "_pc";
            this.id = BaseApp.AppBase_13_PC;
            this.name = "PC";
            this.description = "Product Costing";
            this.is_active = true;
            this.icon_id = app_icon.material_donut_small.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
