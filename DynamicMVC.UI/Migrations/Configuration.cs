using DynamicMVC.UI.DB;
namespace DynamicMVC.UI.Migrations {
    using global::DynamicMVC.UI.Apps;
    using global::DynamicMVC.UI.DB;
    using MySql.Data.Entity;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Interception;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.History;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.Migrations.Sql;
    using System.Data.Entity.Migrations.Utilities;
    using System.Linq;

    public class CustomMySqlMigrationCodeGenerator : MySqlMigrationCodeGenerator {

        protected override void Generate(CreateTableOperation createTableOperation, System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
        {
            // Descomente para debugar
            // if (System.Diagnostics.Debugger.IsAttached == false)
            //    System.Diagnostics.Debugger.Launch();

            var create = new CreateTableOperation(createTableOperation.Name.Replace("core.", "").Replace("Core.", ""));

            foreach (var item in createTableOperation.Columns)
                create.Columns.Add(item);

            create.PrimaryKey = createTableOperation.PrimaryKey;

            base.Generate(create, writer);
        }
    }

    //public class CustomOracleSqlMigrationSqlGenerator : OracleEntityMigrationSqlGenerator {

    //    protected override MigrationStatement Generate(AddForeignKeyOperation addForeignKeyOperation) {
    //        addForeignKeyOperation.PrincipalTable = addForeignKeyOperation.PrincipalTable.Replace("core.", "");
    //        addForeignKeyOperation.DependentTable = addForeignKeyOperation.DependentTable.Replace("core.", "");
    //        MigrationStatement ms = base.Generate(addForeignKeyOperation);
    //        return ms;
    //    }
    //}


    public class CustomMySqlMigrationSqlGenerator : MySqlMigrationSqlGenerator {

        protected override MigrationStatement Generate(AddForeignKeyOperation addForeignKeyOperation)
        {
            addForeignKeyOperation.PrincipalTable = addForeignKeyOperation.PrincipalTable.Replace("core.", "");
            addForeignKeyOperation.DependentTable = addForeignKeyOperation.DependentTable.Replace("core.", "");
            MigrationStatement ms = base.Generate(addForeignKeyOperation);
            return ms;
        }
    }

    public class MyHistoryContext : HistoryContext {
        public MyHistoryContext(DbConnection dbConnection, string defaultSchema)
            : base(dbConnection, defaultSchema)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().ToTable(tableName: "__MigrationHistory", schemaName: "SA");
            modelBuilder.Entity<HistoryRow>().Property(p => p.MigrationId).HasColumnName("Migration_ID");
        }
    }
    public sealed partial class Configuration : DbMigrationsConfiguration<DBContext> {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            var conStrObj = (System.Configuration.ConnectionStringsSection)ConfigurationManager.GetSection("connectionStrings");
            string providerName = conStrObj.ConnectionStrings["ConnectionString"].ProviderName;
            if (providerName == "MySql.Data.MySqlClient")
            {
                SetSqlGenerator("MySql.Data.MySqlClient", new CustomMySqlMigrationSqlGenerator());
                CodeGenerator = new CustomMySqlMigrationCodeGenerator();
                SetHistoryContextFactory("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
            }
            else if (providerName == "Oracle.ManagedDataAccess.Client")
            {
                this.SetHistoryContextFactory("Oracle.ManagedDataAccess.Client",
                    (connection, defaultSchema) => new MyHistoryContext(connection, defaultSchema));
            }


        }

        protected override void Seed(DBContext db)
        {

            #region languages
            db.app_languages.AddOrUpdate(new app_language()
            {
                id = 1,
                culture = "tr-TR",
                is_active = true,
                name = "Türkçe",
                system_name = "tr"
            });

            db.app_languages.AddOrUpdate(new app_language()
            {
                id = 2,
                culture = "en-US",
                is_active = true,
                name = "English",
                system_name = "en"
            });
            #endregion

            #region connection types
            db.app_database_connection_types.AddOrUpdate(new app_database_connection_type()
            {
                id = 1,
                system_name = "Postgre",
                description = "Postgre database connection type",
                name = "Postgre"
            });

            db.app_database_connection_types.AddOrUpdate(new app_database_connection_type()
            {
                id = 2,
                system_name = "MsSql",
                description = "Microsoft sql server database connection type",
                name = "Microsoft SQL Server"
            });
            db.app_database_connection_types.AddOrUpdate(new app_database_connection_type()
            {
                id = 3,
                system_name = "MySql",
                description = "Mysql database connection type",
                name = "Mysql Server"
            });
            db.app_database_connection_types.AddOrUpdate(new app_database_connection_type()
            {
                id = 4,
                system_name = "Oracle",
                description = "Oracle database connection type",
                name = "Oracle"
            });

            #endregion

            #region Server

            db.app_servers.AddOrUpdate(
                new app_server()
                {
                    id = 1,
                    name = "Localhost",
                    description = "Local server.",
                    ip_address = "127.0.0.1",
                    is_active = true,
                    system_name = "localhost"
                });

            #endregion

            #region app default connections

            db.app_database_connections.AddOrUpdate(

                // local postgre server - EARGE_App_Core
                new app_database_connection()
                {
                    id = 1,
                    app_database_connection_type_id = 1,
                    is_active = true,
                    name = "Postgre(localhost) - EARGE_App_Core - Database Sever Connection",
                    database_name = "EARGE_App_Core",
                    username = "postgres",
                    password = "1",
                    port = 5432,
                    app_server_id = 1
                });

            // local sql server - EARGE_App_Core
            db.app_database_connections.AddOrUpdate(
                new app_database_connection()
                {
                    id = 2,
                    app_database_connection_type_id = 2,
                    is_active = true,
                    name = "Ms-Sql (localhost) - EARGE_App_Core - Database Sever Connection",
                    database_name = "EARGE_App_Core",
                    username = "sa",
                    password = "1",
                    port = 1433,
                    app_server_id = 1
                });




            #endregion

            #region column types

            db.app_table_columntypes.AddOrUpdate(
               new app_table_columntype()
               {
                   id = 1,
                   name = "int"
               });

            db.app_table_columntypes.AddOrUpdate(
                new app_table_columntype()
                {
                    id = 2,
                    name = "string"
                });

            db.app_table_columntypes.AddOrUpdate(
               new app_table_columntype()
               {
                   id = 3,
                   name = "datetime"
               });

            db.app_table_columntypes.AddOrUpdate(
               new app_table_columntype()
               {
                   id = 4,
                   name = "boolean"
               });

            db.app_table_columntypes.AddOrUpdate(
               new app_table_columntype()
               {
                   id = 5,
                   name = "file"
               });

            db.app_table_columntypes.AddOrUpdate(
               new app_table_columntype()
               {
                   id = 6,
                   name = "image"
               });

            db.app_table_columntypes.AddOrUpdate(
              new app_table_columntype()
              {
                  id = 7,
                  name = "unique_identifier"
              });

            db.app_table_columntypes.AddOrUpdate(
             new app_table_columntype()
             {
                 id = 8,
                 name = "html"
             });

            #endregion

            #region column default values


            db.app_table_default_value_types.AddOrUpdate(new app_table_default_value_type()
            {
                id = 1,
                name = "value",
                app_table_columntype_id = 1
            });

            db.app_table_default_value_types.AddOrUpdate(new app_table_default_value_type()
            {
                id = 2,
                name = "value",
                app_table_columntype_id = 1
            });

            db.app_table_default_value_types.AddOrUpdate(new app_table_default_value_type()
            {
                id = 3,
                name = "current_date",
                app_table_columntype_id = 3
            });

            db.app_table_default_value_types.AddOrUpdate(new app_table_default_value_type()
            {
                id = 4,
                name = "true",
                app_table_columntype_id = 4
            });
            db.app_table_default_value_types.AddOrUpdate(new app_table_default_value_type()
            {
                id = 5,
                name = "true",
                app_table_columntype_id = 5
            });
            db.app_table_default_value_types.AddOrUpdate(new app_table_default_value_type()
            {
                id = 6,
                name = "false",
                app_table_columntype_id = 5
            });

            db.app_table_default_value_types.AddOrUpdate(new app_table_default_value_type()
            {
                id = 7,
                name = "newguid",
                app_table_columntype_id = 7
            });

            #endregion

            #region file types

            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 1,
                name = "AVI",
                is_active = true,
                mime_type_name = "video/x-msvideo",
                system_name = "avi"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 2,
                name = "MS-DOS Bat File",
                is_active = true,
                mime_type_name = "application/x-msdos-program",
                system_name = "bat"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 3,
                name = "Style Sheet ( css )",
                is_active = true,
                mime_type_name = "text/css",
                system_name = "css"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 4,
                name = "Microsoft Word",
                is_active = true,
                mime_type_name = "application/msword",
                system_name = "doc"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 5,
                name = "Image Jpeg",
                is_active = true,
                mime_type_name = "image/jpeg",
                system_name = "jpg"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 6,
                name = "Image Jpeg",
                is_active = true,
                mime_type_name = "image/jpeg",
                system_name = "jpeg"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 7,
                name = "Javascript",
                is_active = true,
                mime_type_name = "application/x-javascript",
                system_name = "js"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 8,
                name = "Portable Document Format",
                is_active = true,
                mime_type_name = "application/pdf",
                system_name = "pdf"
            });
            db.app_file_types.AddOrUpdate(new app_file_type()
            {
                id = 9,
                name = "Png Image",
                is_active = true,
                mime_type_name = "image/png",
                system_name = "png"
            });
            #endregion

