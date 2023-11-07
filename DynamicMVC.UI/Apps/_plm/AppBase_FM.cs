using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_PLM : BaseApp, IApp{

        public AppBase_PLM() {
            this.system_name = "_plm";
            this.id = BaseApp.AppBase_14_PLM;
            this.name = "PLM";
            this.description = "Product Life Cycle Management";
            this.is_active = true;
            this.icon_id = app_icon.material_refresh.id;
        }

        public void Seed(DBContext db) {

        }
    }
}
