using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public partial class DBContext : DbContext {

        public DbSet<hr_cv> hr_cvies { get; set; }
        public DbSet<hr_cv_item> hr_cv_items { get; set; }
        public DbSet<hr_cv_item_type> hr_cv_item_types { get; set; }

        public DbSet<hr_gender> hr_genders { get; set; }
        public DbSet<hr_job> hr_jobs { get; set; }
        public DbSet<hr_marriage_status> hr_marriage_statuses { get; set; }
        public DbSet<hr_organization> hr_organizations { get; set; }
        public DbSet<hr_organization_assignment> hr_organization_assignments { get; set; }
        public DbSet<hr_permission_assignment> hr_permission_assignments { get; set; }
        public DbSet<hr_salary_assignment > hr_salary_assignments { get; set; }
        public DbSet<hr_team> hr_team { get; set; }
        public DbSet<hr_team_assignment> hr_team_assignments { get; set; }
        public DbSet<hr_user_detail> hr_user_details { get; set; }

    }
}