            #region app web service types
            db.app_webservice_types.AddOrUpdate(new app_webservice_type()
            {
                id = 1,
                name = "Restful Json Service"
            });
            db.app_webservice_types.AddOrUpdate(new app_webservice_type()
            {
                id = 2,
                name = "Restful XML Service"
            });
            db.app_webservice_types.AddOrUpdate(new app_webservice_type()
            {
                id = 3,
                name = "Web Html Page Content"
            });
            db.app_webservice_types.AddOrUpdate(new app_webservice_type()
            {
                id = 4,
                name = "Remote File Reading"
            });
            #endregion

            #region process types

            db.app_process_types.AddOrUpdate(
                new app_process_type()
                {
                    id = 1,
                    name = "Validation Rule Process",
                    description = "Required validation for an process."
                });

            db.app_process_types.AddOrUpdate(
                new app_process_type()
                {
                    id = 2,
                    name = "Action Process",
                    description = "An entity page executes by action name"
                });

            db.app_process_types.AddOrUpdate(
                new app_process_type()
                {
                    id = 3,
                    name = "Scheduled Task Process",
                    description = "An entity page executes by action name"
                });

            #endregion

            #region page commands
            db.app_page_commands.AddOrUpdate(new app_page_command
            {
                id = 1,
                system_name = "create",
                is_active = true,
                name = "Create",
                description = "Data create page command"
            });
            db.app_page_commands.AddOrUpdate(new app_page_command
            {
                id = 2,
                system_name = "edit",
                is_active = true,
                name = "Edit",
                description = "Data edit page command"
            });
            db.app_page_commands.AddOrUpdate(new app_page_command
            {
                id = 3,
                system_name = "details",
                is_active = true,
                name = "Details",
                description = "Data view page command"
            });
            db.app_page_commands.AddOrUpdate(new app_page_command
            {
                id = 4,
                system_name = "delete",
                is_active = true,
                name = "Delete",
                description = "Data delete page command"
            });
            #endregion

            #region app dashboard type

            db.app_dashboard_types.AddOrUpdate(
                new app_dashboard_type()
                {
                    id = 1,
                    name = "App Dashboard",
                    system_name = "app-dashboard",
                    description = "app-dashboard"
                });
            db.app_dashboard_types.AddOrUpdate(
                new app_dashboard_type()
                {
                    id = 2,
                    name = "Module Dashboard",
                    system_name = "module-dashboard",
                    description = "module-dashboard"
                });
            db.app_dashboard_types.AddOrUpdate(
                new app_dashboard_type()
                {
                    id = 3,
                    name = "Page Dashboard",
                    system_name = "page-dashboard",
                    description = "page-dashboard"
                });
            db.app_dashboard_types.AddOrUpdate(
                new app_dashboard_type()
                {
                    id = 4,
                    name = "Process Dashboard",
                    system_name = "process-dashboard",
                    description = "process-dashboard"
                });
            #endregion

            #region app roles

            db.app_roles.AddOrUpdate(new app_role()
            {
                id = 1,
                name = "Super Admin User",
                system_name = "super-admin",
                description = "Managing apps, modules and all systematic modules.",
                active = true
            });
            db.app_roles.AddOrUpdate(new app_role()
            {
                id = 2,
                name = "Module Admin User",
                system_name = "module-admin",
                description = "Creates tables and adds process and other things.",
                active = true
            });
            db.app_roles.AddOrUpdate(new app_role()
            {
                id = 3,
                name = "Default User",
                system_name = "user",
                description = "Uses allowed all apps and modules.",
                active = true
            });

            #endregion

            #region app icon types
            db.app_icon_types.AddOrUpdate(app_icon_type.font_awesome);
            db.app_icon_types.AddOrUpdate(app_icon_type.material_icons);
            #endregion

            #region icons

