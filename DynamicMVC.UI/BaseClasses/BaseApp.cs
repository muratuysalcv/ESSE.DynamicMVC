using global::DynamicMVC.UI.DB;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;


namespace DynamicMVC.UI {
    public class BaseApp {
        public string system_name { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool is_active { get; set; }
        public string icon_id { get; set; }

        public BaseApp() {
            this.is_active = true;
        }

        public app SeedObject() {
            return new app() {
                id = this.id,
                app_default_database_connection_id = 1,
                app_icon_id = icon_id,
                description = this.description,
                name = this.name,
                is_active = this.is_active,
                system_name = this.system_name
            };
        }

        public void SeedAppDefinition(DBContext db) {
            var obj = SeedObject();
            if (string.IsNullOrEmpty( obj.system_name) || obj.id == 0) return;

            try {
                db.apps.AddOrUpdate(obj);
                //var current = db.apps.FirstOrDefault(x => x.id == obj.id);
                //if (current != null) {
                //    current.is_active = obj.is_active;
                //    current.name = obj.name;
                //    current.system_name = obj.system_name;
                //    current.description = obj.description;
                //    current.app_icon_id = obj.app_icon_id;
                //    current.config_json = obj.config_json;
                //    db.Entry(current).State = EntityState.Modified;
                //} else {
                //    db.Entry(obj).State = EntityState.Added;
                //    db.apps.Add(obj);
                //}
            } catch (Exception ex) {
                var validationErrors = db.GetValidationErrors().Where(x => x.IsValid == false).Select(x => string.Join(",", x.ValidationErrors.Select(y => y.ErrorMessage)));
                var errorSum = string.Join(",", validationErrors);
                throw new Exception(this.system_name + " app is not successfull. Error : " + ex.Message + " Validation Errors : " + errorSum,ex.InnerException);
            }
        }

        public static int AppBase_1_SY = 1;
        public static int AppBase_2_BI = 2;
        public static int AppBase_3_BW = 3;
        public static int AppBase_4_CO = 4;
        public static int AppBase_5_CR = 5;
        public static int AppBase_6_CT = 6;
        public static int AppBase_7_EHS = 7;
        public static int AppBase_8_FI = 8;
        public static int AppBase_9_FM = 9;
        public static int AppBase_10_HR = 10;
        public static int AppBase_11_IM = 11;
        public static int AppBase_12_MM = 12;
        public static int AppBase_13_PC = 13;
        public static int AppBase_14_PLM = 14;
        public static int AppBase_15_PM = 15;
        public static int AppBase_16_PP = 16;
        public static int AppBase_17_PS = 17;
        public static int AppBase_18_QM = 18;
        public static int AppBase_19_RE = 19;
        public static int AppBase_20_SD = 20;
        public static int AppBase_21_SM = 21;
        public static int AppBase_22_WM = 22;
        public static int AppBase_23_FisherManager = 23;
        public static int AppBase_24_LO = 24;
        public static int AppBase_25_MAIN = 25;
    }
}