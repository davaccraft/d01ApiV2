using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace d01ApiV2.Model.Profile
{
    public class ProfileSaveData
    {   
        [JsonPropertyName("internal_code")]
        public string InternalCode { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
