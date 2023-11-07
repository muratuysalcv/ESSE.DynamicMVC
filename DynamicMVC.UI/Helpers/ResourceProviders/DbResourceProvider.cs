using DynamicMVC.UI;
using DynamicMVC.UI.DB;
using Resources;
using Resources.Abstract;
using Resources.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DbResourceProvider
/// </summary>
public class DbResourceProvider : BaseResourceProvider {

    public DBContext db = new DBContext();

    // Database connection string        
    private static string connectionString = null;
    public DbResourceProvider() {
    }
    public DbResourceProvider(string connection) {
        connectionString = connection;
    }
    protected override IList<ResourceEntry> ReadResources() {
        var resources = new List<ResourceEntry>();
        foreach (var item in db.app_language_words) {
            resources.Add(
                new ResourceEntry() {
                    Culture = item.app_language.culture,
                    Name = item.resource_key,
                    Value = item.resource_value,
                }
                );
        }
        return resources;
    }
    protected override ResourceEntry ReadResource(string name, string culture) {

        ResourceEntry resource = new ResourceEntry();
        var appLanguageWord = db.app_language_words.FirstOrDefault(x => x.resource_key == name && x.app_language.culture == culture);
        if(appLanguageWord!=null) {
            resource.Name = appLanguageWord.resource_key;
            resource.Culture = appLanguageWord.app_language.culture;
            resource.Value = appLanguageWord.resource_value;
        } else {
            resource.Name = name;
            resource.Culture = culture;
            resource.Value = name;
        }
                
        return resource;
    }
}