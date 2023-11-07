using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_BW : BaseApp, IApp{

        public AppBase_BW() {
            this.system_name = "_bw";
            this.id = BaseApp.AppBase_3_BW;
            this.name = "BW";
            this.description = "Business Warehouse";
            this.is_active = true;
            this.icon_id = app_icon.material_center_focus_strong.id;

        }
        public void Seed(DBContext db) {
        }
    }
}
