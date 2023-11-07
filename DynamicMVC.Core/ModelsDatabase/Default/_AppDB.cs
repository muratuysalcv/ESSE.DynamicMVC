using DynamicMVC.Core.ModelsDatabase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.Core.ModelsDatabase {
    public partial class DBContext : DbContext {

        // app
        public DbSet<App> Apps { get; set; }

        // app connection
        public DbSet<AppConnection> AppConnections { get; set; }
        public DbSet<AppConnectionType> AppConnectionTypes { get; set; }
        public DbSet<AppConnectionRelation> AppConnectionRelations { get; set; }

        // data source
        public DbSet<AppDataSource> AppDataSources { get; set; }
        public DbSet<AppDataSourceType> AppDataSourceTypes { get; set; }

        // app user and role permissions
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppPermission> AppPermissions { get; set; }

        // module
        public DbSet<AppModule> AppModules { get; set; }

        // tables
        public DbSet<AppTable> AppTables { get; set; }
        public DbSet<AppTableColumn> AppTableColumns { get; set; }
        public DbSet<AppTableSqlValueType> AppTableSqlValueTypes { get; set; }
        public DbSet<AppTableDefaultValueType> AppTableDefaultValueType { get; set; }

        // app dashboards
        public DbSet<AppDashboard> AppDashboards { get; set; }

        // app process
        public DbSet<AppProcess> AppProcesses { get; set; }
        public DbSet<AppProcessType> AppProcessTypes { get; set; }
        public DbSet<AppProcessLog> AppProcessLogs { get; set; }

        // web services
        public DbSet<AppWebService> AppWebService { get; set; }
        public DbSet<AppWebServiceType> AppWebServiceTypes { get; set; }

        // app language
        public DbSet<AppLanguage> AppLanguages { get; set; }
        public DbSet<AppLanguageWord> AppLanguageWords { get; set; }

        // files
        public DbSet<AppFile> AppFiles { get; set; }
        public DbSet<AppFileCategory> AppFileCategories { get; set; }
        public DbSet<AppFileType> AppFileTypes { get; set; }

    }
}