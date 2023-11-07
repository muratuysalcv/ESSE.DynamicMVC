using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_CR : BaseApp, IApp{
        public AppBase_CR() {
            this.system_name = "_cr";
            this.id = BaseApp.AppBase_5_CR;
            this.name = "CR";
            this.description = "Customer Relationship";
            this.is_active = true;
            this.icon_id = app_icon.material_group.id;
        }

        public void Seed(DBContext db) {

        }
    }
}
