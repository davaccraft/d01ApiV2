using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ModuleComponent
    {
        [JsonPropertyName("module_order_no")]
        public int ModuleOrderNo { get; set; }
        [JsonPropertyName("module_code")]
        public string ModuleCode { get; set; }
        [JsonPropertyName("module_caption")]
        public string ModuleCaption { get; set; }
        [JsonPropertyName("module_icon")]
        public string ModuleIcon { get; set; }
        [JsonPropertyName("module_is_enabled")]
        public int ModuleIsEnabled { get; set; }
        [JsonPropertyName("module_is_read_only")]
        public int ModuleIsReadOnly { get; set; }

        [JsonPropertyName("detail_page_components")]
        public List<Component> DetailPageComponents { get; set; }

        [JsonPropertyName("list_page_components")]
        public List<Component> ListPageComponents { get; set; }

        [JsonPropertyName("advance_search_components")]
        public List<Component> AdvanceSearchComponents { get; set; }

        //[JsonPropertyName("grid_components")]
        //public List<ComponentGrid> GridComponents { get; set; }

        [JsonPropertyName("list_grid_components")]
        public List<GridGroupComponent> ListGridComponents { get; set; }

        [JsonPropertyName("detail_grid_components")]
        public List<GridGroupComponent> DetailGridComponents { get; set; }

    }
}
