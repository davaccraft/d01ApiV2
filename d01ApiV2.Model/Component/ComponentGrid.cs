using System.Globalization;
using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ComponentGrid : Component
    {
        [JsonPropertyName("column_group_no")]
        public int ColumnGroupNo { get; set; }
        
        [JsonPropertyName("is_allow_sort")]
        public int IsAllowSort { get; set; }

        [JsonPropertyName("is_ascending")]
        public int IsAscending { get; set; }

        [JsonPropertyName("grid_page")]
        public string GridPage { get; set; }

        [JsonPropertyName("grid_order_no")]
        public int GridOrderNo { get; set; }
    }
}
