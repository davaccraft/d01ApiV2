using d01ApiV2.Model.Dto;
using System.Xml.Linq;

namespace d01ApiV2.Model.Profile
{
    public class ProfileSaveDto : ResultDto
    {
        public string InternalCode { get; set; }
        public string Value { get; set; }
    }
}
