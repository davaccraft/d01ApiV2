namespace d01ApiV2.Model.Grid
{
    public class DbReturnColumnHeader
    {
        public string InternalCode { get; set; }
        public string ColumnGroup { get; set; }
        public string Caption { get; set; }
        public int DisplayOrderNo { get; set; }
        public string DataType { get; set; }
        public string DataFormat { get; set; }
        public string ComponentType { get; set; }
        public string MethodCode { get; set; }
        public bool IsVisible { get; set; }
        public bool IsAllowSort { get; set; }
        public bool IsAscending { get; set; }
    }
}
