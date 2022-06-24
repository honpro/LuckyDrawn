namespace ProjectAlta.DTO
{
    public class BarcodeDTO
    {
        public int BarcodeID { get; set; }
        public string Code { get; set; }

        public int? CodeLeght { get; set; }
        public string CharsetBarcodeName { get; set; }
        public string TypeBarcodeName { get; set; }
        public int? CharsetBarcodeID { get; set; }
        public int? TypeBarcodeID { get; set; }
        public string Prefix { get; set; }
        public string Profix { get; set; }
        public int? CountCode { get; set; }
        public int? CodeDetailID { get; set; }

    }
}
