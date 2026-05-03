using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace d01ApiV2.Model.Profile
{
    public class ProfileData
    {
        [JsonPropertyName("display_order_no")]
        public int DisplayOrderNo { get; set; }

        [JsonPropertyName("info_id")]
        public string InfoId { get; set; }

        [JsonPropertyName("info_template_id")]
        public string TemplateId { get; set; }

        [JsonPropertyName("internal_code")]
        public string InternalCode { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
