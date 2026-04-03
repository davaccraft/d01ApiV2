using d01ApiV2.Model.Dto;
using System.Globalization;
using System.Text.Json.Serialization;

namespace d01ApiV2.Model.Component
{
    public class GridGroupComponent
    {
        //public string GridPage{ get; set; }
        public int GridOrderNo { get; set; }
        public List<ComponentGrid> Components { get; set; }

    }
}
