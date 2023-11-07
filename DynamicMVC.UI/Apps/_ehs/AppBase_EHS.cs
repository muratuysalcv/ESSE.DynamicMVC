using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_EHS : BaseApp, IApp{

        public AppBase_EHS() {

            this.system_name = "_ehs";
            this.id = BaseApp.AppBase_7_EHS;
            this.name = "EHS";
            this.description = "Environment Health and Safety";
            this.is_active = true;
            this.icon_id = app_icon.material_local_hospital.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
