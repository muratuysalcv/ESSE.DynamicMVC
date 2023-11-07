using DynamicMVC.UI.Migrations;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DynamicMVC.UI.Controllers {
    public class ConsoleController : Controller {
        // GET: Console
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public JsonResult Execute() {

            var commandRequest = Request.Form["Command"] + "";
            var model = new consoleResult();
            var conStrObj = (System.Configuration.ConnectionStringsSection)ConfigurationManager.GetSection("connectionStrings");
            string providerName = conStrObj.ConnectionStrings["ConnectionString"].ProviderName;
            var values = commandRequest.Split(' ');
            var command = values[0];
            var parameters = new List<string>();

            foreach (var item in values) {
                if (item != command) {
                    parameters.Add(item);
                }
            }
            try {
                if (command == "add-migration") {

                    if (parameters.Count == 0) {

                        model.status = "error";
                        model.message = "Please insert a name for adding new migration!";

                    } else {

                        var configuration = new Migrations.Configuration();
                        var migrator = new DbMigrator(configuration);
                        migrator.Update();
                        model.status = "success";
                        model.message = "Database migration created successfully.";

                    }

                } else if (command == "update-database") {

                    var configuration = new Migrations.Configuration();
                    var migrator = new DbMigrator(configuration);
                    configuration.AutomaticMigrationDataLossAllowed = parameters.Contains("-Force");
                    configuration.AutomaticMigrationsEnabled = parameters.Contains("-Auto");
                    var scriptor = new MigratorScriptingDecorator(migrator);
                    string script = scriptor.ScriptUpdate(sourceMigration: null, targetMigration: null);
                    if (parameters.Contains("-for-history")) {
                        script = script.Split(';').LastOrDefault();
                    }
                    if (string.IsNullOrEmpty(script))
                    {
                        throw new Exception("Veritabanında bir değişiklik yok.");
                    }

                    // provider name check
                    if (providerName == "Npgsql") {

                        var sqlCon = new Npgsql.NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                        var cmd = new Npgsql.NpgsqlCommand(script, sqlCon);
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();

                    } else if (providerName == "System.Data.SqlClient") {

                        var sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                        var cmd = new SqlCommand(script, sqlCon);
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();

                    } else if (providerName == "MySql.Data.MySqlClient") {

                        script = script.Replace("engine=InnoDb auto_increment=0", "engine=InnoDb auto_increment=0;");
                        var sqlCon = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                        var cmd = new MySqlCommand(script, sqlCon);
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();

                    } else if (providerName == "Oracle.ManagedDataAccess.Client") {

                        var sqlCon = new OracleConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                        var cmd = new OracleCommand(script, sqlCon);
                        sqlCon.Open();
                        var commands = script.Split('/');
                        foreach (var commandText in commands) {
                            try {
                                cmd.CommandText = commandText;
                                cmd.ExecuteNonQuery();
                            } catch (Exception ex) {
                                throw new Exception(ex.Message+ " Command hatası sql:" + commandText);
                            }
                        }
                        sqlCon.Close();
                    }

                    model.status = "success";
                    model.message = "Database update completed successfully.";

                } else {

                    model.message = "Could not find command. Please check again.";
                    model.status = "error";

                }
            } catch (Exception ex) {
                string errorMessage = ex.Message;
                var subEx = ex;
                while (subEx.InnerException != null) {
                    subEx = subEx.InnerException;
                }

                model.status = "error";
                model.message = subEx.Message;
            }

            return Json(model);
        }
    }
    public class consoleResult {
        public string status { get; set; }
        public string message { get; set; }
    }
}