using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_MAIN : BaseApp, IApp {

        public AppBase_MAIN()
        {
            this.system_name = "__main";
            this.id = BaseApp.AppBase_25_MAIN;
            this.name = "MAIN";
            this.description = "MAIN";
            this.is_active = true;
        }

        public void Seed(DBContext db)
        {

            #region navigations

            // home page
            var dashboardNav = new app_navigation()
            {
                id = 1,
                activation_status_id = app_status.activation_active,
                app_id = 25,
                name = "Dasboard",
                system_name = "main_dashboard",
                use_url = true,
                url = "/",
                app_icon_id = app_icon.material_dashboard.id,
                app_dashboard_id = null,
                app_module_id = null,
                parent_navigation_id = null
            };
            if (db.app_navigations.Count(x => x.system_name == dashboardNav.system_name) == 0)
                db.app_navigations.AddOrUpdate(dashboardNav);

            #endregion

        }
    }
}
