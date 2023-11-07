using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    public partial class app_icon {

        public string render_html()
        {
            app_icon_type iconType = null;

            if(this.icon_type_id== app_icon_type.material_icons.id)
            {
                iconType = app_icon_type.material_icons;
            }
            else if (this.icon_type_id == app_icon_type.font_awesome.id)
            {
                iconType = app_icon_type.font_awesome;
            }
            else
            {
                return this.icon_info;
            }
            return iconType.html_format.Replace("{icon_info}", this.icon_info);
        }

        public static app_icon material_dashboard = new app_icon()
        {
            id = "material_dashboard",
            name = "Material Dashboard",
            icon_info = "dashboard",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_access_time = new app_icon()
        {
            id = "material_access_time",
            name = "Material access_time",
            icon_info = "access_time",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_timelapse = new app_icon()
        {
            id = "material_timelapse",
            name = "Material timelapse",
            icon_info = "timelapse",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_ac_unit = new app_icon()
        {
            id = "material_ac_unit",
            name = "Material ac_unit",
            icon_info = "ac_unit",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_access_alarm = new app_icon()
        {
            id = "material_access_alarms",
            name = "Material access_alarms",
            icon_info = "access_alarms",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_accessibility = new app_icon()
        {
            id = "material_accessibility",
            name = "Material accessibility",
            icon_info = "accessibility",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_accessible = new app_icon()
        {
            id = "material_accessible",
            name = "Material accessible",
            icon_info = "accessible",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_account_balance = new app_icon()
        {
            id = "material_account_balance",
            name = "Material account_balance",
            icon_info = "account_balance",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_account_balance_wallet = new app_icon()
        {
            id = "material_account_balance_wallet",
            name = "Material account_balance_wallet",
            icon_info = "account_balance_wallet",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_account_box_wallet = new app_icon()
        {
            id = "material_account_box_wallet",
            name = "Material account_box_wallet",
            icon_info = "account_box_wallet",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_account_circle = new app_icon()
        {
            id = "material_account_circle",
            name = "Material account_circle",
            icon_info = "account_circle",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_adb = new app_icon()
        {
            id = "material_adb",
            name = "Material adb",
            icon_info = "adb",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add = new app_icon()
        {
            id = "material_add",
            name = "Material add",
            icon_info = "add",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_a_photo = new app_icon()
        {
            id = "material_add_a_photo",
            name = "Material add_a_photo",
            icon_info = "add_a_photo",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_alarm = new app_icon()
        {
            id = "material_add_alarm",
            name = "Material add_alarm",
            icon_info = "add_alarm",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_alert = new app_icon()
        {
            id = "material_add_alert",
            name = "Material add_alert",
            icon_info = "add_alert",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_box = new app_icon()
        {
            id = "material_add_box",
            name = "Material add_box",
            icon_info = "add_box",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_circle = new app_icon()
        {
            id = "material_add_circle",
            name = "Material add_circle",
            icon_info = "add_circle",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_circle_outline = new app_icon()
        {
            id = "material_add_circle_outline",
            name = "Material add_circle_outline",
            icon_info = "add_circle_outline",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_location = new app_icon()
        {
            id = "material_add_location",
            name = "Material add_location",
            icon_info = "add_location",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_add_shopping_cart = new app_icon()
        {
            id = "material_add_shopping_cart",
            name = "Material add_shopping_cart",
            icon_info = "add_shopping_cart",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_add_to_queue = new app_icon()
        {
            id = "material_add_to_queue",
            name = "Material add_to_queue",
            icon_info = "add_to_queue",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_adjust = new app_icon()
        {
            id = "material_adjust",
            name = "Material adjust",
            icon_info = "adjust",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_airplanemode_active = new app_icon()
        {
            id = "material_airplanemode_active",
            name = "Material airplanemode_active",
            icon_info = "airplanemode_active",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_airplay = new app_icon()
        {
            id = "material_airplay",
            name = "Material airplay",
            icon_info = "airplay",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_alarm = new app_icon()
        {
            id = "material_alarm",
            name = "Material alarm",
            icon_info = "alarm",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_alarm_add = new app_icon()
        {
            id = "material_alarm_add",
            name = "Material alarm_add",
            icon_info = "alarm_add",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_alarm_off = new app_icon()
        {
            id = "material_alarm_off",
            name = "Material alarm_off",
            icon_info = "alarm_off",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_alarm_on = new app_icon()
        {
            id = "material_alarm_on",
            name = "Material alarm_on",
            icon_info = "alarm_on",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_all_inclusive = new app_icon()
        {
            id = "material_all_inclusive",
            name = "Material all_inclusive",
            icon_info = "all_inclusive",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_all_out = new app_icon()
        {
            id = "material_all_out",
            name = "Material all_out",
            icon_info = "all_out",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_apps = new app_icon()
        {
            id = "material_apps",
            name = "Material apps",
            icon_info = "apps",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_announcement = new app_icon()
        {
            id = "material_announcement",
            name = "Material announcement",
            icon_info = "announcement",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_android = new app_icon()
        {
            id = "material_android",
            name = "Material android",
            icon_info = "android",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_arrow_back = new app_icon()
        {
            id = "material_arrow_back",
            name = "Material arrow_back",
            icon_info = "arrow_back",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_arrow_downward = new app_icon()
        {
            id = "material_arrow_downward",
            name = "Material arrow_downward",
            icon_info = "arrow_downward",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_arrow_drop_down = new app_icon()
        {
            id = "material_arrow_drop_down",
            name = "Material arrow_drop_down",
            icon_info = "arrow_drop_down",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_arrow_drop_down_circle = new app_icon()
        {
            id = "material_arrow_drop_down_circle",
            name = "Material arrow_drop_down_circle",
            icon_info = "arrow_drop_down_circle",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_arrow_drop_up = new app_icon()
        {
            id = "material_arrow_drop_up",
            name = "Material arrow_drop_up",
            icon_info = "arrow_drop_up",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_arrow_forward = new app_icon()
        {
            id = "material_arrow_forward",
            name = "Material arrow_forward",
            icon_info = "arrow_forward",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_arrow_upward = new app_icon()
        {
            id = "material_arrow_upward",
            name = "Material arrow_upward",
            icon_info = "arrow_upward",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_aspect_ratio = new app_icon()
        {
            id = "material_aspect_ratio",
            name = "Material aspect_ratio",
            icon_info = "aspect_ratio",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_assignment_turned_in = new app_icon()
        {
            id = "material_assignment_turned_in",
            name = "Material assignment_turned_in",
            icon_info = "assignment_turned_in",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_assistant = new app_icon()
        {
            id = "material_assistant",
            name = "Material assistant",
            icon_info = "assistant",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_attach_file = new app_icon()
        {
            id = "material_attach_file",
            name = "Material attach_file",
            icon_info = "attach_file",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_attach_money = new app_icon()
        {
            id = "material_attach_money",
            name = "Material attach_money",
            icon_info = "attach_money",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_attachment = new app_icon()
        {
            id = "material_attachment",
            name = "Material attachment",
            icon_info = "attachment",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_audiotrack = new app_icon()
        {
            id = "material_audiotrack",
            name = "Material audiotrack",
            icon_info = "audiotrack",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_autorenew = new app_icon()
        {
            id = "material_autorenew",
            name = "Material autorenew",
            icon_info = "autorenew",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_av_timer = new app_icon()
        {
            id = "material_av_timer",
            name = "Material av_timer",
            icon_info = "av_timer",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_backspace = new app_icon()
        {
            id = "material_backspace",
            name = "Material backspace",
            icon_info = "backspace",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_backup = new app_icon()
        {
            id = "material_backup",
            name = "Material backup",
            icon_info = "backup",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_battery_alert = new app_icon()
        {
            id = "material_battery_alert",
            name = "Material battery_alert",
            icon_info = "battery_alert",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_battery_charging_full = new app_icon()
        {
            id = "material_battery_charging_full",
            name = "Material battery_charging_full",
            icon_info = "battery_charging_full",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_battery_full = new app_icon()
        {
            id = "material_battery_full",
            name = "Material battery_full",
            icon_info = "battery_full",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_battery_std = new app_icon()
        {
            id = "material_battery_std",
            name = "Material battery_std",
            icon_info = "battery_std",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_battery_unknown = new app_icon()
        {
            id = "material_battery_unknown",
            name = "Material battery_unknown",
            icon_info = "battery_unknown",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_beach_access = new app_icon()
        {
            id = "material_beach_access",
            name = "Material beach_access",
            icon_info = "beach_access",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_beenhere = new app_icon()
        {
            id = "material_beenhere",
            name = "Material beenhere",
            icon_info = "beenhere",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_block = new app_icon()
        {
            id = "material_block",
            name = "Material block",
            icon_info = "block",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bluetooth = new app_icon()
        {
            id = "material_bluetooth",
            name = "Material bluetooth",
            icon_info = "bluetooth",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bluetooth_audio = new app_icon()
        {
            id = "material_bluetooth_audio",
            name = "Material bluetooth_audio",
            icon_info = "bluetooth_audio",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bluetooth_connected = new app_icon()
        {
            id = "material_bluetooth_connected",
            name = "Material bluetooth_connected",
            icon_info = "bluetooth_connected",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bluetooth_disabled = new app_icon()
        {
            id = "material_bluetooth_disabled",
            name = "Material bluetooth_disabled",
            icon_info = "bluetooth_disabled",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bluetooth_searching = new app_icon()
        {
            id = "material_bluetooth_searching",
            name = "Material bluetooth_searching",
            icon_info = "bluetooth_searching",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_blur_circular = new app_icon()
        {
            id = "material_blur_circular",
            name = "Material blur_circular",
            icon_info = "blur_circular",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_blur_linear = new app_icon()
        {
            id = "material_blur_linear",
            name = "Material blur_linear",
            icon_info = "blur_linear",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_blur_off = new app_icon()
        {
            id = "material_blur_off",
            name = "Material blur_off",
            icon_info = "blur_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_blur_on = new app_icon()
        {
            id = "material_blur_on",
            name = "Material blur_on",
            icon_info = "blur_on",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_book = new app_icon()
        {
            id = "material_book",
            name = "Material book",
            icon_info = "book",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bookmark = new app_icon()
        {
            id = "material_bookmark",
            name = "Material bookmark",
            icon_info = "bookmark",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bookmark_border = new app_icon()
        {
            id = "material_bookmark_border",
            name = "Material bookmark_border",
            icon_info = "bookmark_border",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_all = new app_icon()
        {
            id = "material_border_all",
            name = "Material border_all",
            icon_info = "border_all",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_bottom = new app_icon()
        {
            id = "material_border_bottom",
            name = "Material border_bottom",
            icon_info = "border_bottom",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_clear = new app_icon()
        {
            id = "material_border_clear",
            name = "Material border_clear",
            icon_info = "border_clear",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_color = new app_icon()
        {
            id = "material_border_color",
            name = "Material border_color",
            icon_info = "border_color",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_horizontal = new app_icon()
        {
            id = "material_border_horizontal",
            name = "Material border_horizontal",
            icon_info = "border_horizontal",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_inner = new app_icon()
        {
            id = "material_border_inner",
            name = "Material border_inner",
            icon_info = "border_inner",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_left = new app_icon()
        {
            id = "material_border_left",
            name = "Material border_left",
            icon_info = "border_left",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_outer = new app_icon()
        {
            id = "material_border_outer",
            name = "Material border_outer",
            icon_info = "border_outer",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_right = new app_icon()
        {
            id = "material_border_right",
            name = "Material border_right",
            icon_info = "border_right",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_style = new app_icon()
        {
            id = "material_border_style",
            name = "Material border_style",
            icon_info = "border_style",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_top = new app_icon()
        {
            id = "material_border_top",
            name = "Material border_top",
            icon_info = "border_top",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_border_vertical = new app_icon()
        {
            id = "material_border_vertical",
            name = "Material border_vertical",
            icon_info = "border_vertical",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_broken_image = new app_icon()
        {
            id = "material_broken_image",
            name = "Material broken_image",
            icon_info = "broken_image",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_brush = new app_icon()
        {
            id = "material_brush",
            name = "Material brush",
            icon_info = "brush",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bubble_chart = new app_icon()
        {
            id = "material_bubble_chart",
            name = "Material bubble_chart",
            icon_info = "bubble_chart",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_bug_report = new app_icon()
        {
            id = "material_bug_report",
            name = "Material bug_report",
            icon_info = "bug_report",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_build = new app_icon()
        {
            id = "material_build",
            name = "Material build",
            icon_info = "build",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_business = new app_icon()
        {
            id = "material_business",
            name = "Material business",
            icon_info = "business",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_business_center = new app_icon()
        {
            id = "material_business_center",
            name = "Material business_center",
            icon_info = "business_center",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cached = new app_icon()
        {
            id = "material_cached",
            name = "Material cached",
            icon_info = "cached",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cake = new app_icon()
        {
            id = "material_cake",
            name = "Material cake",
            icon_info = "cake",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_call = new app_icon()
        {
            id = "material_call",
            name = "Material call",
            icon_info = "call",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_call_end = new app_icon()
        {
            id = "material_call_end",
            name = "Material call_end",
            icon_info = "call_end",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_call_made = new app_icon()
        {
            id = "material_call_made",
            name = "Material call_made",
            icon_info = "call_made",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_call_merge = new app_icon()
        {
            id = "material_call_merge",
            name = "Material call_merge",
            icon_info = "call_merge",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_call_missed = new app_icon()
        {
            id = "material_call_missed",
            name = "Material call_missed",
            icon_info = "call_missed",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_call_missed_outgoing = new app_icon()
        {
            id = "material_call_missed_outgoing",
            name = "Material call_missed_outgoing",
            icon_info = "call_missed_outgoing",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_call_received = new app_icon()
        {
            id = "material_call_received",
            name = "Material call_received",
            icon_info = "call_received",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_call_split = new app_icon()
        {
            id = "material_call_split",
            name = "Material call_split",
            icon_info = "call_split",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_camera = new app_icon()
        {
            id = "material_camera",
            name = "Material camera",
            icon_info = "camera",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_camera_alt = new app_icon()
        {
            id = "material_camera_alt",
            name = "Material camera_alt",
            icon_info = "camera_alt",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_camera_enhance = new app_icon()
        {
            id = "material_camera_enhance",
            name = "Material camera_enhance",
            icon_info = "camera_enhance",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_camera_front = new app_icon()
        {
            id = "material_camera_front",
            name = "Material camera_front",
            icon_info = "camera_front",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_camera_rear = new app_icon()
        {
            id = "material_camera_rear",
            name = "Material camera_rear",
            icon_info = "camera_rear",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_camera_roll = new app_icon()
        {
            id = "material_camera_roll",
            name = "Material camera_roll",
            icon_info = "camera_roll",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cancel = new app_icon()
        {
            id = "material_cancel",
            name = "Material cancel",
            icon_info = "cancel",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_card_giftcard = new app_icon()
        {
            id = "material_card_giftcard",
            name = "Material card_giftcard",
            icon_info = "card_giftcard",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_card_membership = new app_icon()
        {
            id = "material_card_membership",
            name = "Material card_membership",
            icon_info = "card_membership",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_card_travel = new app_icon()
        {
            id = "material_card_travel",
            name = "Material card_travel",
            icon_info = "card_travel",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_casino = new app_icon()
        {
            id = "material_casino",
            name = "Material casino",
            icon_info = "casino",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cast = new app_icon()
        {
            id = "material_cast",
            name = "Material cast",
            icon_info = "cast",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cast_connected = new app_icon()
        {
            id = "material_cast_connected",
            name = "Material cast_connected",
            icon_info = "cast_connected",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_center_focus_strong = new app_icon()
        {
            id = "material_center_focus_strong",
            name = "Material center_focus_strong",
            icon_info = "center_focus_strong",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_center_focus_weak = new app_icon()
        {
            id = "material_center_focus_weak",
            name = "Material center_focus_weak",
            icon_info = "center_focus_weak",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_change_history = new app_icon()
        {
            id = "material_change_history",
            name = "Material change_history",
            icon_info = "change_history",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_chat = new app_icon()
        {
            id = "material_chat",
            name = "Material chat",
            icon_info = "chat",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_chat_bubble = new app_icon()
        {
            id = "material_chat_bubble",
            name = "Material chat_bubble",
            icon_info = "chat_bubble",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_chat_bubble_outline = new app_icon()
        {
            id = "material_chat_bubble_outline",
            name = "Material chat_bubble_outline",
            icon_info = "chat_bubble_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_check = new app_icon()
        {
            id = "material_check",
            name = "Material check",
            icon_info = "check",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_check_box = new app_icon()
        {
            id = "material_check_box",
            name = "Material check_box",
            icon_info = "check_box",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_check_box_outline_blank = new app_icon()
        {
            id = "material_check_box_outline_blank",
            name = "Material check_box_outline_blank",
            icon_info = "check_box_outline_blank",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_check_circle = new app_icon()
        {
            id = "material_check_circle",
            name = "Material check_circle",
            icon_info = "check_circle",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_chevron_left = new app_icon()
        {
            id = "material_chevron_left",
            name = "Material chevron_left",
            icon_info = "chevron_left",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_chevron_right = new app_icon()
        {
            id = "material_chevron_right",
            name = "Material chevron_right",
            icon_info = "chevron_right",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_child_care = new app_icon()
        {
            id = "material_child_care",
            name = "Material child_care",
            icon_info = "child_care",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_child_friendly = new app_icon()
        {
            id = "material_child_friendly",
            name = "Material child_friendly",
            icon_info = "child_friendly",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_chome_reader_mode = new app_icon()
        {
            id = "material_chome_reader_mode",
            name = "Material chome_reader_mode",
            icon_info = "chome_reader_mode",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_class = new app_icon()
        {
            id = "material_class",
            name = "Material class",
            icon_info = "class",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_clear = new app_icon()
        {
            id = "material_clear",
            name = "Material clear",
            icon_info = "clear",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_clear_all = new app_icon()
        {
            id = "material_clear_all",
            name = "Material clear_all",
            icon_info = "clear_all",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_close = new app_icon()
        {
            id = "material_close",
            name = "Material close",
            icon_info = "close",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_closed_caption = new app_icon()
        {
            id = "material_closed_caption",
            name = "Material closed_caption",
            icon_info = "closed_caption",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cloud = new app_icon()
        {
            id = "material_cloud",
            name = "Material cloud",
            icon_info = "cloud",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cloud_circle = new app_icon()
        {
            id = "material_cloud_circle",
            name = "Material cloud_circle",
            icon_info = "cloud_circle",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cloud_done = new app_icon()
        {
            id = "material_cloud_done",
            name = "Material cloud_done",
            icon_info = "cloud_done",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cloud_download = new app_icon()
        {
            id = "material_cloud_download",
            name = "Material cloud_download",
            icon_info = "cloud_download",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cloud_off = new app_icon()
        {
            id = "material_cloud_off",
            name = "Material cloud_off",
            icon_info = "cloud_off",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_cloud_queue = new app_icon()
        {
            id = "material_cloud_queue",
            name = "Material cloud_queue",
            icon_info = "cloud_queue",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_cloud_upload = new app_icon()
        {
            id = "material_cloud_upload",
            name = "Material cloud_upload",
            icon_info = "cloud_upload",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_code = new app_icon()
        {
            id = "material_code",
            name = "Material code",
            icon_info = "code",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_collections = new app_icon()
        {
            id = "material_collections",
            name = "Material collections",
            icon_info = "collections",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_collections_bookmark = new app_icon()
        {
            id = "material_collections_bookmark",
            name = "Material collections_bookmark",
            icon_info = "collections_bookmark",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_color_lens = new app_icon()
        {
            id = "material_color_lens",
            name = "Material color_lens",
            icon_info = "color_lens",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_colorize = new app_icon()
        {
            id = "material_colorize",
            name = "Material colorize",
            icon_info = "colorize",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_comment = new app_icon()
        {
            id = "material_comment",
            name = "Material comment",
            icon_info = "comment",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_compare = new app_icon()
        {
            id = "material_compare",
            name = "Material compare",
            icon_info = "compare",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_compare_arrows = new app_icon()
        {
            id = "material_compare_arrows",
            name = "Material compare_arrows",
            icon_info = "compare_arrows",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_computer = new app_icon()
        {
            id = "material_computer",
            name = "Material computer",
            icon_info = "computer",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_contact_mail = new app_icon()
        {
            id = "material_contact_mail",
            name = "Material contact_mail",
            icon_info = "contact_mail",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_contact_phone = new app_icon()
        {
            id = "material_contact_phone",
            name = "Material contact_phone",
            icon_info = "contact_phone",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_contacts = new app_icon()
        {
            id = "material_contacts",
            name = "Material contacts",
            icon_info = "contacts",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_content_copy = new app_icon()
        {
            id = "material_content_copy",
            name = "Material content_copy",
            icon_info = "content_copy",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_content_cut = new app_icon()
        {
            id = "material_content_cut",
            name = "Material content_cut",
            icon_info = "content_cut",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_content_paste = new app_icon()
        {
            id = "material_content_paste",
            name = "Material content_paste",
            icon_info = "content_paste",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_control_point = new app_icon()
        {
            id = "material_control_point",
            name = "Material control_point",
            icon_info = "control_point",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_control_point_duplicate = new app_icon()
        {
            id = "material_control_point_duplicate",
            name = "Material control_point_duplicate",
            icon_info = "control_point_duplicate",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_copyright = new app_icon()
        {
            id = "material_copyright",
            name = "Material copyright",
            icon_info = "copyright",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_create = new app_icon()
        {
            id = "material_create",
            name = "Material create",
            icon_info = "create",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_create_new_folder = new app_icon()
        {
            id = "material_create_new_folder",
            name = "Material create_new_folder",
            icon_info = "create_new_folder",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_credit_card = new app_icon()
        {
            id = "material_credit_card",
            name = "Material credit_card",
            icon_info = "credit_card",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop = new app_icon()
        {
            id = "material_crop",
            name = "Material crop",
            icon_info = "crop",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_crop_16_9 = new app_icon()
        {
            id = "material_crop_16_9",
            name = "Material crop_16_9",
            icon_info = "crop_16_9",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_3_2 = new app_icon()
        {
            id = "material_crop_3_2",
            name = "Material crop_3_2",
            icon_info = "crop_3_2",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_5_4 = new app_icon()
        {
            id = "material_crop_5_4",
            name = "Material crop_5_4",
            icon_info = "crop_5_4",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_7_5 = new app_icon()
        {
            id = "material_crop_7_5",
            name = "Material crop_7_5",
            icon_info = "crop_7_5",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_din = new app_icon()
        {
            id = "material_crop_din",
            name = "Material crop_din",
            icon_info = "crop_din",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_free = new app_icon()
        {
            id = "material_crop_free",
            name = "Material crop_free",
            icon_info = "crop_free",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_landscape = new app_icon()
        {
            id = "material_crop_landscape",
            name = "Material crop_landscape",
            icon_info = "crop_landscape",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_original = new app_icon()
        {
            id = "material_crop_original",
            name = "Material crop_original",
            icon_info = "crop_original",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_potrait = new app_icon()
        {
            id = "material_crop_potrait",
            name = "Material crop_potrait",
            icon_info = "crop_potrait",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_rotate = new app_icon()
        {
            id = "material_crop_rotate",
            name = "Material crop_rotate",
            icon_info = "crop_rotate",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_crop_square = new app_icon()
        {
            id = "material_crop_square",
            name = "Material crop_square",
            icon_info = "crop_square",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_data_usage = new app_icon()
        {
            id = "material_data_usage",
            name = "Material data_usage",
            icon_info = "data_usage",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_date_range = new app_icon()
        {
            id = "material_date_range",
            name = "Material date_range",
            icon_info = "date_range",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_dehaze = new app_icon()
        {
            id = "material_dehaze",
            name = "Material dehaze",
            icon_info = "dehaze",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_delete = new app_icon()
        {
            id = "material_delete",
            name = "Material delete",
            icon_info = "delete",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_delete_forever = new app_icon()
        {
            id = "material_delete_forever",
            name = "Material delete_forever",
            icon_info = "delete_forever",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_delete_sweep = new app_icon()
        {
            id = "material_delete_sweep",
            name = "Material delete_sweep",
            icon_info = "delete_sweep",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_description = new app_icon()
        {
            id = "material_description",
            name = "Material description",
            icon_info = "description",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_desktop_mac = new app_icon()
        {
            id = "material_desktop_mac",
            name = "Material desktop_mac",
            icon_info = "desktop_mac",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_desktop_windows = new app_icon()
        {
            id = "material_desktop_windows",
            name = "Material desktop_windows",
            icon_info = "desktop_windows",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_details = new app_icon()
        {
            id = "material_details",
            name = "Material details",
            icon_info = "details",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_developer_board = new app_icon()
        {
            id = "material_developer_board",
            name = "Material developer_board",
            icon_info = "developer_board",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_developer_mode = new app_icon()
        {
            id = "material_developer_mode",
            name = "Material developer_mode",
            icon_info = "developer_mode",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_device_hub = new app_icon()
        {
            id = "material_device_hub",
            name = "Material device_hub",
            icon_info = "device_hub",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_devices = new app_icon()
        {
            id = "material_devices",
            name = "Material devices",
            icon_info = "devices",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_devices_other = new app_icon()
        {
            id = "material_devices_other",
            name = "Material devices_other",
            icon_info = "devices_other",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_dialer_sip = new app_icon()
        {
            id = "material_dialer_sip",
            name = "Material dialer_sip",
            icon_info = "dialer_sip",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_dialpad = new app_icon()
        {
            id = "material_dialpad",
            name = "Material dialpad",
            icon_info = "dialpad",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions = new app_icon()
        {
            id = "material_directions",
            name = "Material directions",
            icon_info = "directions",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_bike = new app_icon()
        {
            id = "material_directions_bike",
            name = "Material directions_bike",
            icon_info = "directions_bike",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_boat = new app_icon()
        {
            id = "material_directions_boat",
            name = "Material directions_boat",
            icon_info = "directions_boat",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_bus = new app_icon()
        {
            id = "material_directions_bus",
            name = "Material directions_bus",
            icon_info = "directions_bus",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_car = new app_icon()
        {
            id = "material_directions_car",
            name = "Material directions_car",
            icon_info = "directions_car",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_railway = new app_icon()
        {
            id = "material_directions_railway",
            name = "Material directions_railway",
            icon_info = "directions_railway",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_run = new app_icon()
        {
            id = "material_directions_run",
            name = "Material directions_run",
            icon_info = "directions_run",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_subway = new app_icon()
        {
            id = "material_directions_subway",
            name = "Material directions_subway",
            icon_info = "directions_subway",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_transit = new app_icon()
        {
            id = "material_directions_transit",
            name = "Material directions_transit",
            icon_info = "directions_transit",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_directions_walk = new app_icon()
        {
            id = "material_directions_walk",
            name = "Material directions_walk",
            icon_info = "directions_walk",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_disc_full = new app_icon()
        {
            id = "material_disc_full",
            name = "Material disc_full",
            icon_info = "disc_full",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_dns = new app_icon()
        {
            id = "material_dns",
            name = "Material dns",
            icon_info = "dns",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_do_not_disturb = new app_icon()
        {
            id = "material_do_not_disturb",
            name = "Material do_not_disturb",
            icon_info = "do_not_disturb",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_do_not_disturb_alt = new app_icon()
        {
            id = "material_do_not_disturb_alt",
            name = "Material do_not_disturb_alt",
            icon_info = "do_not_disturb_alt",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_do_not_disturb_off = new app_icon()
        {
            id = "material_do_not_disturb_off",
            name = "Material do_not_disturb_off",
            icon_info = "do_not_disturb_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_do_not_disturb_on = new app_icon()
        {
            id = "material_do_not_disturb_on",
            name = "Material do_not_disturb_on",
            icon_info = "do_not_disturb_on",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_dock = new app_icon()
        {
            id = "material_dock",
            name = "Material dock",
            icon_info = "dock",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_domain = new app_icon()
        {
            id = "material_domain",
            name = "Material domain",
            icon_info = "domain",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_done = new app_icon()
        {
            id = "material_done",
            name = "Material done",
            icon_info = "done",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_done_all = new app_icon()
        {
            id = "material_done_all",
            name = "Material done_all",
            icon_info = "done_all",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_donut_large = new app_icon()
        {
            id = "material_donut_large",
            name = "Material donut_large",
            icon_info = "donut_large",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_donut_small = new app_icon()
        {
            id = "material_donut_small",
            name = "Material donut_small",
            icon_info = "donut_small",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_drafts = new app_icon()
        {
            id = "material_drafts",
            name = "Material drafts",
            icon_info = "drafts",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_edit = new app_icon()
        {
            id = "material_edit",
            name = "Material edit",
            icon_info = "edit",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_edit_location = new app_icon()
        {
            id = "material_edit_location",
            name = "Material edit_location",
            icon_info = "edit_location",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_eject = new app_icon()
        {
            id = "material_eject",
            name = "Material eject",
            icon_info = "eject",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_email = new app_icon()
        {
            id = "material_email",
            name = "Material email",
            icon_info = "email",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_enhanced_encryption = new app_icon()
        {
            id = "material_enhanced_encryption",
            name = "Material enhanced_encryption",
            icon_info = "enhanced_encryption",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_equalizer = new app_icon()
        {
            id = "material_equalizer",
            name = "Material equalizer",
            icon_info = "equalizer",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_error = new app_icon()
        {
            id = "material_error",
            name = "Material error",
            icon_info = "error",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_error_outline = new app_icon()
        {
            id = "material_error_outline",
            name = "Material error_outline",
            icon_info = "error_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_euro_symbol = new app_icon()
        {
            id = "material_euro_symbol",
            name = "Material euro_symbol",
            icon_info = "euro_symbol",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_event = new app_icon()
        {
            id = "material_event",
            name = "Material event",
            icon_info = "event",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_event_available = new app_icon()
        {
            id = "material_event_available",
            name = "Material event_available",
            icon_info = "event_available",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_event_busy = new app_icon()
        {
            id = "material_event_busy",
            name = "Material event_busy",
            icon_info = "event_busy",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_event_note = new app_icon()
        {
            id = "material_event_note",
            name = "Material event_note",
            icon_info = "event_note",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_event_seat = new app_icon()
        {
            id = "material_event_seat",
            name = "Material event_seat",
            icon_info = "event_seat",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_exit_to_app = new app_icon()
        {
            id = "material_exit_to_app",
            name = "Material exit_to_app",
            icon_info = "exit_to_app",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_expand_less = new app_icon()
        {
            id = "material_expand_less",
            name = "Material expand_less",
            icon_info = "expand_less",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_expand_more = new app_icon()
        {
            id = "material_expand_more",
            name = "Material expand_more",
            icon_info = "expand_more",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_exposure = new app_icon()
        {
            id = "material_exposure",
            name = "Material exposure",
            icon_info = "exposure",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_extension = new app_icon()
        {
            id = "material_extension",
            name = "Material extension",
            icon_info = "extension",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_face = new app_icon()
        {
            id = "material_face",
            name = "Material face",
            icon_info = "face",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_favorite = new app_icon()
        {
            id = "material_favorite",
            name = "Material favorite",
            icon_info = "favorite",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_favorite_border = new app_icon()
        {
            id = "material_favorite_border",
            name = "Material favorite_border",
            icon_info = "favorite_border",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_file_download = new app_icon()
        {
            id = "material_file_download",
            name = "Material file_download",
            icon_info = "file_download",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_file_upload = new app_icon()
        {
            id = "material_file_upload",
            name = "Material file_upload",
            icon_info = "file_upload",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_filter_center_focus = new app_icon()
        {
            id = "material_filter_center_focus",
            name = "Material filter_center_focus",
            icon_info = "filter_center_focus",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_find_in_page = new app_icon()
        {
            id = "material_find_in_page",
            name = "Material find_in_page",
            icon_info = "find_in_page",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_find_replace = new app_icon()
        {
            id = "material_find_replace",
            name = "Material find_replace",
            icon_info = "find_replace",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_fingerprint = new app_icon()
        {
            id = "material_fingerprint",
            name = "Material fingerprint",
            icon_info = "fingerprint",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_flag = new app_icon()
        {
            id = "material_flag",
            name = "Material flag",
            icon_info = "flag",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_flight = new app_icon()
        {
            id = "material_flight",
            name = "Material flight",
            icon_info = "flight",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_flight_land = new app_icon()
        {
            id = "material_flight_land",
            name = "Material flight_land",
            icon_info = "flight_land",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_flight_takeoff = new app_icon()
        {
            id = "material_flight_takeoff",
            name = "Material flight_takeoff",
            icon_info = "flight_takeoff",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_folder = new app_icon()
        {
            id = "material_folder",
            name = "Material folder",
            icon_info = "folder",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_folder_open = new app_icon()
        {
            id = "material_folder_open",
            name = "Material folder_open",
            icon_info = "folder_open",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_folder_shared = new app_icon()
        {
            id = "material_folder_shared",
            name = "Material folder_shared",
            icon_info = "folder_shared",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_folder_special = new app_icon()
        {
            id = "material_folder_special",
            name = "Material folder_special",
            icon_info = "folder_special",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_forward = new app_icon()
        {
            id = "material_forward",
            name = "Material forward",
            icon_info = "forward",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_free_breakfast = new app_icon()
        {
            id = "material_free_breakfast",
            name = "Material free_breakfast",
            icon_info = "free_breakfast",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_fullscreen = new app_icon()
        {
            id = "material_fullscreen",
            name = "Material fullscreen",
            icon_info = "fullscreen",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_fullscreen_exit = new app_icon()
        {
            id = "material_fullscreen_exit",
            name = "Material fullscreen_exit",
            icon_info = "fullscreen_exit",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_functions = new app_icon()
        {
            id = "material_functions",
            name = "Material functions",
            icon_info = "functions",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_g_translate = new app_icon()
        {
            id = "material_g_translate",
            name = "Material g_translate",
            icon_info = "g_translate",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_get_app = new app_icon()
        {
            id = "material_get_app",
            name = "Material get_app",
            icon_info = "get_app",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_gif = new app_icon()
        {
            id = "material_gif",
            name = "Material gif",
            icon_info = "gif",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_gps_fixed = new app_icon()
        {
            id = "material_gps_fixed",
            name = "Material gps_fixed",
            icon_info = "gps_fixed",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_gps_not_fixed = new app_icon()
        {
            id = "material_gps_not_fixed",
            name = "Material gps_not_fixed",
            icon_info = "gps_not_fixed",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_gps_off = new app_icon()
        {
            id = "material_gps_off",
            name = "Material gps_off",
            icon_info = "gps_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_grade = new app_icon()
        {
            id = "material_grade",
            name = "Material grade",
            icon_info = "grade",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_grain = new app_icon()
        {
            id = "material_grain",
            name = "Material grain",
            icon_info = "grain",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_group = new app_icon()
        {
            id = "material_group",
            name = "Material group",
            icon_info = "group",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_group_add = new app_icon()
        {
            id = "material_group_add",
            name = "Material group_add",
            icon_info = "group_add",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_group_work = new app_icon()
        {
            id = "material_group_work",
            name = "Material group_work",
            icon_info = "group_work",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_hd = new app_icon()
        {
            id = "material_hd",
            name = "Material hd",
            icon_info = "hd",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_headset = new app_icon()
        {
            id = "material_headset",
            name = "Material headset",
            icon_info = "headset",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_hearing = new app_icon()
        {
            id = "material_hearing",
            name = "Material hearing",
            icon_info = "hearing",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_help = new app_icon()
        {
            id = "material_help",
            name = "Material help",
            icon_info = "help",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_help_outline = new app_icon()
        {
            id = "material_help_outline",
            name = "Material help_outline",
            icon_info = "help_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_highlight_off = new app_icon()
        {
            id = "material_highlight_off",
            name = "Material highlight_off",
            icon_info = "highlight_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_history = new app_icon()
        {
            id = "material_history",
            name = "Material history",
            icon_info = "history",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_home = new app_icon()
        {
            id = "material_home",
            name = "Material home",
            icon_info = "home",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_hotel = new app_icon()
        {
            id = "material_hotel",
            name = "Material hotel",
            icon_info = "hotel",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_hourglass_empty = new app_icon()
        {
            id = "material_hourglass_empty",
            name = "Material hourglass_empty",
            icon_info = "hourglass_empty",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_hourglass_full = new app_icon()
        {
            id = "material_hourglass_full",
            name = "Material hourglass_full",
            icon_info = "hourglass_full",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_http = new app_icon()
        {
            id = "material_http",
            name = "Material http",
            icon_info = "http",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_https = new app_icon()
        {
            id = "material_https",
            name = "Material https",
            icon_info = "https",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_image = new app_icon()
        {
            id = "material_image",
            name = "Material image",
            icon_info = "image",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_import_export = new app_icon()
        {
            id = "material_import_export",
            name = "Material import_export",
            icon_info = "import_export",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_info = new app_icon()
        {
            id = "material_info",
            name = "Material info",
            icon_info = "info",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_info_outline = new app_icon()
        {
            id = "material_info_outline",
            name = "Material info_outline",
            icon_info = "info_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_input = new app_icon()
        {
            id = "material_input",
            name = "Material input",
            icon_info = "input",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_insert_comment = new app_icon()
        {
            id = "material_insert_comment",
            name = "Material insert_comment",
            icon_info = "insert_comment",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_insert_drive_file = new app_icon()
        {
            id = "material_insert_drive_file",
            name = "Material insert_drive_file",
            icon_info = "insert_drive_file",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_insert_emoticon = new app_icon()
        {
            id = "material_insert_emoticon",
            name = "Material insert_emoticon",
            icon_info = "insert_emoticon",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_insert_invitation = new app_icon()
        {
            id = "material_insert_invitation",
            name = "Material insert_invitation",
            icon_info = "insert_invitation",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_insert_link = new app_icon()
        {
            id = "material_insert_link",
            name = "Material insert_link",
            icon_info = "insert_link",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_insert_photo = new app_icon()
        {
            id = "material_insert_photo",
            name = "Material insert_photo",
            icon_info = "insert_photo",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_invert_colors = new app_icon()
        {
            id = "material_invert_colors",
            name = "Material invert_colors",
            icon_info = "invert_colors",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard = new app_icon()
        {
            id = "material_keyboard",
            name = "Material keyboard",
            icon_info = "keyboard",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_arrow_down = new app_icon()
        {
            id = "material_keyboard_arrow_down",
            name = "Material keyboard_arrow_down",
            icon_info = "keyboard_arrow_down",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_arrow_left = new app_icon()
        {
            id = "material_keyboard_arrow_left",
            name = "Material keyboard_arrow_left",
            icon_info = "keyboard_arrow_left",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_arrow_right = new app_icon()
        {
            id = "material_keyboard_arrow_right",
            name = "Material keyboard_arrow_right",
            icon_info = "keyboard_arrow_right",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_arrow_up = new app_icon()
        {
            id = "material_keyboard_arrow_up",
            name = "Material keyboard_arrow_up",
            icon_info = "keyboard_arrow_up",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_backspace = new app_icon()
        {
            id = "material_keyboard_backspace",
            name = "Material keyboard_backspace",
            icon_info = "keyboard_backspace",
            icon_type_id = app_icon_type.material_icons.id
        };


        public static app_icon material_keyboard_capslock = new app_icon()
        {
            id = "material_keyboard_capslock",
            name = "Material keyboard_capslock",
            icon_info = "keyboard_capslock",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_hide = new app_icon()
        {
            id = "material_keyboard_hide",
            name = "Material keyboard_hide",
            icon_info = "keyboard_hide",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_return = new app_icon()
        {
            id = "material_keyboard_return",
            name = "Material keyboard_return",
            icon_info = "keyboard_return",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_keyboard_voice = new app_icon()
        {
            id = "material_keyboard_voice",
            name = "Material keyboard_voice",
            icon_info = "keyboard_voice",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_label = new app_icon()
        {
            id = "material_label",
            name = "Material label",
            icon_info = "label",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_label_outline = new app_icon()
        {
            id = "material_label_outline",
            name = "Material label_outline",
            icon_info = "label_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_language = new app_icon()
        {
            id = "material_language",
            name = "Material language",
            icon_info = "language",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_laptop = new app_icon()
        {
            id = "material_laptop",
            name = "Material laptop",
            icon_info = "laptop",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_laptop_chromebook = new app_icon()
        {
            id = "material_laptop_chromebook",
            name = "Material laptop_chromebook",
            icon_info = "laptop_chromebook",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_laptop_mac = new app_icon()
        {
            id = "material_laptop_mac",
            name = "Material laptop_mac",
            icon_info = "laptop_mac",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_laptop_windows = new app_icon()
        {
            id = "material_laptop_windows",
            name = "Material laptop_windows",
            icon_info = "laptop_windows",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_launch = new app_icon()
        {
            id = "material_launch",
            name = "Material launch",
            icon_info = "launch",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_layers = new app_icon()
        {
            id = "material_layers",
            name = "Material layers",
            icon_info = "layers",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_layers_clear = new app_icon()
        {
            id = "material_layers_clear",
            name = "Material layers_clear",
            icon_info = "layers_clear",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_lightbulb_outline = new app_icon()
        {
            id = "material_lightbulb_outline",
            name = "Material lightbulb_outline",
            icon_info = "lightbulb_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_linear_scale = new app_icon()
        {
            id = "material_linear_scale",
            name = "Material linear_scale",
            icon_info = "linear_scale",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_link = new app_icon()
        {
            id = "material_link",
            name = "Material link",
            icon_info = "link",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_linked_camera = new app_icon()
        {
            id = "material_linked_camera",
            name = "Material linked_camera",
            icon_info = "linked_camera",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_library_music = new app_icon()
        {
            id = "material_library_music",
            name = "Material library_music",
            icon_info = "library_music",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_live_help = new app_icon()
        {
            id = "material_live_help",
            name = "Material live_help",
            icon_info = "live_help",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_live_tv = new app_icon()
        {
            id = "material_live_tv",
            name = "Material live_tv",
            icon_info = "live_tv",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_local_airport = new app_icon()
        {
            id = "material_local_airport",
            name = "Material local_airport",
            icon_info = "local_airport",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_atm = new app_icon()
        {
            id = "material_local_atm",
            name = "Material local_atm",
            icon_info = "local_atm",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_bar = new app_icon()
        {
            id = "material_local_bar",
            name = "Material local_bar",
            icon_info = "local_bar",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_cafe = new app_icon()
        {
            id = "material_local_cafe",
            name = "Material local_cafe",
            icon_info = "local_cafe",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_car_wash = new app_icon()
        {
            id = "material_local_car_wash",
            name = "Material local_car_wash",
            icon_info = "local_car_wash",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_dining = new app_icon()
        {
            id = "material_local_dining",
            name = "Material local_dining",
            icon_info = "local_dining",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_drink = new app_icon()
        {
            id = "material_local_drink",
            name = "Material local_drink",
            icon_info = "local_drink",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_florist = new app_icon()
        {
            id = "material_local_florist",
            name = "Material local_florist",
            icon_info = "local_florist",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_gas_station = new app_icon()
        {
            id = "material_local_gas_station",
            name = "Material local_gas_station",
            icon_info = "local_gas_station",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_grocery_store = new app_icon()
        {
            id = "material_local_grocery_store",
            name = "Material local_grocery_store",
            icon_info = "local_grocery_store",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_hospital = new app_icon()
        {
            id = "material_local_hospital",
            name = "Material local_hospital",
            icon_info = "local_hospital",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_hotel = new app_icon()
        {
            id = "material_local_hotel",
            name = "Material local_hotel",
            icon_info = "local_hotel",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_loundry_service = new app_icon()
        {
            id = "material_local_loundry_service",
            name = "Material local_loundry_service",
            icon_info = "local_loundry_service",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_library = new app_icon()
        {
            id = "material_local_library",
            name = "Material local_library",
            icon_info = "local_library",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_mall = new app_icon()
        {
            id = "material_local_mall",
            name = "Material local_mall",
            icon_info = "local_mall",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_movies = new app_icon()
        {
            id = "material_local_movies",
            name = "Material local_movies",
            icon_info = "local_movies",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_offer = new app_icon()
        {
            id = "material_local_offer",
            name = "Material local_offer",
            icon_info = "local_offer",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_parking = new app_icon()
        {
            id = "material_local_parking",
            name = "Material local_parking",
            icon_info = "local_parking",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_pharmacy = new app_icon()
        {
            id = "material_local_pharmacy",
            name = "Material local_pharmacy",
            icon_info = "local_pharmacy",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_phone = new app_icon()
        {
            id = "material_local_phone",
            name = "Material local_phone",
            icon_info = "local_phone",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_pizza = new app_icon()
        {
            id = "material_local_pizza",
            name = "Material local_pizza",
            icon_info = "local_pizza",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_post_office = new app_icon()
        {
            id = "material_local_post_office",
            name = "Material local_post_office",
            icon_info = "local_post_office",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_printshop = new app_icon()
        {
            id = "material_local_printshop",
            name = "Material local_printshop",
            icon_info = "local_printshop",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_see = new app_icon()
        {
            id = "material_local_see",
            name = "Material local_see",
            icon_info = "local_see",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_shipping = new app_icon()
        {
            id = "material_local_shipping",
            name = "Material local_shipping",
            icon_info = "local_shipping",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_local_taxi = new app_icon()
        {
            id = "material_local_taxi",
            name = "Material local_taxi",
            icon_info = "local_taxi",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_localtion_city = new app_icon()
        {
            id = "material_localtion_city",
            name = "Material localtion_city",
            icon_info = "localtion_city",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_location_disabled = new app_icon()
        {
            id = "material_location_disabled",
            name = "Material location_disabled",
            icon_info = "location_disabled",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_location_off = new app_icon()
        {
            id = "material_location_off",
            name = "Material location_off",
            icon_info = "location_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_location_on = new app_icon()
        {
            id = "material_location_on",
            name = "Material location_on",
            icon_info = "location_on",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_location_searching = new app_icon()
        {
            id = "material_location_searching",
            name = "Material location_searching",
            icon_info = "location_searching",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_lock = new app_icon()
        {
            id = "material_lock",
            name = "Material lock",
            icon_info = "lock",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_lock_open = new app_icon()
        {
            id = "material_lock_open",
            name = "Material lock_open",
            icon_info = "lock_open",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_lock_outline = new app_icon()
        {
            id = "material_lock_outline",
            name = "Material lock_outline",
            icon_info = "lock_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_looks = new app_icon()
        {
            id = "material_looks",
            name = "Material looks",
            icon_info = "looks",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_loop = new app_icon()
        {
            id = "material_loop",
            name = "Material loop",
            icon_info = "loop",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_loupe = new app_icon()
        {
            id = "material_loupe",
            name = "Material loupe",
            icon_info = "loupe",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mail = new app_icon()
        {
            id = "material_mail",
            name = "Material mail",
            icon_info = "mail",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mail_outline = new app_icon()
        {
            id = "material_mail_outline",
            name = "Material mail_outline",
            icon_info = "mail_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_map = new app_icon()
        {
            id = "material_map",
            name = "Material map",
            icon_info = "map",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mark_unread = new app_icon()
        {
            id = "material_mark_unread",
            name = "Material mark_unread",
            icon_info = "mark_unread",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_memory = new app_icon()
        {
            id = "material_memory",
            name = "Material memory",
            icon_info = "memory",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mic = new app_icon()
        {
            id = "material_mic",
            name = "Material mic",
            icon_info = "mic",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mic_none = new app_icon()
        {
            id = "material_mic_none",
            name = "Material mic_none",
            icon_info = "mic_none",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mic_off = new app_icon()
        {
            id = "material_mic_off",
            name = "Material mic_off",
            icon_info = "mic_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mode_edit = new app_icon()
        {
            id = "material_mode_edit",
            name = "Material mode_edit",
            icon_info = "mode_edit",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_monetization_on = new app_icon()
        {
            id = "material_monetization_on",
            name = "Material monetization_on",
            icon_info = "monetization_on",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_money_off = new app_icon()
        {
            id = "material_money_off",
            name = "Material money_off",
            icon_info = "money_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mood = new app_icon()
        {
            id = "material_mood",
            name = "Material mood",
            icon_info = "mood",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mood_bad = new app_icon()
        {
            id = "material_mood_bad",
            name = "Material mood_bad",
            icon_info = "mood_bad",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_more_horiz = new app_icon()
        {
            id = "material_more_horiz",
            name = "Material more_horiz",
            icon_info = "more_horiz",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_more_vert = new app_icon()
        {
            id = "material_more_vert",
            name = "Material more_vert",
            icon_info = "more_vert",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_motorcycle = new app_icon()
        {
            id = "material_motorcycle",
            name = "Material motorcycle",
            icon_info = "motorcycle",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_mouse = new app_icon()
        {
            id = "material_mouse",
            name = "Material mouse",
            icon_info = "mouse",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_music_note = new app_icon()
        {
            id = "material_music_note",
            name = "Material music_note",
            icon_info = "music_note",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_my_location = new app_icon()
        {
            id = "material_my_location",
            name = "Material my_location",
            icon_info = "my_location",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_navigate_before = new app_icon()
        {
            id = "material_navigate_before",
            name = "Material navigate_before",
            icon_info = "navigate_before",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_navigate_next = new app_icon()
        {
            id = "material_navigate_next",
            name = "Material navigate_next",
            icon_info = "navigate_next",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_navigation = new app_icon()
        {
            id = "material_navigation",
            name = "Material navigation",
            icon_info = "navigation",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_near_me = new app_icon()
        {
            id = "material_near_me",
            name = "Material near_me",
            icon_info = "near_me",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_network_check = new app_icon()
        {
            id = "material_network_check",
            name = "Material network_check",
            icon_info = "network_check",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_network_wifi = new app_icon()
        {
            id = "material_network_wifi",
            name = "Material network_wifi",
            icon_info = "network_wifi",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_nfc = new app_icon()
        {
            id = "material_nfc",
            name = "Material nfc",
            icon_info = "nfc",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_no_encryption = new app_icon()
        {
            id = "material_no_encryption",
            name = "Material no_encryption",
            icon_info = "no_encryption",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_no_sim = new app_icon()
        {
            id = "material_no_sim",
            name = "Material no_sim",
            icon_info = "no_sim",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_not_interested = new app_icon()
        {
            id = "material_not_interested",
            name = "Material not_interested",
            icon_info = "not_interested",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_note = new app_icon()
        {
            id = "material_note",
            name = "Material note",
            icon_info = "note",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_note_add = new app_icon()
        {
            id = "material_note_add",
            name = "Material note_add",
            icon_info = "note_add",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_notifications = new app_icon()
        {
            id = "material_notifications",
            name = "Material notifications",
            icon_info = "notifications",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_notifications_active = new app_icon()
        {
            id = "material_notifications_active",
            name = "Material notifications_active",
            icon_info = "notifications_active",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_notifications_none = new app_icon()
        {
            id = "material_notifications_none",
            name = "Material notifications_none",
            icon_info = "notifications_none",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_notifications_off = new app_icon()
        {
            id = "material_notifications_off",
            name = "Material notifications_off",
            icon_info = "notifications_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_notifications_paused = new app_icon()
        {
            id = "material_notifications_paused",
            name = "Material notifications_paused",
            icon_info = "notifications_paused",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_offline_pin = new app_icon()
        {
            id = "material_offline_pin",
            name = "Material offline_pin",
            icon_info = "offline_pin",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_open_in_browser = new app_icon()
        {
            id = "material_open_in_browser",
            name = "Material open_in_browser",
            icon_info = "open_in_browser",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_open_in_new = new app_icon()
        {
            id = "material_open_in_new",
            name = "Material open_in_new",
            icon_info = "open_in_new",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_open_with = new app_icon()
        {
            id = "material_open_with",
            name = "Material open_with",
            icon_info = "open_with",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pageview = new app_icon()
        {
            id = "material_pageview",
            name = "Material pageview",
            icon_info = "pageview",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_palette = new app_icon()
        {
            id = "material_palette",
            name = "Material palette",
            icon_info = "palette",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pan_tool = new app_icon()
        {
            id = "material_pan_tool",
            name = "Material pan_tool",
            icon_info = "pan_tool",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_panorama = new app_icon()
        {
            id = "material_panorama",
            name = "Material panorama",
            icon_info = "panorama",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pause = new app_icon()
        {
            id = "material_pause",
            name = "Material pause",
            icon_info = "pause",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pause_circle_filled = new app_icon()
        {
            id = "material_pause_circle_filled",
            name = "Material pause_circle_filled",
            icon_info = "pause_circle_filled",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pause_circle_outline = new app_icon()
        {
            id = "material_pause_circle_outline",
            name = "Material pause_circle_outline",
            icon_info = "pause_circle_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_payment = new app_icon()
        {
            id = "material_payment",
            name = "Material payment",
            icon_info = "payment",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_people = new app_icon()
        {
            id = "material_people",
            name = "Material people",
            icon_info = "people",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_people_outline = new app_icon()
        {
            id = "material_people_outline",
            name = "Material people_outline",
            icon_info = "people_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_perm_identity = new app_icon()
        {
            id = "material_perm_identity",
            name = "Material perm_identity",
            icon_info = "perm_identity",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_person = new app_icon()
        {
            id = "material_person",
            name = "Material person",
            icon_info = "person",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_person_add = new app_icon()
        {
            id = "material_person_add",
            name = "Material person_add",
            icon_info = "person_add",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_person_outline = new app_icon()
        {
            id = "material_person_outline",
            name = "Material person_outline",
            icon_info = "person_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_person_pin = new app_icon()
        {
            id = "material_person_pin",
            name = "Material person_pin",
            icon_info = "person_pin",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_person_pin_circle = new app_icon()
        {
            id = "material_person_pin_circle",
            name = "Material person_pin_circle",
            icon_info = "person_pin_circle",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pets = new app_icon()
        {
            id = "material_pets",
            name = "Material pets",
            icon_info = "pets",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_phone = new app_icon()
        {
            id = "material_phone",
            name = "Material phone",
            icon_info = "phone",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_phone_android = new app_icon()
        {
            id = "material_phone_android",
            name = "Material phone_android",
            icon_info = "phone_android",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_phone_in_talk = new app_icon()
        {
            id = "material_phone_in_talk",
            name = "Material phone_in_talk",
            icon_info = "phone_in_talk",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_phone_iphone = new app_icon()
        {
            id = "material_phone_iphone",
            name = "Material phone_iphone",
            icon_info = "phone_iphone",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_photo = new app_icon()
        {
            id = "material_photo",
            name = "Material photo",
            icon_info = "photo",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_photo_album = new app_icon()
        {
            id = "material_photo_album",
            name = "Material photo_album",
            icon_info = "photo_album",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_photo_camera = new app_icon()
        {
            id = "material_photo_camera",
            name = "Material photo_camera",
            icon_info = "photo_camera",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pie_chart = new app_icon()
        {
            id = "material_pie_chart",
            name = "Material pie_chart",
            icon_info = "pie_chart",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pie_chart_outlined = new app_icon()
        {
            id = "material_pie_chart_outlined",
            name = "Material pie_chart_outlined",
            icon_info = "pie_chart_outlined",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_pin_drop = new app_icon()
        {
            id = "material_pin_drop",
            name = "Material pin_drop",
            icon_info = "pin_drop",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_place = new app_icon()
        {
            id = "material_place",
            name = "Material place",
            icon_info = "place",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_play_arrow = new app_icon()
        {
            id = "material_play_arrow",
            name = "Material play_arrow",
            icon_info = "play_arrow",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_play_circle_filled = new app_icon()
        {
            id = "material_play_circle_filled",
            name = "Material play_circle_filled",
            icon_info = "play_circle_filled",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_play_circle_outline = new app_icon()
        {
            id = "material_play_circle_outline",
            name = "Material play_circle_outline",
            icon_info = "play_circle_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_playlist_add = new app_icon()
        {
            id = "material_playlist_add",
            name = "Material playlist_add",
            icon_info = "playlist_add",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_playlist_add_check = new app_icon()
        {
            id = "material_playlist_add_check",
            name = "Material playlist_add_check",
            icon_info = "playlist_add_check",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_playlist_play = new app_icon()
        {
            id = "material_playlist_play",
            name = "Material playlist_play",
            icon_info = "playlist_play",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_plus_one = new app_icon()
        {
            id = "material_plus_one",
            name = "Material plus_one",
            icon_info = "plus_one",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_poll = new app_icon()
        {
            id = "material_poll",
            name = "Material poll",
            icon_info = "poll",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_pool = new app_icon()
        {
            id = "material_pool",
            name = "Material pool",
            icon_info = "pool",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_power = new app_icon()
        {
            id = "material_power",
            name = "Material power",
            icon_info = "power",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_power_settings_new = new app_icon()
        {
            id = "material_power_settings_new",
            name = "Material power_settings_new",
            icon_info = "power_settings_new",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_print = new app_icon()
        {
            id = "material_print",
            name = "Material print",
            icon_info = "print",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_priority_hight = new app_icon()
        {
            id = "material_priority_hight",
            name = "Material priority_hight",
            icon_info = "priority_hight",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_public = new app_icon()
        {
            id = "material_public",
            name = "Material public",
            icon_info = "public",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_publish = new app_icon()
        {
            id = "material_publish",
            name = "Material publish",
            icon_info = "publish",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_radio_button_checked = new app_icon()
        {
            id = "material_radio_button_checked",
            name = "Material radio_button_checked",
            icon_info = "radio_button_checked",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_radio_button_unchecked = new app_icon()
        {
            id = "material_radio_button_unchecked",
            name = "Material radio_button_unchecked",
            icon_info = "radio_button_unchecked",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_refresh = new app_icon()
        {
            id = "material_refresh",
            name = "Material refresh",
            icon_info = "refresh",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_remove = new app_icon()
        {
            id = "material_remove",
            name = "Material remove",
            icon_info = "remove",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_remove__circle = new app_icon()
        {
            id = "material_remove_circle",
            name = "Material remove_circle",
            icon_info = "remove_circle",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_remove__circle_outline = new app_icon()
        {
            id = "material_remove_circle_outline",
            name = "Material remove_circle_outline",
            icon_info = "remove_circle_outline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_remove_red_eye = new app_icon()
        {
            id = "material_remove_red_eye",
            name = "Material remove_red_eye",
            icon_info = "remove_red_eye",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_remove_shopping_cart = new app_icon()
        {
            id = "material_remove_shopping_cart",
            name = "Material remove_shopping_cart",
            icon_info = "remove_shopping_cart",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_repeat = new app_icon()
        {
            id = "material_repeat",
            name = "Material repeat",
            icon_info = "repeat",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_repeat_one = new app_icon()
        {
            id = "material_repeat_one",
            name = "Material repeat_one",
            icon_info = "repeat_one",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_replay = new app_icon()
        {
            id = "material_replay",
            name = "Material replay",
            icon_info = "replay",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_reply = new app_icon()
        {
            id = "material_reply",
            name = "Material reply",
            icon_info = "reply",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_reply_all = new app_icon()
        {
            id = "material_reply_all",
            name = "Material reply_all",
            icon_info = "reply_all",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_report = new app_icon()
        {
            id = "material_report",
            name = "Material report",
            icon_info = "report",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_report_problem = new app_icon()
        {
            id = "material_report_problem",
            name = "Material report_problem",
            icon_info = "report_problem",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_restaurant_menu = new app_icon()
        {
            id = "material_restaurant_menu",
            name = "Material restaurant_menu",
            icon_info = "restaurant_menu",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_restore = new app_icon()
        {
            id = "material_restore",
            name = "Material restore",
            icon_info = "restore",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_restore_page = new app_icon()
        {
            id = "material_restore_page",
            name = "Material restore_page",
            icon_info = "restore_page",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_router = new app_icon()
        {
            id = "material_router",
            name = "Material router",
            icon_info = "router",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_rss_feed = new app_icon()
        {
            id = "material_rss_feed",
            name = "Material rss_feed",
            icon_info = "rss_feed",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_save = new app_icon()
        {
            id = "material_save",
            name = "Material save",
            icon_info = "save",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_schedule = new app_icon()
        {
            id = "material_schedule",
            name = "Material schedule",
            icon_info = "schedule",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_school = new app_icon()
        {
            id = "material_school",
            name = "Material school",
            icon_info = "school",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_scren_rotation = new app_icon()
        {
            id = "material_scren_rotation",
            name = "Material scren_rotation",
            icon_info = "scren_rotation",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_search = new app_icon()
        {
            id = "material_search",
            name = "Material search",
            icon_info = "search",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_security = new app_icon()
        {
            id = "material_security",
            name = "Material security",
            icon_info = "security",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sentiment_dissatisfied = new app_icon()
        {
            id = "material_sentiment_dissatisfied",
            name = "Material sentiment_dissatisfied",
            icon_info = "sentiment_dissatisfied",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sentiment_neutral = new app_icon()
        {
            id = "material_sentiment_neutral",
            name = "Material sentiment_neutral",
            icon_info = "sentiment_neutral",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sentiment_satisfied = new app_icon()
        {
            id = "material_sentiment_satisfied",
            name = "Material sentiment_satisfied",
            icon_info = "sentiment_satisfied",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sentiment_very_dissatisfied = new app_icon()
        {
            id = "material_sentiment_very_dissatisfied",
            name = "Material sentiment_very_dissatisfied",
            icon_info = "sentiment_very_dissatisfied",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_settings = new app_icon()
        {
            id = "material_settings",
            name = "Material settings",
            icon_info = "settings",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_settings_applications = new app_icon()
        {
            id = "material_settings_applications",
            name = "Material settings_applications",
            icon_info = "settings_applications",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_settings_backup_restore = new app_icon()
        {
            id = "material_settings_backup_restore",
            name = "Material settings_backup_restore",
            icon_info = "settings_backup_restore",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_settings_bluetooth = new app_icon()
        {
            id = "material_settings_bluetooth",
            name = "Material settings_bluetooth",
            icon_info = "settings_bluetooth",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_settings_input_antenna = new app_icon()
        {
            id = "material_settings_input_antenna",
            name = "Material settings_input_antenna",
            icon_info = "settings_input_antenna",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_settings_input_component = new app_icon()
        {
            id = "material_settings_input_component",
            name = "Material settings_input_component",
            icon_info = "settings_input_component",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_share = new app_icon()
        {
            id = "material_share",
            name = "Material share",
            icon_info = "share",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_shopping_basket = new app_icon()
        {
            id = "material_shopping_basket",
            name = "Material shopping_basket",
            icon_info = "shopping_basket",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_shopping_cart = new app_icon()
        {
            id = "material_shopping_cart",
            name = "Material shopping_cart",
            icon_info = "shopping_cart",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_show_chart = new app_icon()
        {
            id = "material_show_chart",
            name = "Material show_chart",
            icon_info = "show_chart",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_shuffle = new app_icon()
        {
            id = "material_shuffle",
            name = "Material shuffle",
            icon_info = "shuffle",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sms = new app_icon()
        {
            id = "material_sms",
            name = "Material sms",
            icon_info = "sms",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_sms_failed = new app_icon()
        {
            id = "material_sms_failed",
            name = "Material sms_failed",
            icon_info = "sms_failed",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_star = new app_icon()
        {
            id = "material_star",
            name = "Material star",
            icon_info = "star",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_star_border = new app_icon()
        {
            id = "material_star_border",
            name = "Material star_border",
            icon_info = "star_border",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_star_half = new app_icon()
        {
            id = "material_star_half",
            name = "Material star_half",
            icon_info = "star_half",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_stars = new app_icon()
        {
            id = "material_stars",
            name = "Material stars",
            icon_info = "stars",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_storage = new app_icon()
        {
            id = "material_storage",
            name = "Material storage",
            icon_info = "storage",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_store = new app_icon()
        {
            id = "material_store",
            name = "Material store",
            icon_info = "store",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_supervisor_account = new app_icon()
        {
            id = "material_supervisor_account",
            name = "Material supervisor_account",
            icon_info = "supervisor_account",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_swap_horiz = new app_icon()
        {
            id = "material_swap_horiz",
            name = "Material swap_horiz",
            icon_info = "swap_horiz",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_swap_vert = new app_icon()
        {
            id = "material_swap_vert",
            name = "Material swap_vert",
            icon_info = "swap_vert",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sync = new app_icon()
        {
            id = "material_sync",
            name = "Material sync",
            icon_info = "sync",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sync_disabled = new app_icon()
        {
            id = "material_sync_disabled",
            name = "Material sync_disabled",
            icon_info = "sync_disabled",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_sync_problem = new app_icon()
        {
            id = "material_sync_problem",
            name = "Material sync_problem",
            icon_info = "sync_problem",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_tab = new app_icon()
        {
            id = "material_tab",
            name = "Material tab",
            icon_info = "tab",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_thumb_down = new app_icon()
        {
            id = "material_thumb_down",
            name = "Material thumb_down",
            icon_info = "thumb_down",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_thumb_up = new app_icon()
        {
            id = "material_thumb_up",
            name = "Material thumb_up",
            icon_info = "thumb_up",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_timeline = new app_icon()
        {
            id = "material_timeline",
            name = "Material timeline",
            icon_info = "timeline",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_timer = new app_icon()
        {
            id = "material_timer",
            name = "Material timer",
            icon_info = "timer",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_train = new app_icon()
        {
            id = "material_train",
            name = "Material train",
            icon_info = "train",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_tram = new app_icon()
        {
            id = "material_tram",
            name = "Material tram",
            icon_info = "tram",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_transform = new app_icon()
        {
            id = "material_transform",
            name = "Material transform",
            icon_info = "transform",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_trending_down = new app_icon()
        {
            id = "material_trending_down",
            name = "Material trending_down",
            icon_info = "trending_down",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_trending_flat = new app_icon()
        {
            id = "material_trending_flat",
            name = "Material trending_flat",
            icon_info = "trending_flat",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_trending_up = new app_icon()
        {
            id = "material_trending_up",
            name = "Material trending_up",
            icon_info = "trending_up",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_unfold_less = new app_icon()
        {
            id = "material_unfold_less",
            name = "Material unfold_less",
            icon_info = "unfold_less",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_unfold_more = new app_icon()
        {
            id = "material_unfold_more",
            name = "Material unfold_more",
            icon_info = "unfold_more",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_update = new app_icon()
        {
            id = "material_update",
            name = "Material update",
            icon_info = "update",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_verified_user = new app_icon()
        {
            id = "material_verified_user",
            name = "Material verified_user",
            icon_info = "verified_user",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_visibility = new app_icon()
        {
            id = "material_visibility",
            name = "Material visibility",
            icon_info = "visibility",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_visibility_off = new app_icon()
        {
            id = "material_visibility_off",
            name = "Material visibility_off",
            icon_info = "visibility_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_volume_down = new app_icon()
        {
            id = "material_volume_down",
            name = "Material volume_down",
            icon_info = "volume_down",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_volume_mute = new app_icon()
        {
            id = "material_volume_mute",
            name = "Material volume_mute",
            icon_info = "volume_mute",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_volume_up = new app_icon()
        {
            id = "material_volume_up",
            name = "Material volume_up",
            icon_info = "volume_up",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_volume_off = new app_icon()
        {
            id = "material_volume_off",
            name = "Material volume_off",
            icon_info = "volume_off",
            icon_type_id = app_icon_type.material_icons.id
        };
        public static app_icon material_vpn_key = new app_icon()
        {
            id = "material_vpn_key",
            name = "Material vpn_key",
            icon_info = "vpn_key",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_warning = new app_icon()
        {
            id = "material_warning",
            name = "Material warning",
            icon_info = "warning",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_wb_cloudy = new app_icon()
        {
            id = "material_wb_cloudy",
            name = "Material wb_cloudy",
            icon_info = "wb_cloudy",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_wb_sunny = new app_icon()
        {
            id = "material_wb_sunny",
            name = "Material wb_sunny",
            icon_info = "wb_sunny",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_widgets = new app_icon()
        {
            id = "material_widgets",
            name = "Material widgets",
            icon_info = "widgets",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_wifi = new app_icon()
        {
            id = "material_wifi",
            name = "Material wifi",
            icon_info = "wifi",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_wifi_lock = new app_icon()
        {
            id = "material_wifi_lock",
            name = "Material wifi_lock",
            icon_info = "wifi_lock",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_work = new app_icon()
        {
            id = "material_work",
            name = "Material work",
            icon_info = "work",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_zoom_in = new app_icon()
        {
            id = "material_zoom_in",
            name = "Material zoom_in",
            icon_info = "zoom_in",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_zoom_out = new app_icon()
        {
            id = "material_zoom_out",
            name = "Material zoom_out",
            icon_info = "zoom_out",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_zoom_out_map = new app_icon()
        {
            id = "material_zoom_out_map",
            name = "Material zoom_out_map",
            icon_info = "zoom_out_map",
            icon_type_id = app_icon_type.material_icons.id
        };

        public static app_icon material_watch_later = new app_icon()
        {
            id = "material_watch_later",
            name = "Material watch_later",
            icon_info = "watch_later",
            icon_type_id = app_icon_type.material_icons.id
        };

    }
}