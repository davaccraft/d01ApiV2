using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ResponseMenuGroup
    {
        /// <summary>
        /// ModuleTypeOrderNo
        /// </summary>
        [JsonPropertyName("menu_group_no")]
        public int MenuGroupNo { get; set; }


        /// <summary>
        /// ModuleTypeCode
        /// </summary>
        [JsonPropertyName("menu_group_code")]
        public string MenuGroupCode { get; set; }

        /// <summary>
        /// ModuleTypeCaption
        /// </summary>
        [JsonPropertyName("menu_group_caption")]
        public string MenuGroupCaption { get; set; }

        /// <summary>
        /// ModuleTypeDescription
        /// </summary>
        /// public string ????? { get; set; } 


        /// <summary>
        /// ModuleTypeIcon
        /// </summary>
        [JsonPropertyName("menu_group_icon")]
        public string MenuGroupIcon { get; set; } 

        [JsonPropertyName("menu_group_modules")]
        public List<ResponseMenu> MenuGroupModules { get; set; }
    }
}
