using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Grid
{
    public class ResponseCell
    {
        [JsonPropertyName("cell_no")]
        public int CellNo { get; set; }

        [JsonPropertyName("cell_internal_code")]
        public string CellInternalCode { get; set; }

        [JsonPropertyName("cell_value")]
        public string CellValue { get; set; }

        //[JsonPropertyName("cell_group_no")]
        //public int? CellGroupNo { get; set; }

        //[JsonPropertyName("cell_method_code")]
        //public string CellMethodCode { get; set; }

        //[JsonPropertyName("cell_is_mask")]
        //public int CellIsMask { get; set; }

        //[JsonPropertyName("cell_is_enable")]
        //public int CellIsEnable { get; set; }

        //[JsonPropertyName("cell_is_read_only")]
        //public int CellIsReadOnly { get; set; }
    }
}
