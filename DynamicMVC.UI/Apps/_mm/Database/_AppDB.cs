using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public partial class DBContext : DbContext {

        public DbSet<mm_material> mm_materials { get; set; }
        public DbSet<mm_material_group> mm_material_groups { get; set; }
        public DbSet<mm_material_type> mm_material_types { get; set; }
        public DbSet<mm_stock> mm_stocks { get; set; }

    }
}