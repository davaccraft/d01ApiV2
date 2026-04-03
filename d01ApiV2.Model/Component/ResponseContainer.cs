using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ResponseContainer
    {
        //[JsonPropertyName("components")]
        //public List<ResponseComponent> Components { get; set; }

        [JsonPropertyName("modules")]
        public List<ResponseModule> Modules { get; set; }
    }
}
