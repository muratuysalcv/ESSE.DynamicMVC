using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_IM : BaseApp, IApp{

        public AppBase_IM() {
            this.system_name = "_im";
            this.id = BaseApp.AppBase_11_IM;
            this.name = "IM";
            this.description = "Investment Management";
            this.is_active = true;
            this.icon_id = app_icon.material_all_out.id;
        }

        public void Seed(DBContext db) {

        }
    }
}
