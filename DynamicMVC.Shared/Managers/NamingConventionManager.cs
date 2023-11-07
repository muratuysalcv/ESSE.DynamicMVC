using System;
using System.Collections.Generic;
using System.Linq;
using DynamicMVC.Shared.Interfaces;

namespace DynamicMVC.Shared.Managers {
    public class NamingConventionManager : INamingConventionManager {
        public List<string> GetForiegnKeyByComplexProperty(string typeName, string complexPropertyName) {
            return new List<string> {
                complexPropertyName + "_id",
                complexPropertyName+"id"
            };
        }

        public bool IsController(Type type) {
            return type.Name.ToUpper().EndsWith("CONTROLLER");
        }

        /// <summary>
        /// Performs a case insenstive search for controller name.
        /// </summary>
        /// <param name="controllerNames">Controller names in the project</param>
        /// <param name="typeName">Dynamimc Entity Type Name</param>
        /// <returns>Returns controller name with origonal casing.</returns>
        public string FindControllerName(IEnumerable<string> controllerNames, string typeName) {
            var dictionary = new Dictionary<string, string>();
            foreach (var controllerName in controllerNames) {
                dictionary.Add(controllerName.ToUpper(), controllerName);
            }
            if (dictionary.ContainsKey(typeName.ToUpper() + "CONTROLLER"))
                return dictionary[typeName.ToUpper() + "CONTROLLER"];

            return null;
        }

        public string DynamicMenuCategory() {
            return "Dynamic";
        }

        public string FindDefaultPropertyName(string typeName, IEnumerable<string> propertyNames) {
            var properties = propertyNames.ToList();
            if (properties.Contains("name"))
                return "name";
            if (properties.Any(x => x.Contains("name")))
                return properties.First(x => x.Contains("name"));

            if (properties.Any(x => x.Contains("system_name")))
                return properties.First(x => x.Contains("system_name"));


            if (properties.Contains("description"))
                return "description";
            if (properties.Any(x => x.Contains("description")))
                return properties.First(x => x.Contains("description"));
            return "id";
        }
    }
}