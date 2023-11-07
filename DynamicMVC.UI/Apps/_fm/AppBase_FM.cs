using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_FM : BaseApp, IApp{

        public AppBase_FM() {

            this.system_name = "_fm";
            this.id = BaseApp.AppBase_7_EHS;
            this.name = "FM";
            this.description = "Fleet Management";
            this.is_active = true;
            this.icon_id = app_icon.material_directions_car.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
