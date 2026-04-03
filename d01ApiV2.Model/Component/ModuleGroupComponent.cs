using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ModuleGroupComponent
    {
        /// <summary>
        /// GroupOrderNo
        /// </summary>
        [JsonPropertyName("group_order_no")]
        public int GroupOrderNo { get; set; }


        /// <summary>
        /// GroupCode
        /// </summary>
        [JsonPropertyName("group_code")]
        public string GroupCode { get; set; }

        /// <summary>
        /// GroupCaption
        /// </summary>
        [JsonPropertyName("group_caption")]
        public string GroupCaption { get; set; }

        /// <summary>
        /// GroupDescription
        /// </summary>
        /// public string ????? { get; set; } 


        /// <summary>
        /// GroupIcon
        /// </summary>
        [JsonPropertyName("group_icon")]
        public string GroupIcon { get; set; }

        [JsonPropertyName("modules")]
        public List<ModuleComponent> Modules { get; set; }
    }
}
