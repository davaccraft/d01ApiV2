using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ResponseModule
    {
        [JsonPropertyName("module_code")]
        public string ModuleCode { get; set; }

        [JsonPropertyName("menu_components")]
        public List<ResponseComponent> MenuComponents { get; set; }

        [JsonPropertyName("list_components")]
        public List<ResponseComponent> ListComponents { get; set; }

        [JsonPropertyName("advancesearch_components")]
        public List<ResponseComponent> AdvanceSearchComponents { get; set; }

        [JsonPropertyName("grid_components")]
        public List<ResponseComponent> GridComponents { get; set; }

        [JsonPropertyName("detail_components")]
        public List<ResponseComponent> DetailComponents { get; set; }
    }
}
