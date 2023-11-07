using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public partial class DBContext : DbContext {

        // app
        public DbSet<app> apps { get; set; }
        

        // app server
        public DbSet<app_server> app_servers { get; set; }


        // app connection
        public DbSet<app_database_connection> app_database_connections { get; set; }
        public DbSet<app_database_connection_type> app_database_connection_types { get; set; }
        public DbSet<app_connection_relation> app_connection_relations { get; set; }

        // data source
        public DbSet<app_datasource> app_datasources { get; set; }
        public DbSet<app_datasource_type> app_datasource_types { get; set; }

        // app user and role permissions
        public DbSet<app_user> app_users { get; set; }
        public DbSet<app_role> app_roles { get; set; }
        public DbSet<app_permission> app_permissions { get; set; }

        // module
        public DbSet<app_module> app_modules { get; set; }

        // tables
        public DbSet<app_table> app_tables { get; set; }
        public DbSet<app_table_column> app_table_columns { get; set; }
        public DbSet<app_table_columntype> app_table_columntypes { get; set; }
        public DbSet<app_table_default_value_type> app_table_default_value_types { get; set; }

        // app dashboards
        public DbSet<app_dashboard> app_dashboards { get; set; }
        public DbSet<app_dashboard_type> app_dashboard_types { get; set; }


        // app process
        public DbSet<app_process> app_processes { get; set; }
        public DbSet<app_process_type> app_process_types { get; set; }
        public DbSet<app_process_log> app_process_logs { get; set; }
        public DbSet<app_page_command> app_page_commands { get; set; }

        

        // web services
        public DbSet<app_webservice> app_webservices { get; set; }
        public DbSet<app_webservice_type> app_webservice_types { get; set; }

        // app language
        public DbSet<app_language> app_languages { get; set; }
        public DbSet<app_language_word> app_language_words { get; set; }
        public DbSet<app_country> app_countries { get; set; }

        // files
        public DbSet<app_file> app_files { get; set; }
        public DbSet<app_file_type> app_file_types { get; set; }
        public DbSet<app_file_category> app_file_categories { get; set; }

        // icons
        public DbSet<app_icon> app_icons { get; set; }
        public DbSet<app_icon_type> app_icon_types { get; set; }


        public DbSet<app_unit> app_units { get; set; }
        public DbSet<app_setting> app_settings { get; set; }
        public DbSet<app_unit_type> app_unit_types { get; set; }
        public DbSet<app_status_type> app_status_types { get; set; }
        public DbSet<app_status> app_statuses { get; set; }
        public DbSet<app_navigation> app_navigations { get; set; }

        public DbSet<app_phone> app_phones { get; set; }
        public DbSet<app_phone_type> app_phone_types { get; set; }
        public DbSet<app_address> app_addresses { get; set; }
        public DbSet<app_address_type> app_address_types { get; set; }

        public DbSet<app_city> app_cities { get; set; }
        public DbSet<app_currency> app_currencies { get; set; }

        public DbSet<app_entity_note> app_entity_notes { get; set; }
        public DbSet<app_entity_relation> app_entity_relations { get; set; }

    }
}