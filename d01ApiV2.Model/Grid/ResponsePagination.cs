using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Grid
{
    public class ResponsePagination
    {
        [JsonPropertyName("currrent_page_no")]
        public long CurrentPageNo { get; set; }
        [JsonPropertyName("currrent_page_size")]
        public long CurrentPageSize { get; set; }
        [JsonPropertyName("record_count")]
        public long RecordCount { get; set; }
    }
}
