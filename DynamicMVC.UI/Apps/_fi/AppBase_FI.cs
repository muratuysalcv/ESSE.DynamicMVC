using DynamicMVC.UI.DB;

namespace DynamicMVC.UI.Apps {
    using global::DynamicMVC.UI.DB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class AppBase_FI : BaseApp, IApp {
        public AppBase_FI()
        {
            this.system_name = "_fi";
            this.id = BaseApp.AppBase_8_FI;
            this.name = "FI";
            this.description = "Finance";
            this.is_active = true;
            this.icon_id = app_icon.material_attach_money.id;
        }

        public void Seed(DBContext db)
        {

            #region fi account types

            // yazýlýmý kullanan ana þirket hesaplarý türü
            db.fi_account_types.AddOrUpdate(
                new fi_account_type()
                {
                    id = "in",
                    name = "Inhouse",
                    system_name = "in"
                });

            // yazýlmda yer alan diðer þirkerlere ait olan finansal hesaplarýn türleri
            db.fi_account_types.AddOrUpdate(
               new fi_account_type()
               {
                   id = "out",
                   name = "Outsource",
                   system_name = "out"
               });

            // müþterilere ait olan finansal hesaplar
            db.fi_account_types.AddOrUpdate(
               new fi_account_type()
               {
                   id = "customer",
                   name = "Customer",
                   system_name = "customer"
               });

            #endregion

            #region transaction types

            // gelir
            db.fi_transaction_types.AddOrUpdate(
                new fi_transaction_type()
                {
                    id = "income",
                    name = "Income",
                    system_name = "income"
                });

            // gider
            db.fi_transaction_types.AddOrUpdate(
                new fi_transaction_type()
                {
                    id = "outgoing",
                    name = "Outgoing",
                    system_name = "outgoing"
                });

            // satýþ
            db.fi_transaction_types.AddOrUpdate(
                new fi_transaction_type()
                {
                    id = "income_sale",
                    name = "Sales Income",
                    system_name = "income_sale"
                });

            // alýþ
            db.fi_transaction_types.AddOrUpdate(
                new fi_transaction_type()
                {
                    id = "outgoing_buy",
                    name = "Buying Outgoing",
                    system_name = "outgoing_buy"
                });

            // maaþ
            db.fi_transaction_types.AddOrUpdate(
                new fi_transaction_type()
                {
                    id = "outgoing_salary",
                    name = "Salary Outcome",
                    system_name = "outgoing_salary"
                });

            #endregion

            #region invoice types

            db.fi_invoice_types.AddOrUpdate(new fi_invoice_type()
            {
                id = fi_invoice_type.sale_invoice,
                name = "Sales Invoice",
                system_name = fi_invoice_type.sale_invoice
            });
            db.fi_invoice_types.AddOrUpdate(new fi_invoice_type()
            {
                id = fi_invoice_type.waybill_invoice,
                name = "Waybill Invoice",
                system_name = fi_invoice_type.waybill_invoice
            });
            db.fi_invoice_types.AddOrUpdate(new fi_invoice_type()
            {
                id = fi_invoice_type.proforma_invoice,
                name = "Proforma Invoice",
                system_name = fi_invoice_type.proforma_invoice
            });

            db.fi_invoice_types.AddOrUpdate(new fi_invoice_type()
            {
                id = fi_invoice_type.return_invoice,
                name = "Return Invoice",
                system_name = fi_invoice_type.return_invoice
            });

            #endregion

            #region invoice item types

            db.fi_invoice_item_types.AddOrUpdate(new fi_invoice_item_type()
            {
                id = fi_invoice_item_type.length_item,
                name = "Length Invoice Item %18",
                tax_percentage = 18,
                unit_type_id = app_unit_type.length
            });

            db.fi_invoice_item_types.AddOrUpdate(new fi_invoice_item_type()
            {
                id = fi_invoice_item_type.liquid_item,
                name = "Liquid Invoice Item - %18",
                tax_percentage = 18,
                unit_type_id = app_unit_type.volume
            });

            db.fi_invoice_item_types.AddOrUpdate(new fi_invoice_item_type()
            {
                id = fi_invoice_item_type.quantity_item,
                name = "Quantity Invoice Item - %18",
                tax_percentage = 18,
                unit_type_id = app_unit_type.piece
            });

            #endregion

            #region invoice statuses

            // app status type
            db.app_status_types.AddOrUpdate(new app_status_type()
            {
                id = app_status_type.invoice,
                name = "Invoice",
                system_name = app_status_type.invoice
            });

            // app status definition
            db.app_statuses.AddOrUpdate(new app_status()
            {
                app_status_type_id = app_status_type.invoice,
                name = app_status.invoice_canceled,
                system_name = app_status.invoice_canceled,
                id = app_status.invoice_canceled,
                status_value = app_status.invoice_canceled
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                app_status_type_id = app_status_type.invoice,
                name = app_status.invoice_paid,
                system_name = app_status.invoice_paid,
                id = app_status.invoice_paid,
                status_value = app_status.invoice_paid
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                app_status_type_id = app_status_type.invoice,
                name = app_status.invoice_waiting,
                system_name = app_status.invoice_waiting,
                id = app_status.invoice_waiting,
                status_value = app_status.invoice_waiting
            });


            #endregion

            #region invoice item statuses

            // app status type
            db.app_status_types.AddOrUpdate(new app_status_type()
            {
                id = app_status_type.invoice_item,
                name = "Invoice Item",
                system_name = app_status_type.invoice_item
            });

            // app status definition
            db.app_statuses.AddOrUpdate(new app_status()
            {
                app_status_type_id = app_status_type.invoice_item,
                name = app_status.invoice_item_canceled,
                system_name = app_status.invoice_item_canceled,
                id = app_status.invoice_item_canceled,
                status_value = app_status.invoice_item_canceled
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                app_status_type_id = app_status_type.invoice_item,
                name = app_status.invoice_item_delivered,
                system_name = app_status.invoice_item_delivered,
                id = app_status.invoice_item_delivered,
                status_value = app_status.invoice_item_delivered
            });

            db.app_statuses.AddOrUpdate(new app_status()
            {
                app_status_type_id = app_status_type.invoice_item,
                name = app_status.invoice_item_waiting,
                system_name = app_status.invoice_item_waiting,
                id = app_status.invoice_item_waiting,
                status_value = app_status.invoice_item_waiting
            });

            #endregion

            #region payment types

            db.fi_payment_types.AddOrUpdate(new fi_payment_type()
            {
                id=fi_payment_type.cash,
                name=fi_payment_type.cash,
                system_name=fi_payment_type.cash
            });
            db.fi_payment_types.AddOrUpdate(new fi_payment_type()
            {
                id = fi_payment_type.credit_card,
                name = fi_payment_type.credit_card,
                system_name = fi_payment_type.credit_card
            });
            db.fi_payment_types.AddOrUpdate(new fi_payment_type()
            {
                id = fi_payment_type.future,
                name = fi_payment_type.future,
                system_name = fi_payment_type.future
            });
            db.fi_payment_types.AddOrUpdate(new fi_payment_type()
            {
                id = fi_payment_type.mail_order,
                name = fi_payment_type.mail_order,
                system_name = fi_payment_type.mail_order
            });


            #endregion

            #region invoice post types

            // only record as a digital document in DB
            db.fi_invoice_post_types.AddOrUpdate(new fi_invoice_post_type()
            {
                id=fi_invoice_post_type.digital_invoice,
                name="Digital Invoice",
                system_name=fi_invoice_post_type.digital_invoice
            });

            // if only one side has e-invoice support
            db.fi_invoice_post_types.AddOrUpdate(new fi_invoice_post_type()
            {
                id = fi_invoice_post_type.e_archieve_invoice,
                name = "E-Archieve Invoice",
                system_name = fi_invoice_post_type.e_archieve_invoice
            });

            // both side has e-invoice
            db.fi_invoice_post_types.AddOrUpdate(new fi_invoice_post_type()
            {
                id = fi_invoice_post_type.e_invoice,
                name = "E-Invoice",
                system_name = fi_invoice_post_type.e_invoice
            });

            // standart printed and post with shipment invoice
            db.fi_invoice_post_types.AddOrUpdate(new fi_invoice_post_type()
            {
                id = fi_invoice_post_type.printed_invoice,
                name = "Printed Invoice",
                system_name = fi_invoice_post_type.printed_invoice
            });

            #endregion

        }
    }
}
