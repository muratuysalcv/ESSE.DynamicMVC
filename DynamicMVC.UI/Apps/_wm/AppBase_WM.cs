using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_WM : BaseApp, IApp{

        public AppBase_WM() {
            this.system_name = "_wm";
            this.id = BaseApp.AppBase_22_WM;
            this.name = "WM";
            this.description = "Warehouse Management";
            this.is_active = true;
            this.icon_id = app_icon.material_developer_board.id;
        }

        public void Seed(DBContext db) {
        }
    }
}
