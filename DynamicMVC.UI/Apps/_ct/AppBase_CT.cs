using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_CT : BaseApp, IApp{
        public AppBase_CT() {
            this.system_name = "_ct";
            this.id = BaseApp.AppBase_6_CT;
            this.name = "CT";
            this.description = "Content";
            this.is_active = true;
            this.icon_id = app_icon.material_insert_drive_file.id;
        }
        public void Seed(DBContext db) {
        }
    }
}
