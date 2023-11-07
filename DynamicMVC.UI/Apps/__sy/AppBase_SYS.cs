using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_SY : BaseApp, IApp {
        public AppBase_SY()
        {
            this.system_name = "__sy";
            this.id = BaseApp.AppBase_1_SY;
            this.name = "SY";
            this.description = "System Management";
            this.is_active = true;
            this.icon_id = app_icon.material_business_center.id;
        }

        // app based seeds
        public void Seed(DBContext db)
        {

            #region unit types

            db.app_unit_types.AddOrUpdate(new app_unit_type()
            {
                id = app_unit_type.weight,
                name = app_unit_type.weight,
                system_name = app_unit_type.weight,
                view_format = "{0} {suffix}"
            });

            db.app_unit_types.AddOrUpdate(new app_unit_type()
            {
                id = app_unit_type.volume,
                name = app_unit_type.volume,
                system_name = app_unit_type.volume,
                view_format = "{0} {suffix}"
            });

            db.app_unit_types.AddOrUpdate(new app_unit_type()
            {
                id = app_unit_type.piece,
                name = app_unit_type.piece,
                system_name = app_unit_type.piece,
                view_format = "{0} {suffix}"
            });

            db.app_unit_types.AddOrUpdate(new app_unit_type()
            {
                id = app_unit_type.length,
                name = app_unit_type.length,
                system_name = app_unit_type.length,
                view_format = "{0} {suffix}"
            });

            db.app_unit_types.AddOrUpdate(new app_unit_type()
            {
                id = app_unit_type.area,
                name = app_unit_type.area,
                system_name = app_unit_type.area,
                view_format = "{0} {suffix}"
            });


            #endregion

            #region weight units

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "KG",
                name = "KILOGRAM",
                unit_value = 1,
                prefix = "",
                suffix = "KG",
                app_unit_type_id = app_unit_type.weight
            });
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "GR",
                name = "GRAM",
                unit_value = (decimal)0.001000,
                suffix = "GR",
                app_unit_type_id = app_unit_type.weight
            });
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "TON",
                name = "TON",
                unit_value = (decimal)1000,
                suffix = "TONE",
                app_unit_type_id = app_unit_type.weight
            });

            #endregion

            #region length units
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "MM",
                name = "MILIMETER",
                unit_value = (decimal)0.1,
                suffix = "MM",
                app_unit_type_id = app_unit_type.length
            });
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "CM",
                name = "CENTIMETER",
                unit_value = (decimal)1,
                suffix = "CM",
                app_unit_type_id = app_unit_type.length
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "M",
                name = "METER",
                unit_value = (decimal)100,
                suffix = "M",
                app_unit_type_id = app_unit_type.length
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "KM",
                name = "KILOMETER",
                unit_value = (decimal)1000,
                suffix = "KM",
                app_unit_type_id = app_unit_type.length
            });

            #endregion

            #region area units

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "CM2",
                name = "CENTIMETERSQUARE",
                unit_value = (decimal)0.0001,
                suffix = "CM2",
                app_unit_type_id = app_unit_type.area
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "M2",
                name = "METERSQUARE",
                unit_value = (decimal)1,
                suffix = "CM2",
                app_unit_type_id = app_unit_type.area
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "DAM2",
                name = "DEKAMETERSQUARE",
                unit_value = (decimal)100,
                suffix = "DAM2",
                app_unit_type_id = app_unit_type.area
            });
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "HM2",
                name = "HEKTOMETERSQUARE",
                unit_value = (decimal)10000,
                suffix = "HM2",
                app_unit_type_id = app_unit_type.area
            });
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "KM2",
                name = "HEKTOMETERSQUARE",
                unit_value = (decimal)1000000,
                suffix = "KM2",
                app_unit_type_id = app_unit_type.area
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "AR",
                name = "AR",
                unit_value = (decimal)100,
                suffix = "AR",
                app_unit_type_id = app_unit_type.area
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "DAA",
                name = "DEKAR",
                unit_value = (decimal)1000,
                suffix = "DAA",
                app_unit_type_id = app_unit_type.area
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "HA",
                name = "HEKTAR",
                unit_value = (decimal)10000,
                suffix = "HA",
                app_unit_type_id = app_unit_type.area
            });


            #endregion

            #region volume units

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "M3",
                name = "METERCUBE",
                unit_value = (decimal)1,
                suffix = "M3",
                app_unit_type_id = app_unit_type.volume
            });

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "LT",
                name = "LITER",
                unit_value = (decimal)0.001,
                suffix = "LT",
                app_unit_type_id = app_unit_type.volume
            });

            #endregion

            #region piece units

            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "PIE",
                name = "PIECE",
                unit_value = (decimal)1,
                suffix = "ADET",
                app_unit_type_id = app_unit_type.piece
            });
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "DZN",
                name = "DOZEN",
                unit_value = (decimal)12,
                suffix = "DOZEN",
                app_unit_type_id = app_unit_type.piece
            });
            db.app_units.AddOrUpdate(new app_unit()
            {
                id = "DCK",
                name = "DECK",
                unit_value = (decimal)10,
                suffix = "DECK",
                app_unit_type_id = app_unit_type.piece
            });

            #endregion

            #region status types

            db.app_status_types.AddOrUpdate(new app_status_type()
            {
                id = app_status_type.activation,
                name = "ACTIVATION STATUS",
                system_name = app_status_type.activation
            });

            db.app_status_types.AddOrUpdate(new app_status_type()
            {
                id = app_status_type.availability,
                name = "AVAILABLE STATUS",
                system_name = app_status_type.availability
            });

            db.app_status_types.AddOrUpdate(new app_status_type()
            {
                id = app_status_type.level,
                name = "LEVEL STATUS",
                system_name = app_status_type.level
            });

            #endregion

            #region status

            // activation
            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = app_status.activation_active,
                name = "ACTIVE",
                system_name = app_status.activation_active,
                app_status_type_id = app_status_type.activation
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = app_status.activation_passive,
                name = "PASSIVE",
                system_name = app_status.activation_passive,
                app_status_type_id = app_status_type.activation
            });

            // available
            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = app_status.availability_available,
                name = "AVAILABLE",
                system_name = app_status.availability_available,
                app_status_type_id = app_status_type.availability
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = app_status.availability_notavailable,
                name = "AVAILABLE",
                system_name = app_status.availability_notavailable,
                app_status_type_id = app_status_type.availability
            });

            // level
            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = app_status.level_high,
                name = app_status.level_high,
                system_name = "HIGH",
                app_status_type_id = app_status_type.level
            });
            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = app_status.level_normal,
                name = "NORMAL",
                system_name = app_status.level_normal,
                app_status_type_id = app_status_type.level
            });
            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = app_status.level_low,
                name = "LOW",
                system_name = app_status.level_low,
                app_status_type_id = app_status_type.level
            });

            #endregion

            #region transaction status


            db.app_status_types.AddOrUpdate(new app_status_type()
            {
                id = "FI_TRAN",
                name = "FINACIAL TRANSACTION STATUSES",
                system_name = "FI_TRAN"
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = "TRAN_PLANNED",
                name = "TRANSACTION PLANNED",
                system_name = "TRAN_PLANNED",
                app_status_type_id = "FI_TRAN"
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = "TRAN_COMPLETED",
                name = "TRANSACTION COMPLETED",
                system_name = "TRAN_COMPLETED",
                app_status_type_id = "FI_TRAN"
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                id = "TRAN_CANCELED",
                name = "TRANSACTION CANCELED",
                system_name = "TRAN_CANCELED",
                app_status_type_id = "FI_TRAN"
            });

            #endregion

            #region financial accounts



            #endregion

        }
    }
}
