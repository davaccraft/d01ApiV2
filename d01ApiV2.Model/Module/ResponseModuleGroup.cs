using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Module
{
    public class ResponseModuleGroup
    {
        [JsonPropertyName("module_group_no")]
        public int ModuleGroupNo { get; set; }
        [JsonPropertyName("module_group_code")]
        public string ModuleGroupCode { get; set; }

        [JsonPropertyName("module_group_caption")]
        public string ModuleGroupCaption { get; set; }

        [JsonPropertyName("module_group_icon")]
        public string ModuleGroupIcon { get; set; }

        [JsonPropertyName("module_group_modules")]
        public List<ResponseModule> ModuleGroupModules { get; set; }
    }
}
