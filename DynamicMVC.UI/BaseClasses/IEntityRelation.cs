using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI {
    public interface IEntityRelation {
        IQueryable<T> get_entity_relations<T>(DBContext db, T type);
    }
}