using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_QM : BaseApp, IApp{
        public AppBase_QM() {
            this.system_name = "_qm";
            this.id = BaseApp.AppBase_18_QM;
            this.name = "QM";
            this.description = "Quality Management";
            this.is_active = true;
            this.icon_id = app_icon.material_done_all.id;
        }

        public void Seed(DBContext db) {
            
        }
    }
}
