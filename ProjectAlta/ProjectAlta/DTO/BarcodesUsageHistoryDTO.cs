namespace ProjectAlta.DTO
{
    public class BarcodesUsageHistoryDTO
    {
        public int BarcodesUsageHistoryID { get; set; }
        public int? CustomerID { get; set; }
        public string CustomerName { get; set; }
        public bool? Scaned { get; set; }
        public DateTime? ScannedDate { get; set; }
        public int? BarcodeID { get; set; }
        public string Code { get; set; }
        public DateTime? SpinDate { get; set; }
        public bool? UsedForSpin { get; set; }
    }
}
