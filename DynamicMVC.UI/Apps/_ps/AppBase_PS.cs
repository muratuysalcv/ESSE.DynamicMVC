using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_PS : BaseApp, IApp{
        public AppBase_PS() {
            this.system_name = "_ps";
            this.id = BaseApp.AppBase_17_PS;
            this.name = "PS";
            this.description = "Project System";
            this.is_active = true;
            this.icon_id = app_icon.material_playlist_add_check.id;
        }

        public void Seed(DBContext db) {

        }
    }
}
