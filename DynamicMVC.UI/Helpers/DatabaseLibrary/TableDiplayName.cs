using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

/// <summary>
/// Summary description for TableDiplayName
/// </summary>

public class ResDiplayName : DisplayNameAttribute
{

    public ResDiplayName(string tableFieldName)
        : base(GetMessageFromResource(tableFieldName))
    {
    }



    public static string GetMessageFromResource(string tableFieldName)
    {
        var resourceProvider = new DbResourceProvider();

        try
        {
            return resourceProvider.GetResource(tableFieldName, Thread.CurrentThread.CurrentCulture.Name) + "";

        }
        catch (Exception)
        {
            return tableFieldName;
        }; // I want to retrun which is current porpery name, so that I can find display name in database based on the current field name retrun display name from Database 
    }

}
