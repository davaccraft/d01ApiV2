using System;
using System.Collections.Generic;
using System.Text;

namespace d01ApiV2.Model.Component
{
    public class DbReturnComponent
    {
        public short DisplayOrderNo { get; set; } //tinyint,

        public string InternalCode { get; set; }

        public string Caption { get; set; }

        public string Placeholder { get; set; }

        /// <summary>
        /// Data Type sample boolean, numeric, date/datetime, string, alphanumeric
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Format sample "MM/dd/yyyy", "#,##0.00", "SSSS-####-SSSSS" (S is for string, # is for numeric)
        /// </summary>
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
        public string ComponentType { get; set; } //ControlObject

        ///// <summary>
        ///// EventCode sample
        ///// Click, Hover, Keypress
        ///// </summary>
        //public string EventCode { get; set; } //FunctionCode

        /// <summary>
        /// MethodCode (method or function) sample ADDDATA, GETLISTDATA 
        /// </summary>
        public string MethodCode { get; set; }

        public int IsVisible { get; set; }

        public int IsReadOnly { get; set; }

        public int IsEnable { get; set; }
    }
}
