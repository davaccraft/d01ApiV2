using System.Text.Json.Serialization;

namespace d01ApiV2.Model
{
    public class ApiResponse<T>
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("result_code")]
        public string ReturnCode { get; set; }
        [JsonPropertyName("result_message")]
        public string ReturnMessage { get; set; }
    }
}
