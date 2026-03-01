using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ResponseDataComponents
    {
        [JsonPropertyName("components")]
        public List<ResponseComponent> Components { get; set; }
    }
}
