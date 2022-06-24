namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("CharsetBarcode")]
    public class CharsetBarcode
    {
        
        public CharsetBarcode()
        {
            Barcodes = new HashSet<Barcode>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharsetBarcodeID { get; set; }

        [StringLength(255)]
        public string CharsetBarcodeName { get; set; }

        
        public ICollection<Barcode> Barcodes { get; set; }
    }
}
