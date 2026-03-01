using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Grid
{
    public class ResponseDataGrid
    {
        [JsonPropertyName("column_headers")]
        public List<ResponseColumnHeader> ColumnHeaders { get; set; }

        [JsonPropertyName("row_data_list")]
        public List<ResponseRow> RowList { get; set; }

        [JsonPropertyName("pagination_info")]
        public ResponsePagination PaginationInfo { get; set; }
    }
}
