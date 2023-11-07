using DynamicMVC.UI;
using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserInfo
/// </summary>
public class UserSessionInfo {

    // logined user object
    public app_user user { get; set; }

    // user full name
    public string FullName { get { return this.user.username; } }

    // login status - check for if user logined
    public bool login_status { get { return this.user != null; } }

    // constructor - loads current user object from database
    public UserSessionInfo()
    {
        var httpContext = HttpContext.Current;
        if (httpContext.Session == null)
            return;
        if (httpContext.Session["UserId"] != null)
        {
            var userIdVal = httpContext.Session["UserId"] + "";
            int userId = 0;
            try
            {
                userId = Convert.ToInt32(userIdVal);
                var db = new DBContext();// DBCon.Getir()
                var userObject = db.app_users.FirstOrDefault(x => x.id == userId);
                if (userObject != null)
                {
                    this.user = userObject;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}