using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;

namespace DynamicMVC.UI.DB {
    public interface IDbContextSchema {
        string Schema { get; }
    }

    class DatabaseInitializer : IDatabaseInitializer<DBContext> {
        public void InitializeDatabase(DBContext context) {
        }
    }

    public partial class DBContext : DbContext, IDbContextSchema {
        public DBContext()
            : base("ConnectionString") {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public string Schema { get; }

        public static DBContext Create() {
            return new DBContext();
        }

        public string GetTableName(ConventionTypeConfiguration c) {
            return c.ClrType.Name;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Types()
            //    .Configure(c => c.ToTable(GetTableName(c)));

            var conStrObj = (System.Configuration.ConnectionStringsSection)ConfigurationManager.GetSection("connectionStrings");
            string providerName = conStrObj.ConnectionStrings["ConnectionString"].ProviderName;
            if (providerName == "MySql.Data.MySqlClient") {

            } else if (providerName == "Oracle.ManagedDataAccess.Client") {
                modelBuilder.HasDefaultSchema("SA");
            }
        }

        //private string GetTableName(Type type) {
        //    var result = Regex.Replace(type.Name, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);

        //    return result.ToLower();
        //}
    }
}