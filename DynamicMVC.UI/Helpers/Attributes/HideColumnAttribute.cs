using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;

/// <summary>
/// Summary description for HideColumnAttribute
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class HideColumnInAttribute : Attribute {
    public HideColumnLocation[] HideColumnLocation { get; private set; }

    public HideColumnInAttribute() {
        HideColumnLocation = new HideColumnLocation[0];
    }

    public HideColumnInAttribute(params HideColumnLocation[] lookupTable) {
        HideColumnLocation = lookupTable;
    }

    public static HideColumnInAttribute Default = new HideColumnInAttribute();
}

public enum HideColumnLocation {
    Details,
    Edit,
    Insert,
    List,
    ListDetails,
    // add any custom page templates here
}

public class HideColumnFieldsManager : IAutoFieldGenerator {
    protected MetaTable _table;
    protected HideColumnLocation _currentPage;

    public MetaTable MetaTable {
        get {
            return _table;
        }
    }

    public HideColumnFieldsManager(MetaTable table, HideColumnLocation currentPage) {
        _table = table;
        _currentPage = currentPage;
    }

    public ICollection GenerateFields(Control control) {
        var oFields = new List<DynamicField>();

        foreach (var column in _table.Columns) {
            // carry on the loop at the next column  
            // if scaffold table is set to false or DenyRead
            if (!column.Scaffold || column.IsHidden(_currentPage))
                continue;

            var f = new DynamicField();

            f.DataField = column.Name;
            oFields.Add(f);
        }
        return oFields;
    }
}

public static class ExtensionMethods {
    public static Boolean IsHidden(this MetaColumn column, HideColumnLocation currentPage) {
        var hideIn = column.Attributes.OfType<HideColumnInAttribute>().DefaultIfEmpty(new HideColumnInAttribute()).First() as HideColumnInAttribute;
        return hideIn.HideColumnLocation.Contains(currentPage);
    }
}