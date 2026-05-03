using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Profile
{
    public class DetailPageData
    {
        [JsonPropertyName("detail_page_datas")]
        public List<ProfileData> Details { get; set; }
    }
}
