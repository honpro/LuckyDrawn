namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Barcode")]
    public  class Barcode
    {
        
        public Barcode()
        {
            BarcodesUsageHistories = new HashSet<BarcodesUsageHistory>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BarcodeID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? CodeLeght { get; set; }

        [StringLength(255)]
        public string CharsetBarcodeName { get; set; }

        [StringLength(255)]
        public string TypeBarcodeName { get; set; }

        public int? CharsetBarcodeID { get; set; }

        public int? TypeBarcodeID { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        [StringLength(50)]
        public string Profix { get; set; }

        public int? CountCode { get; set; }

        public int? CodeDetailID { get; set; }

        public  CharsetBarcode CharsetBarcode { get; set; }

        public  CodeDetail CodeDetail { get; set; }

        public  TypeBarcode TypeBarcode { get; set; }

       
        public  ICollection<BarcodesUsageHistory> BarcodesUsageHistories { get; set; }
    }
}