            db.app_icons.AddOrUpdate(app_icon.material_accessibility);
            db.app_icons.AddOrUpdate(app_icon.material_accessible);
            db.app_icons.AddOrUpdate(app_icon.material_access_alarm);
            db.app_icons.AddOrUpdate(app_icon.material_access_time);
            db.app_icons.AddOrUpdate(app_icon.material_account_balance);
            db.app_icons.AddOrUpdate(app_icon.material_account_balance_wallet);
            db.app_icons.AddOrUpdate(app_icon.material_account_box_wallet);
            db.app_icons.AddOrUpdate(app_icon.material_account_circle);
            db.app_icons.AddOrUpdate(app_icon.material_ac_unit);
            db.app_icons.AddOrUpdate(app_icon.material_adb);
            db.app_icons.AddOrUpdate(app_icon.material_add);
            db.app_icons.AddOrUpdate(app_icon.material_add_alarm);
            db.app_icons.AddOrUpdate(app_icon.material_add_alert);
            db.app_icons.AddOrUpdate(app_icon.material_add_a_photo);
            db.app_icons.AddOrUpdate(app_icon.material_add_box);
            db.app_icons.AddOrUpdate(app_icon.material_add_circle);
            db.app_icons.AddOrUpdate(app_icon.material_add_circle_outline);
            db.app_icons.AddOrUpdate(app_icon.material_add_location);
            db.app_icons.AddOrUpdate(app_icon.material_add_shopping_cart);
            db.app_icons.AddOrUpdate(app_icon.material_add_to_queue);
            db.app_icons.AddOrUpdate(app_icon.material_adjust);
            db.app_icons.AddOrUpdate(app_icon.material_airplanemode_active);
            db.app_icons.AddOrUpdate(app_icon.material_airplay);
            db.app_icons.AddOrUpdate(app_icon.material_alarm);
            db.app_icons.AddOrUpdate(app_icon.material_alarm_add);
            db.app_icons.AddOrUpdate(app_icon.material_alarm_off);
            db.app_icons.AddOrUpdate(app_icon.material_alarm_on);
            db.app_icons.AddOrUpdate(app_icon.material_all_inclusive);
            db.app_icons.AddOrUpdate(app_icon.material_android);
            db.app_icons.AddOrUpdate(app_icon.material_announcement);
            db.app_icons.AddOrUpdate(app_icon.material_apps);
            db.app_icons.AddOrUpdate(app_icon.material_arrow_back);
            db.app_icons.AddOrUpdate(app_icon.material_arrow_downward);
            db.app_icons.AddOrUpdate(app_icon.material_arrow_drop_down);
            db.app_icons.AddOrUpdate(app_icon.material_arrow_drop_down_circle);
            db.app_icons.AddOrUpdate(app_icon.material_arrow_drop_up);
            db.app_icons.AddOrUpdate(app_icon.material_arrow_forward);
            db.app_icons.AddOrUpdate(app_icon.material_arrow_upward);
            db.app_icons.AddOrUpdate(app_icon.material_aspect_ratio);
            db.app_icons.AddOrUpdate(app_icon.material_assignment_turned_in);
            db.app_icons.AddOrUpdate(app_icon.material_assistant);
            db.app_icons.AddOrUpdate(app_icon.material_attachment);
            db.app_icons.AddOrUpdate(app_icon.material_attach_file);
            db.app_icons.AddOrUpdate(app_icon.material_attach_money);
            db.app_icons.AddOrUpdate(app_icon.material_audiotrack);
            db.app_icons.AddOrUpdate(app_icon.material_autorenew);
            db.app_icons.AddOrUpdate(app_icon.material_av_timer);
            db.app_icons.AddOrUpdate(app_icon.material_backspace);
            db.app_icons.AddOrUpdate(app_icon.material_backup);
            db.app_icons.AddOrUpdate(app_icon.material_battery_alert);
            db.app_icons.AddOrUpdate(app_icon.material_battery_charging_full);
            db.app_icons.AddOrUpdate(app_icon.material_battery_full);
            db.app_icons.AddOrUpdate(app_icon.material_battery_std);
            db.app_icons.AddOrUpdate(app_icon.material_battery_unknown);
            db.app_icons.AddOrUpdate(app_icon.material_beach_access);
            db.app_icons.AddOrUpdate(app_icon.material_beenhere);
            db.app_icons.AddOrUpdate(app_icon.material_block);
            db.app_icons.AddOrUpdate(app_icon.material_bluetooth);
            db.app_icons.AddOrUpdate(app_icon.material_bluetooth_audio);
            db.app_icons.AddOrUpdate(app_icon.material_bluetooth_connected);
            db.app_icons.AddOrUpdate(app_icon.material_bluetooth_disabled);
            db.app_icons.AddOrUpdate(app_icon.material_bluetooth_searching);
            db.app_icons.AddOrUpdate(app_icon.material_blur_circular);
            db.app_icons.AddOrUpdate(app_icon.material_blur_linear);
            db.app_icons.AddOrUpdate(app_icon.material_blur_off);
            db.app_icons.AddOrUpdate(app_icon.material_blur_on);
            db.app_icons.AddOrUpdate(app_icon.material_book);
            db.app_icons.AddOrUpdate(app_icon.material_bookmark);
            db.app_icons.AddOrUpdate(app_icon.material_bookmark_border);
            db.app_icons.AddOrUpdate(app_icon.material_border_all);
            db.app_icons.AddOrUpdate(app_icon.material_border_bottom);
            db.app_icons.AddOrUpdate(app_icon.material_border_clear);
            db.app_icons.AddOrUpdate(app_icon.material_border_color);
            db.app_icons.AddOrUpdate(app_icon.material_border_horizontal);
            db.app_icons.AddOrUpdate(app_icon.material_border_inner);
            db.app_icons.AddOrUpdate(app_icon.material_border_left);
            db.app_icons.AddOrUpdate(app_icon.material_border_outer);
            db.app_icons.AddOrUpdate(app_icon.material_border_right);
            db.app_icons.AddOrUpdate(app_icon.material_border_style);
            db.app_icons.AddOrUpdate(app_icon.material_border_top);
            db.app_icons.AddOrUpdate(app_icon.material_border_vertical);
            db.app_icons.AddOrUpdate(app_icon.material_broken_image);
            db.app_icons.AddOrUpdate(app_icon.material_brush);
            db.app_icons.AddOrUpdate(app_icon.material_bubble_chart);
            db.app_icons.AddOrUpdate(app_icon.material_bug_report);
            db.app_icons.AddOrUpdate(app_icon.material_build);
            db.app_icons.AddOrUpdate(app_icon.material_business);
            db.app_icons.AddOrUpdate(app_icon.material_business_center);
            db.app_icons.AddOrUpdate(app_icon.material_cached);
            db.app_icons.AddOrUpdate(app_icon.material_cake);
            db.app_icons.AddOrUpdate(app_icon.material_call);
            db.app_icons.AddOrUpdate(app_icon.material_call_end);
            db.app_icons.AddOrUpdate(app_icon.material_call_made);
            db.app_icons.AddOrUpdate(app_icon.material_call_merge);
            db.app_icons.AddOrUpdate(app_icon.material_call_missed);
            db.app_icons.AddOrUpdate(app_icon.material_call_missed_outgoing);
            db.app_icons.AddOrUpdate(app_icon.material_call_received);
            db.app_icons.AddOrUpdate(app_icon.material_call_split);
            db.app_icons.AddOrUpdate(app_icon.material_camera);
            db.app_icons.AddOrUpdate(app_icon.material_camera_alt);
            db.app_icons.AddOrUpdate(app_icon.material_camera_enhance);
            db.app_icons.AddOrUpdate(app_icon.material_camera_front);
            db.app_icons.AddOrUpdate(app_icon.material_camera_rear);
            db.app_icons.AddOrUpdate(app_icon.material_camera_roll);
            db.app_icons.AddOrUpdate(app_icon.material_cancel);
            db.app_icons.AddOrUpdate(app_icon.material_card_giftcard);
            db.app_icons.AddOrUpdate(app_icon.material_card_membership);
            db.app_icons.AddOrUpdate(app_icon.material_card_travel);
            db.app_icons.AddOrUpdate(app_icon.material_casino);
            db.app_icons.AddOrUpdate(app_icon.material_cast);
            db.app_icons.AddOrUpdate(app_icon.material_cast_connected);
            db.app_icons.AddOrUpdate(app_icon.material_center_focus_strong);
            db.app_icons.AddOrUpdate(app_icon.material_center_focus_weak);
            db.app_icons.AddOrUpdate(app_icon.material_change_history);
            db.app_icons.AddOrUpdate(app_icon.material_chat);
            db.app_icons.AddOrUpdate(app_icon.material_chat_bubble);
            db.app_icons.AddOrUpdate(app_icon.material_chat_bubble_outline);
            db.app_icons.AddOrUpdate(app_icon.material_check);
            db.app_icons.AddOrUpdate(app_icon.material_check_box);
            db.app_icons.AddOrUpdate(app_icon.material_check_box_outline_blank);
            db.app_icons.AddOrUpdate(app_icon.material_check_circle);
            db.app_icons.AddOrUpdate(app_icon.material_chevron_left);
            db.app_icons.AddOrUpdate(app_icon.material_chevron_right);
            db.app_icons.AddOrUpdate(app_icon.material_child_care);
            db.app_icons.AddOrUpdate(app_icon.material_child_friendly);
            db.app_icons.AddOrUpdate(app_icon.material_chome_reader_mode);
            db.app_icons.AddOrUpdate(app_icon.material_class);
            db.app_icons.AddOrUpdate(app_icon.material_clear);
            db.app_icons.AddOrUpdate(app_icon.material_clear_all);
            db.app_icons.AddOrUpdate(app_icon.material_close);
            db.app_icons.AddOrUpdate(app_icon.material_closed_caption);
            db.app_icons.AddOrUpdate(app_icon.material_cloud);
            db.app_icons.AddOrUpdate(app_icon.material_cloud_circle);
            db.app_icons.AddOrUpdate(app_icon.material_cloud_done);
            db.app_icons.AddOrUpdate(app_icon.material_cloud_download);
            db.app_icons.AddOrUpdate(app_icon.material_cloud_off);
            db.app_icons.AddOrUpdate(app_icon.material_cloud_queue);
            db.app_icons.AddOrUpdate(app_icon.material_cloud_upload);
            db.app_icons.AddOrUpdate(app_icon.material_code);
            db.app_icons.AddOrUpdate(app_icon.material_collections);
            db.app_icons.AddOrUpdate(app_icon.material_collections_bookmark);
            db.app_icons.AddOrUpdate(app_icon.material_colorize);
            db.app_icons.AddOrUpdate(app_icon.material_color_lens);
            db.app_icons.AddOrUpdate(app_icon.material_comment);
            db.app_icons.AddOrUpdate(app_icon.material_compare);
            db.app_icons.AddOrUpdate(app_icon.material_compare_arrows);
            db.app_icons.AddOrUpdate(app_icon.material_computer);
            db.app_icons.AddOrUpdate(app_icon.material_contacts);
            db.app_icons.AddOrUpdate(app_icon.material_contact_mail);
            db.app_icons.AddOrUpdate(app_icon.material_contact_phone);
            db.app_icons.AddOrUpdate(app_icon.material_content_copy);
            db.app_icons.AddOrUpdate(app_icon.material_content_cut);
            db.app_icons.AddOrUpdate(app_icon.material_content_paste);
            db.app_icons.AddOrUpdate(app_icon.material_control_point);
            db.app_icons.AddOrUpdate(app_icon.material_control_point_duplicate);
            db.app_icons.AddOrUpdate(app_icon.material_copyright);
            db.app_icons.AddOrUpdate(app_icon.material_create);
            db.app_icons.AddOrUpdate(app_icon.material_create_new_folder);
            db.app_icons.AddOrUpdate(app_icon.material_credit_card);
            db.app_icons.AddOrUpdate(app_icon.material_crop);
            db.app_icons.AddOrUpdate(app_icon.material_crop_16_9);
            db.app_icons.AddOrUpdate(app_icon.material_crop_3_2);
            db.app_icons.AddOrUpdate(app_icon.material_crop_5_4);
            db.app_icons.AddOrUpdate(app_icon.material_crop_7_5);
            db.app_icons.AddOrUpdate(app_icon.material_crop_din);
            db.app_icons.AddOrUpdate(app_icon.material_crop_free);
            db.app_icons.AddOrUpdate(app_icon.material_crop_landscape);
            db.app_icons.AddOrUpdate(app_icon.material_crop_original);
            db.app_icons.AddOrUpdate(app_icon.material_crop_potrait);
            db.app_icons.AddOrUpdate(app_icon.material_crop_rotate);
            db.app_icons.AddOrUpdate(app_icon.material_crop_square);
            db.app_icons.AddOrUpdate(app_icon.material_dashboard);
            db.app_icons.AddOrUpdate(app_icon.material_data_usage);
            db.app_icons.AddOrUpdate(app_icon.material_date_range);
            db.app_icons.AddOrUpdate(app_icon.material_dehaze);
            db.app_icons.AddOrUpdate(app_icon.material_delete);
            db.app_icons.AddOrUpdate(app_icon.material_delete_forever);
            db.app_icons.AddOrUpdate(app_icon.material_delete_sweep);
            db.app_icons.AddOrUpdate(app_icon.material_description);
            db.app_icons.AddOrUpdate(app_icon.material_desktop_mac);
            db.app_icons.AddOrUpdate(app_icon.material_desktop_windows);
            db.app_icons.AddOrUpdate(app_icon.material_details);
            db.app_icons.AddOrUpdate(app_icon.material_developer_board);
            db.app_icons.AddOrUpdate(app_icon.material_developer_mode);
            db.app_icons.AddOrUpdate(app_icon.material_devices);
            db.app_icons.AddOrUpdate(app_icon.material_devices_other);
            db.app_icons.AddOrUpdate(app_icon.material_device_hub);
            db.app_icons.AddOrUpdate(app_icon.material_dialer_sip);
            db.app_icons.AddOrUpdate(app_icon.material_dialpad);
            db.app_icons.AddOrUpdate(app_icon.material_directions);
            db.app_icons.AddOrUpdate(app_icon.material_directions_bike);
            db.app_icons.AddOrUpdate(app_icon.material_directions_boat);
            db.app_icons.AddOrUpdate(app_icon.material_directions_bus);
            db.app_icons.AddOrUpdate(app_icon.material_directions_car);
            db.app_icons.AddOrUpdate(app_icon.material_directions_railway);
            db.app_icons.AddOrUpdate(app_icon.material_directions_run);
            db.app_icons.AddOrUpdate(app_icon.material_directions_subway);
            db.app_icons.AddOrUpdate(app_icon.material_directions_transit);
            db.app_icons.AddOrUpdate(app_icon.material_directions_walk);
            db.app_icons.AddOrUpdate(app_icon.material_disc_full);
            db.app_icons.AddOrUpdate(app_icon.material_dns);
            db.app_icons.AddOrUpdate(app_icon.material_dock);
            db.app_icons.AddOrUpdate(app_icon.material_domain);
            db.app_icons.AddOrUpdate(app_icon.material_done);
            db.app_icons.AddOrUpdate(app_icon.material_done_all);
            db.app_icons.AddOrUpdate(app_icon.material_donut_large);
            db.app_icons.AddOrUpdate(app_icon.material_donut_small);
            db.app_icons.AddOrUpdate(app_icon.material_do_not_disturb);
            db.app_icons.AddOrUpdate(app_icon.material_do_not_disturb_alt);
            db.app_icons.AddOrUpdate(app_icon.material_do_not_disturb_off);
            db.app_icons.AddOrUpdate(app_icon.material_do_not_disturb_on);
            db.app_icons.AddOrUpdate(app_icon.material_drafts);
            db.app_icons.AddOrUpdate(app_icon.material_edit);
            db.app_icons.AddOrUpdate(app_icon.material_edit_location);
            db.app_icons.AddOrUpdate(app_icon.material_eject);
            db.app_icons.AddOrUpdate(app_icon.material_email);
            db.app_icons.AddOrUpdate(app_icon.material_enhanced_encryption);
            db.app_icons.AddOrUpdate(app_icon.material_equalizer);
            db.app_icons.AddOrUpdate(app_icon.material_error);
            db.app_icons.AddOrUpdate(app_icon.material_error_outline);
            db.app_icons.AddOrUpdate(app_icon.material_euro_symbol);
            db.app_icons.AddOrUpdate(app_icon.material_event);
            db.app_icons.AddOrUpdate(app_icon.material_event_available);
            db.app_icons.AddOrUpdate(app_icon.material_event_busy);
            db.app_icons.AddOrUpdate(app_icon.material_event_note);
            db.app_icons.AddOrUpdate(app_icon.material_event_seat);
            db.app_icons.AddOrUpdate(app_icon.material_exit_to_app);
            db.app_icons.AddOrUpdate(app_icon.material_expand_less);
            db.app_icons.AddOrUpdate(app_icon.material_expand_more);
            db.app_icons.AddOrUpdate(app_icon.material_exposure);
            db.app_icons.AddOrUpdate(app_icon.material_extension);
            db.app_icons.AddOrUpdate(app_icon.material_face);
            db.app_icons.AddOrUpdate(app_icon.material_favorite);
            db.app_icons.AddOrUpdate(app_icon.material_favorite_border);
            db.app_icons.AddOrUpdate(app_icon.material_file_download);
            db.app_icons.AddOrUpdate(app_icon.material_file_upload);
            db.app_icons.AddOrUpdate(app_icon.material_filter_center_focus);
            db.app_icons.AddOrUpdate(app_icon.material_find_in_page);
            db.app_icons.AddOrUpdate(app_icon.material_find_replace);
            db.app_icons.AddOrUpdate(app_icon.material_fingerprint);
            db.app_icons.AddOrUpdate(app_icon.material_flag);
            db.app_icons.AddOrUpdate(app_icon.material_flight);
            db.app_icons.AddOrUpdate(app_icon.material_flight_land);
            db.app_icons.AddOrUpdate(app_icon.material_flight_takeoff);
            db.app_icons.AddOrUpdate(app_icon.material_folder);
            db.app_icons.AddOrUpdate(app_icon.material_folder_open);
            db.app_icons.AddOrUpdate(app_icon.material_folder_shared);
            db.app_icons.AddOrUpdate(app_icon.material_folder_special);
            db.app_icons.AddOrUpdate(app_icon.material_forward);
            db.app_icons.AddOrUpdate(app_icon.material_free_breakfast);
            db.app_icons.AddOrUpdate(app_icon.material_fullscreen);
            db.app_icons.AddOrUpdate(app_icon.material_fullscreen_exit);
            db.app_icons.AddOrUpdate(app_icon.material_functions);
            db.app_icons.AddOrUpdate(app_icon.material_get_app);
            db.app_icons.AddOrUpdate(app_icon.material_gif);
            db.app_icons.AddOrUpdate(app_icon.material_gps_fixed);
            db.app_icons.AddOrUpdate(app_icon.material_gps_not_fixed);
            db.app_icons.AddOrUpdate(app_icon.material_gps_off);
            db.app_icons.AddOrUpdate(app_icon.material_grade);
            db.app_icons.AddOrUpdate(app_icon.material_grain);
            db.app_icons.AddOrUpdate(app_icon.material_group);
            db.app_icons.AddOrUpdate(app_icon.material_group_add);
            db.app_icons.AddOrUpdate(app_icon.material_group_work);
            db.app_icons.AddOrUpdate(app_icon.material_g_translate);
            db.app_icons.AddOrUpdate(app_icon.material_hd);
            db.app_icons.AddOrUpdate(app_icon.material_headset);
            db.app_icons.AddOrUpdate(app_icon.material_hearing);
            db.app_icons.AddOrUpdate(app_icon.material_help);
            db.app_icons.AddOrUpdate(app_icon.material_help_outline);
            db.app_icons.AddOrUpdate(app_icon.material_highlight_off);
            db.app_icons.AddOrUpdate(app_icon.material_history);
            db.app_icons.AddOrUpdate(app_icon.material_home);
            db.app_icons.AddOrUpdate(app_icon.material_hotel);
            db.app_icons.AddOrUpdate(app_icon.material_hourglass_empty);
            db.app_icons.AddOrUpdate(app_icon.material_hourglass_full);
            db.app_icons.AddOrUpdate(app_icon.material_http);
            db.app_icons.AddOrUpdate(app_icon.material_https);
            db.app_icons.AddOrUpdate(app_icon.material_image);
            db.app_icons.AddOrUpdate(app_icon.material_import_export);
            db.app_icons.AddOrUpdate(app_icon.material_info);
            db.app_icons.AddOrUpdate(app_icon.material_info_outline);
            db.app_icons.AddOrUpdate(app_icon.material_input);
            db.app_icons.AddOrUpdate(app_icon.material_insert_comment);
            db.app_icons.AddOrUpdate(app_icon.material_insert_drive_file);
            db.app_icons.AddOrUpdate(app_icon.material_insert_emoticon);
            db.app_icons.AddOrUpdate(app_icon.material_insert_invitation);
            db.app_icons.AddOrUpdate(app_icon.material_insert_link);
            db.app_icons.AddOrUpdate(app_icon.material_insert_photo);
            db.app_icons.AddOrUpdate(app_icon.material_invert_colors);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_arrow_down);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_arrow_left);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_arrow_right);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_arrow_up);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_backspace);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_capslock);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_hide);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_return);
            db.app_icons.AddOrUpdate(app_icon.material_keyboard_voice);
            db.app_icons.AddOrUpdate(app_icon.material_label);
            db.app_icons.AddOrUpdate(app_icon.material_label_outline);
            db.app_icons.AddOrUpdate(app_icon.material_language);
            db.app_icons.AddOrUpdate(app_icon.material_laptop);
            db.app_icons.AddOrUpdate(app_icon.material_laptop_chromebook);
            db.app_icons.AddOrUpdate(app_icon.material_laptop_mac);
            db.app_icons.AddOrUpdate(app_icon.material_laptop_windows);
            db.app_icons.AddOrUpdate(app_icon.material_launch);
            db.app_icons.AddOrUpdate(app_icon.material_layers);
            db.app_icons.AddOrUpdate(app_icon.material_layers_clear);
            db.app_icons.AddOrUpdate(app_icon.material_library_music);
            db.app_icons.AddOrUpdate(app_icon.material_lightbulb_outline);
            db.app_icons.AddOrUpdate(app_icon.material_linear_scale);
            db.app_icons.AddOrUpdate(app_icon.material_link);
            db.app_icons.AddOrUpdate(app_icon.material_linked_camera);
            db.app_icons.AddOrUpdate(app_icon.material_live_help);
            db.app_icons.AddOrUpdate(app_icon.material_live_tv);
            db.app_icons.AddOrUpdate(app_icon.material_localtion_city);
            db.app_icons.AddOrUpdate(app_icon.material_local_airport);
            db.app_icons.AddOrUpdate(app_icon.material_local_atm);
            db.app_icons.AddOrUpdate(app_icon.material_local_bar);
            db.app_icons.AddOrUpdate(app_icon.material_local_cafe);
            db.app_icons.AddOrUpdate(app_icon.material_local_car_wash);
            db.app_icons.AddOrUpdate(app_icon.material_local_dining);
            db.app_icons.AddOrUpdate(app_icon.material_local_drink);
            db.app_icons.AddOrUpdate(app_icon.material_local_florist);
            db.app_icons.AddOrUpdate(app_icon.material_local_gas_station);
            db.app_icons.AddOrUpdate(app_icon.material_local_grocery_store);
            db.app_icons.AddOrUpdate(app_icon.material_local_hospital);
            db.app_icons.AddOrUpdate(app_icon.material_local_hotel);
            db.app_icons.AddOrUpdate(app_icon.material_local_library);
            db.app_icons.AddOrUpdate(app_icon.material_local_loundry_service);
            db.app_icons.AddOrUpdate(app_icon.material_local_mall);
            db.app_icons.AddOrUpdate(app_icon.material_local_movies);
            db.app_icons.AddOrUpdate(app_icon.material_local_offer);
            db.app_icons.AddOrUpdate(app_icon.material_local_parking);
            db.app_icons.AddOrUpdate(app_icon.material_local_pharmacy);
            db.app_icons.AddOrUpdate(app_icon.material_local_phone);
            db.app_icons.AddOrUpdate(app_icon.material_local_pizza);
            db.app_icons.AddOrUpdate(app_icon.material_local_post_office);
            db.app_icons.AddOrUpdate(app_icon.material_local_printshop);
            db.app_icons.AddOrUpdate(app_icon.material_local_see);
            db.app_icons.AddOrUpdate(app_icon.material_local_shipping);
            db.app_icons.AddOrUpdate(app_icon.material_local_taxi);
            db.app_icons.AddOrUpdate(app_icon.material_location_disabled);
            db.app_icons.AddOrUpdate(app_icon.material_location_off);
            db.app_icons.AddOrUpdate(app_icon.material_location_on);
            db.app_icons.AddOrUpdate(app_icon.material_location_searching);
            db.app_icons.AddOrUpdate(app_icon.material_lock);
            db.app_icons.AddOrUpdate(app_icon.material_lock_open);
            db.app_icons.AddOrUpdate(app_icon.material_lock_outline);
            db.app_icons.AddOrUpdate(app_icon.material_looks);
            db.app_icons.AddOrUpdate(app_icon.material_loop);
            db.app_icons.AddOrUpdate(app_icon.material_loupe);
            db.app_icons.AddOrUpdate(app_icon.material_mail);
            db.app_icons.AddOrUpdate(app_icon.material_mail_outline);
            db.app_icons.AddOrUpdate(app_icon.material_map);
            db.app_icons.AddOrUpdate(app_icon.material_mark_unread);
            db.app_icons.AddOrUpdate(app_icon.material_memory);
            db.app_icons.AddOrUpdate(app_icon.material_mic);
            db.app_icons.AddOrUpdate(app_icon.material_mic_none);
            db.app_icons.AddOrUpdate(app_icon.material_mic_off);
            db.app_icons.AddOrUpdate(app_icon.material_mode_edit);
            db.app_icons.AddOrUpdate(app_icon.material_monetization_on);
            db.app_icons.AddOrUpdate(app_icon.material_money_off);
            db.app_icons.AddOrUpdate(app_icon.material_mood);
            db.app_icons.AddOrUpdate(app_icon.material_mood_bad);
            db.app_icons.AddOrUpdate(app_icon.material_more_horiz);
            db.app_icons.AddOrUpdate(app_icon.material_more_vert);
            db.app_icons.AddOrUpdate(app_icon.material_motorcycle);
            db.app_icons.AddOrUpdate(app_icon.material_mouse);
            db.app_icons.AddOrUpdate(app_icon.material_music_note);
            db.app_icons.AddOrUpdate(app_icon.material_my_location);
            db.app_icons.AddOrUpdate(app_icon.material_navigate_before);
            db.app_icons.AddOrUpdate(app_icon.material_navigate_next);
            db.app_icons.AddOrUpdate(app_icon.material_navigation);
            db.app_icons.AddOrUpdate(app_icon.material_near_me);
            db.app_icons.AddOrUpdate(app_icon.material_network_check);
            db.app_icons.AddOrUpdate(app_icon.material_network_wifi);
            db.app_icons.AddOrUpdate(app_icon.material_nfc);
            db.app_icons.AddOrUpdate(app_icon.material_note);
            db.app_icons.AddOrUpdate(app_icon.material_note_add);
            db.app_icons.AddOrUpdate(app_icon.material_notifications);
            db.app_icons.AddOrUpdate(app_icon.material_notifications_active);
            db.app_icons.AddOrUpdate(app_icon.material_notifications_none);
            db.app_icons.AddOrUpdate(app_icon.material_notifications_off);
            db.app_icons.AddOrUpdate(app_icon.material_notifications_paused);
            db.app_icons.AddOrUpdate(app_icon.material_not_interested);
            db.app_icons.AddOrUpdate(app_icon.material_no_encryption);
            db.app_icons.AddOrUpdate(app_icon.material_no_sim);
            db.app_icons.AddOrUpdate(app_icon.material_offline_pin);
            db.app_icons.AddOrUpdate(app_icon.material_open_in_browser);
            db.app_icons.AddOrUpdate(app_icon.material_open_in_new);
            db.app_icons.AddOrUpdate(app_icon.material_open_with);
            db.app_icons.AddOrUpdate(app_icon.material_pageview);
            db.app_icons.AddOrUpdate(app_icon.material_palette);
            db.app_icons.AddOrUpdate(app_icon.material_panorama);
            db.app_icons.AddOrUpdate(app_icon.material_pan_tool);
            db.app_icons.AddOrUpdate(app_icon.material_pause);
            db.app_icons.AddOrUpdate(app_icon.material_pause_circle_filled);
            db.app_icons.AddOrUpdate(app_icon.material_pause_circle_outline);
            db.app_icons.AddOrUpdate(app_icon.material_payment);
            db.app_icons.AddOrUpdate(app_icon.material_people);
            db.app_icons.AddOrUpdate(app_icon.material_people_outline);
            db.app_icons.AddOrUpdate(app_icon.material_perm_identity);
            db.app_icons.AddOrUpdate(app_icon.material_person);
            db.app_icons.AddOrUpdate(app_icon.material_person_add);
            db.app_icons.AddOrUpdate(app_icon.material_person_outline);
            db.app_icons.AddOrUpdate(app_icon.material_person_pin);
            db.app_icons.AddOrUpdate(app_icon.material_person_pin_circle);
            db.app_icons.AddOrUpdate(app_icon.material_pets);
            db.app_icons.AddOrUpdate(app_icon.material_phone);
            db.app_icons.AddOrUpdate(app_icon.material_phone_android);
            db.app_icons.AddOrUpdate(app_icon.material_phone_in_talk);
            db.app_icons.AddOrUpdate(app_icon.material_phone_iphone);
            db.app_icons.AddOrUpdate(app_icon.material_photo);
            db.app_icons.AddOrUpdate(app_icon.material_photo_album);
            db.app_icons.AddOrUpdate(app_icon.material_photo_camera);
            db.app_icons.AddOrUpdate(app_icon.material_pie_chart);
            db.app_icons.AddOrUpdate(app_icon.material_pie_chart_outlined);
            db.app_icons.AddOrUpdate(app_icon.material_pin_drop);
            db.app_icons.AddOrUpdate(app_icon.material_place);
            db.app_icons.AddOrUpdate(app_icon.material_playlist_add);
            db.app_icons.AddOrUpdate(app_icon.material_playlist_add_check);
            db.app_icons.AddOrUpdate(app_icon.material_playlist_play);
            db.app_icons.AddOrUpdate(app_icon.material_play_arrow);
            db.app_icons.AddOrUpdate(app_icon.material_play_circle_filled);
            db.app_icons.AddOrUpdate(app_icon.material_play_circle_outline);
            db.app_icons.AddOrUpdate(app_icon.material_plus_one);
            db.app_icons.AddOrUpdate(app_icon.material_poll);
            db.app_icons.AddOrUpdate(app_icon.material_power);
            db.app_icons.AddOrUpdate(app_icon.material_power_settings_new);
            db.app_icons.AddOrUpdate(app_icon.material_print);
            db.app_icons.AddOrUpdate(app_icon.material_priority_hight);
            db.app_icons.AddOrUpdate(app_icon.material_public);
            db.app_icons.AddOrUpdate(app_icon.material_publish);
            db.app_icons.AddOrUpdate(app_icon.material_radio_button_checked);
            db.app_icons.AddOrUpdate(app_icon.material_radio_button_unchecked);
            db.app_icons.AddOrUpdate(app_icon.material_refresh);
            db.app_icons.AddOrUpdate(app_icon.material_remove);
            db.app_icons.AddOrUpdate(app_icon.material_remove_red_eye);
            db.app_icons.AddOrUpdate(app_icon.material_remove_shopping_cart);
            db.app_icons.AddOrUpdate(app_icon.material_remove__circle);
            db.app_icons.AddOrUpdate(app_icon.material_remove__circle_outline);
            db.app_icons.AddOrUpdate(app_icon.material_repeat);
            db.app_icons.AddOrUpdate(app_icon.material_repeat_one);
            db.app_icons.AddOrUpdate(app_icon.material_replay);
            db.app_icons.AddOrUpdate(app_icon.material_reply);
            db.app_icons.AddOrUpdate(app_icon.material_reply_all);
            db.app_icons.AddOrUpdate(app_icon.material_report);
            db.app_icons.AddOrUpdate(app_icon.material_report_problem);
            db.app_icons.AddOrUpdate(app_icon.material_restaurant_menu);
            db.app_icons.AddOrUpdate(app_icon.material_restore);
            db.app_icons.AddOrUpdate(app_icon.material_restore_page);
            db.app_icons.AddOrUpdate(app_icon.material_router);
            db.app_icons.AddOrUpdate(app_icon.material_rss_feed);
            db.app_icons.AddOrUpdate(app_icon.material_save);
            db.app_icons.AddOrUpdate(app_icon.material_schedule);
            db.app_icons.AddOrUpdate(app_icon.material_school);
            db.app_icons.AddOrUpdate(app_icon.material_scren_rotation);
            db.app_icons.AddOrUpdate(app_icon.material_search);
            db.app_icons.AddOrUpdate(app_icon.material_security);
            db.app_icons.AddOrUpdate(app_icon.material_sentiment_dissatisfied);
            db.app_icons.AddOrUpdate(app_icon.material_sentiment_neutral);
            db.app_icons.AddOrUpdate(app_icon.material_sentiment_satisfied);
            db.app_icons.AddOrUpdate(app_icon.material_sentiment_very_dissatisfied);
            db.app_icons.AddOrUpdate(app_icon.material_settings);
            db.app_icons.AddOrUpdate(app_icon.material_settings_applications);
            db.app_icons.AddOrUpdate(app_icon.material_settings_backup_restore);
            db.app_icons.AddOrUpdate(app_icon.material_settings_bluetooth);
            db.app_icons.AddOrUpdate(app_icon.material_settings_input_antenna);
            db.app_icons.AddOrUpdate(app_icon.material_settings_input_component);
            db.app_icons.AddOrUpdate(app_icon.material_share);
            db.app_icons.AddOrUpdate(app_icon.material_shopping_basket);
            db.app_icons.AddOrUpdate(app_icon.material_shopping_cart);
            db.app_icons.AddOrUpdate(app_icon.material_show_chart);
            db.app_icons.AddOrUpdate(app_icon.material_shuffle);
            db.app_icons.AddOrUpdate(app_icon.material_sms);
            db.app_icons.AddOrUpdate(app_icon.material_sms_failed);
            db.app_icons.AddOrUpdate(app_icon.material_star);
            db.app_icons.AddOrUpdate(app_icon.material_stars);
            db.app_icons.AddOrUpdate(app_icon.material_star_border);
            db.app_icons.AddOrUpdate(app_icon.material_star_half);
            db.app_icons.AddOrUpdate(app_icon.material_storage);
            db.app_icons.AddOrUpdate(app_icon.material_store);
            db.app_icons.AddOrUpdate(app_icon.material_supervisor_account);
            db.app_icons.AddOrUpdate(app_icon.material_swap_horiz);
            db.app_icons.AddOrUpdate(app_icon.material_swap_vert);
            db.app_icons.AddOrUpdate(app_icon.material_sync);
            db.app_icons.AddOrUpdate(app_icon.material_sync_disabled);
            db.app_icons.AddOrUpdate(app_icon.material_sync_problem);
            db.app_icons.AddOrUpdate(app_icon.material_tab);
            db.app_icons.AddOrUpdate(app_icon.material_thumb_down);
            db.app_icons.AddOrUpdate(app_icon.material_thumb_up);
            db.app_icons.AddOrUpdate(app_icon.material_timeline);
            db.app_icons.AddOrUpdate(app_icon.material_timer);
            db.app_icons.AddOrUpdate(app_icon.material_train);
            db.app_icons.AddOrUpdate(app_icon.material_tram);
            db.app_icons.AddOrUpdate(app_icon.material_transform);
            db.app_icons.AddOrUpdate(app_icon.material_trending_down);
            db.app_icons.AddOrUpdate(app_icon.material_trending_flat);
            db.app_icons.AddOrUpdate(app_icon.material_trending_up);
            db.app_icons.AddOrUpdate(app_icon.material_unfold_less);
            db.app_icons.AddOrUpdate(app_icon.material_unfold_more);
            db.app_icons.AddOrUpdate(app_icon.material_update);
            db.app_icons.AddOrUpdate(app_icon.material_verified_user);
            db.app_icons.AddOrUpdate(app_icon.material_visibility);
            db.app_icons.AddOrUpdate(app_icon.material_visibility_off);
            db.app_icons.AddOrUpdate(app_icon.material_volume_down);
            db.app_icons.AddOrUpdate(app_icon.material_volume_mute);
            db.app_icons.AddOrUpdate(app_icon.material_volume_off);
            db.app_icons.AddOrUpdate(app_icon.material_volume_up);
            db.app_icons.AddOrUpdate(app_icon.material_vpn_key);
            db.app_icons.AddOrUpdate(app_icon.material_warning);
            db.app_icons.AddOrUpdate(app_icon.material_watch_later);
            db.app_icons.AddOrUpdate(app_icon.material_wb_cloudy);
            db.app_icons.AddOrUpdate(app_icon.material_wb_sunny);
            db.app_icons.AddOrUpdate(app_icon.material_widgets);
            db.app_icons.AddOrUpdate(app_icon.material_wifi);
            db.app_icons.AddOrUpdate(app_icon.material_wifi_lock);
            db.app_icons.AddOrUpdate(app_icon.material_work);
            db.app_icons.AddOrUpdate(app_icon.material_zoom_in);
            db.app_icons.AddOrUpdate(app_icon.material_zoom_out);
            db.app_icons.AddOrUpdate(app_icon.material_zoom_out_map);
            db.app_icons.AddOrUpdate(app_icon.material_all_out);
            db.app_icons.AddOrUpdate(app_icon.material_timelapse);

            // fa
            db.app_icons.AddOrUpdate(app_icon.fa_fish);

            #endregion

            #region apps
            var app = new AppBase_SY().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_SY().SeedObject());

            //BaseApp.AppBase_2_BI
            app = new AppBase_SY().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_BI().SeedObject());
            //BaseApp.AppBase_3_BW
            app = new AppBase_BW().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_BW().SeedObject());
            //BaseApp.AppBase_4_CO
            app = new AppBase_CO().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_CO().SeedObject());
            //BaseApp.AppBase_5_CR
            app = new AppBase_CR().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_CR().SeedObject());
            //BaseApp.AppBase_6_CT
            app = new AppBase_CT().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_CT().SeedObject());
            //BaseApp.AppBase_7_EHS
            app = new AppBase_EHS().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_EHS().SeedObject());
            //BaseApp.AppBase_8_FI
            app = new AppBase_FI().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_FI().SeedObject());
            //BaseApp.AppBase_9_FM
            app = new AppBase_FM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_FM().SeedObject());
            //BaseApp.AppBase_10_HR
            app = new AppBase_HR().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_HR().SeedObject());
            //BaseApp.AppBase_11_IM
            app = new AppBase_IM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_IM().SeedObject());
            //BaseApp.AppBase_12_MM
            app = new AppBase_MM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_MM().SeedObject());
            //BaseApp.AppBase_13_PC
            app = new AppBase_PC().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_PC().SeedObject());
            //BaseApp.AppBase_14_PLM
            app = new AppBase_PLM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_PLM().SeedObject());
            //BaseApp.AppBase_15_PM
            app = new AppBase_PM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_PM().SeedObject());
            //BaseApp.AppBase_16_PP
            app = new AppBase_PP().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_PP().SeedObject());
            //BaseApp.AppBase_17_PS
            app = new AppBase_PS().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_PS().SeedObject());
            //BaseApp.AppBase_18_QM
            app = new AppBase_QM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_QM().SeedObject());
            //BaseApp.AppBase_19_RE
            app = new AppBase_RE().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_RE().SeedObject());
            //BaseApp.AppBase_20_SD
            app = new AppBase_SD().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_SD().SeedObject());
            //BaseApp.AppBase_21_SM
            app = new AppBase_SM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_SM().SeedObject());
            //BaseApp.AppBase_22_WM
            app = new AppBase_WM().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_WM().SeedObject());
            //BaseApp.AppBase_23_FisherManager
            app = new AppBase_FisherManager().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_FisherManager().SeedObject());
            //BaseApp.AppBase_24_LO
            app = new AppBase_LO().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_LO().SeedObject());
            //BaseApp.AppBase_25_MAIN
            app = new AppBase_MAIN().SeedObject();
            if (db.apps.Count(x => x.system_name == app.system_name) == 0)
                db.apps.AddOrUpdate(new AppBase_MAIN().SeedObject());

            #endregion

            #region apps seed 

            var appBases = new List<IApp>();

            var type = typeof(IApp);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));
            foreach (var a in types)
            {
                if (a.Name != "IApp")
                {
                    var obj = (BaseApp)Activator.CreateInstance(a);
                    var app_item = obj.SeedObject();
                    //db.apps.AddOrUpdate(
                    //    app_item
                    //    );
                    var obj2 = (IApp)Activator.CreateInstance(a);
                    appBases.Add(obj2);
                }
            }
            foreach (var item in appBases)
            {
                item.Seed(db);
            }
            #endregion

        }
    }
}
