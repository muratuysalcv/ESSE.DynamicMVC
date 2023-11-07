using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI {
    public interface IGenericNote {

        IQueryable<app_entity_note> get_entity_notes(DBContext db);
    }
}