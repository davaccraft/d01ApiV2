using System.Globalization;
using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class Component
    {
        [JsonPropertyName("module_code")]
        public string ModuleCode { get; set; }

        [JsonPropertyName("sub_module_code")]
        public string SubModuleCode { get; set; }

        [JsonPropertyName("diplay_order_no")]
        public int DisplayOrderNo { get; set; }

        [JsonPropertyName("internal_code")]
        public string InternalCode { get; set; }

        [JsonPropertyName("info_id")]
        public string InfoId { get; set; }// UNIQUEIDENTIFIER || Guid 

        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; } // UNIQUEIDENTIFIER || Guid

        [JsonPropertyName("caption")]
        public string Caption { get; set; }

        [JsonPropertyName("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// Data Type sample boolean, numeric, date/datetime, string, alphanumeric
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// Format sample "MM/dd/yyyy", "#,##0.00", "SSSS-####-SSSSS" (S is for string, # is for numeric)
        /// </summary>
        [JsonPropertyName("data_format")]
        public string DataFormat { get; set; }

        /// <summary>
        /// ComponetType sample: 
        /// TEXTBOX/INPUTBOX, 
        /// DROPDOWN (single-select dropdown)
        /// DROPDOWN-MULTI (multiple-select dropdown)
        /// CHECKBOX
        /// RADIO (radio/option button)
        /// BUTTON
        /// LISTBOX (single-select listbox)
        /// LISTBOX-MULTI (multiple-select listbox)
        /// CHECKLISTBOX
        /// DATETIMEPICKER
        /// </summary>
        [JsonPropertyName("component_type")]
        public string ComponentType { get; set; } //ControlObject

        ///// <summary>
        ///// EventCode sample
        ///// Click, Hover, Keypress
        ///// </summary>
        //[JsonPropertyName("event_code")]
        //public string EventCode { get; set; } //FunctionCode

        /// <summary>
        /// MethodCode (method or function) sample ADDDATA, GETLISTDATA 
        /// </summary>
        [JsonPropertyName("method_code")]
        public string MethodCode { get; set; }

        [JsonPropertyName("min_len")]
        public int MinimumLength { get; set; }

        [JsonPropertyName("max_len")]
        public int MaximumLength { get; set; }

        [JsonPropertyName("is_active")]
        public int IsActive { get; set; }

        [JsonPropertyName("is_deleted")]
        public int IsDeleted { get; set; }

        [JsonPropertyName("is_visible")]
        public int IsVisible { get; set; }

        [JsonPropertyName("is_read_only")]
        public int IsReadOnly { get; set; }

        [JsonPropertyName("is_enable")]
        public int IsEnable { get; set; }

        [JsonPropertyName("is_required")]
        public int IsRequired { get; set; }

        //[JsonPropertyName("column_group_no")]
        //public int ColumnGroupNo { get; set; }
        
        //[JsonPropertyName("is_allow_sort")]
        //public int IsAllowSort { get; set; }

        //[JsonPropertyName("is_ascending")]
        //public int IsAscending { get; set; }
    }
}
