using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_RE : BaseApp, IApp{

        public AppBase_RE() {
            this.system_name = "_re";
            this.id = BaseApp.AppBase_19_RE;
            this.name = "RE";
            this.description = "Real Estate";
            this.is_active = true;
            this.icon_id = app_icon.material_store.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
