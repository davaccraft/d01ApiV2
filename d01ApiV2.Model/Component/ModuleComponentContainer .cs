using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ModuleComponentContainer
    {
        [JsonPropertyName("modules")]
        public List<ModuleGroupComponent> Modules { get; set; }
    }
}
