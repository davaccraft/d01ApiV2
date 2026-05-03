using System.Xml.Linq;

namespace d01ApiV2.Model.Profile
{
    public class ProfileDto
    {
        public int DisplayOrderNo { get; set; }
        public string InfoId { get; set; }
        public string TemplateId { get; set; }
        public string InternalCode { get; set; }
        public string Value { get; set; }
    }
}
