using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_PP : BaseApp, IApp{
        public AppBase_PP() {
            this.system_name = "_pp";
            this.id = BaseApp.AppBase_16_PP;
            this.name = "PP";
            this.description = "Production Planning";
            this.is_active = true;
            this.icon_id = app_icon.material_timelapse.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
