namespace ProjectAlta.DTO
{
    public class CodeDetailDTO
    {
        public int CodeDetailID { get; set; }
        public int? BarcodeID { get; set; }
        public int? UsageLimit { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string ProgramName { get; set; }
    }
}
