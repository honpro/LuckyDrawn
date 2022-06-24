namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    [Table("CodeDetail")]
    public partial class CodeDetail
    {
        
        public CodeDetail()
        {
            Barcodes = new HashSet<Barcode>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodeDetailID { get; set; }

        public int? BarcodeID { get; set; }

        public int? UsageLimit { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        [StringLength(255)]
        public string ProgramName { get; set; }

        
        public  ICollection<Barcode> Barcodes { get; set; }
    }
}
