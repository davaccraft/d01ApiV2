using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Module
{
    public class ResponseModule
    {
        [JsonPropertyName("order_no")]
        public int OrderNo { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("caption")]
        public string Caption { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("is_enabled")]
        public int IsEnabled { get; set; }

        [JsonPropertyName("is_read_only")]
        public int IsReadOnly { get; set; }
    }
}
