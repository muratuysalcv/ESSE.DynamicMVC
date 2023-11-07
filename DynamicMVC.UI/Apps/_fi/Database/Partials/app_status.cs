using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    public partial class app_status {

        


        public static string invoice_waiting = "invoice_waiting";
        public static string invoice_paid = "invoice_paid";
        public static string invoice_canceled = "invoice_canceled";


        public static string invoice_item_waiting = "invoice_item_waiting";
        public static string invoice_item_delivered = "invoice_item_delivered";
        public static string invoice_item_canceled = "invoice_item_canceled";

    }
}