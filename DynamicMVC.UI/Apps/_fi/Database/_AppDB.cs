using DynamicMVC.UI.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {
    public partial class DBContext : DbContext {

        public DbSet<fi_account> fi_accounts { get; set; }
        public DbSet<fi_account_type> fi_account_types { get; set; }
        public DbSet<fi_transaction> fi_transactions { get; set; }
        public DbSet<fi_transaction_type> fi_transaction_types { get; set; }
        public DbSet<fi_invoice> fi_invoices { get; set; }
        public DbSet<fi_invoice_type> fi_invoice_types { get; set; }
        public DbSet<fi_invoice_item> fi_invoice_items { get; set; }
        public DbSet<fi_invoice_item_type> fi_invoice_item_types { get; set; }
        public DbSet<fi_payment_type> fi_payment_types { get; set; }
        public DbSet<fi_invoice_post_type> fi_invoice_post_types { get; set; }

    }
}