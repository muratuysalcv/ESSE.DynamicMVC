using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public partial class DBContext : DbContext {
        public DbSet<lo_shipment_type> lo_shipping_types { get; set; }
        public DbSet<lo_shipment_item> lo_shipment_items { get; set; }
        public DbSet<lo_shipment_item_type> lo_shipment_item_types { get; set; }
        public DbSet<lo_shipment> lo_shipments { get; set; }
    }
}