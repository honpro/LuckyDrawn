namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("TypeBarcode")]
    public  class TypeBarcode
    {
        
        public TypeBarcode()
        {
            Barcodes = new HashSet<Barcode>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeBarcodeID { get; set; }

        [StringLength(255)]
        public string TypeBarcodeName { get; set; }

        
        public  ICollection<Barcode> Barcodes { get; set; }
    }
}
