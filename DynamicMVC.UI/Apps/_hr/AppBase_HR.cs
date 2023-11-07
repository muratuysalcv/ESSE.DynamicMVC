using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_HR : BaseApp, IApp{
        public AppBase_HR() {
            this.system_name = "_hr";
            this.id = BaseApp.AppBase_10_HR;
            this.name = "HR";
            this.description = "Human Resources";
            this.is_active = true;
            this.icon_id = app_icon.material_person_pin.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
