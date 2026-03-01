using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Grid
{
    public class ResponseRow
    {
        [JsonPropertyName("row_no")]
        public long RowNo { get; set; }
        [JsonPropertyName("row_data")]
        public List<ResponseCell> Cells { get; set; }
    }
}
