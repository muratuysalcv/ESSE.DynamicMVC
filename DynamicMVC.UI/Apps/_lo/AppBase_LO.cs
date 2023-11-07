using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_LO : BaseApp, IApp{

        public AppBase_LO() {
            this.system_name = "_lo";
            this.id = BaseApp.AppBase_24_LO;
            this.name = "LO";
            this.description = "Logistic";
            this.is_active = true;
            this.icon_id = app_icon.material_local_shipping.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
