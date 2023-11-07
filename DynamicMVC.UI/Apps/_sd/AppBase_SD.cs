using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_SD : BaseApp, IApp{

        public AppBase_SD() {
            this.system_name = "_sd";
            this.id = BaseApp.AppBase_20_SD;
            this.name = "SD";
            this.description = "Sales and Distribution";
            this.is_active = true;
            this.icon_id = app_icon.material_shopping_cart.id;
        }

        public void Seed(DBContext db) {

        }
    }
}
