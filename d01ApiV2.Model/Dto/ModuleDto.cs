namespace d01ApiV2.Model.Dto
{
    public class ModuleDto
    {
        public int GroupOrderNo { get; set; }
        public string GroupCode { get; set; }
        public string GroupCaption { get; set; }
        public string GroupDescription { get; set; }
        public string GroupIcon { get; set; }

        public int ModuleOrderNo { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleCaption { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleIcon { get; set; }
        public int ModuleIsEnabled { get; set; }
        public int ModuleIsReadOnly { get; set; }
    }
}
