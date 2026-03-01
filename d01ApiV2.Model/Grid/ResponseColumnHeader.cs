using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Grid
{
    public class ResponseColumnHeader
    {
        [JsonPropertyName("internal_code")]
        public string InternalCode { get; set; }
        [JsonPropertyName("column_group")]
        public string ColumnGroup { get; set; }
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        [JsonPropertyName("display_order_no")]
        public int DisplayOrderNo { get; set; }
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }
        [JsonPropertyName("data_format")]
        public string DataFormat { get; set; }
        [JsonPropertyName("component_type")]
        public string ComponentType { get; set; }
        [JsonPropertyName("method_code")]
        public string MethodCode { get; set; }
        [JsonPropertyName("is_vissible")]
        public bool IsVisible { get; set; }
        [JsonPropertyName("is_allow_sort")]
        public bool IsAllowSort { get; set; }
        [JsonPropertyName("is_ascending")]
        public bool IsAscending { get; set; }
    }
}
