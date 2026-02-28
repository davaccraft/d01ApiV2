using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class ReponseDataComponent
    {
        [JsonPropertyName("components")]
        public List<ResponseComponent> Components { get; set; }
    }
}
