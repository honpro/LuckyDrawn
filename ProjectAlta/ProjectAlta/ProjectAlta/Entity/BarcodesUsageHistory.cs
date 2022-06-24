namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("BarcodesUsageHistory")]
    public class BarcodesUsageHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BarcodesUsageHistoryID { get; set; }

        public int? CustomerID { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        public bool? Scaned { get; set; }

        public DateTime? ScannedDate { get; set; }

        public int? BarcodeID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public DateTime? SpinDate { get; set; }

        public bool? UsedForSpin { get; set; }

        public  Barcode Barcode { get; set; }

        public  Customer Customer { get; set; }
    }
}
