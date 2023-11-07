using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_CO : BaseApp, IApp{
        public AppBase_CO() {
            this.system_name = "_co";
            this.id = BaseApp.AppBase_4_CO;
            this.name = "CO";
            this.description = "Control";
            this.is_active = true;
            this.icon_id = app_icon.material_control_point.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
