namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("ProgramSize")]
    public partial class ProgramSize
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProgramSizeID { get; set; }

        [StringLength(255)]
        public string ProgramName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? CodeLegth { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        [StringLength(50)]
        public string Profix { get; set; }

        public int? CharsetTypeID { get; set; }

        [StringLength(255)]
        public string Charset { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? TypeCodeID { get; set; }

        [StringLength(255)]
        public string TypeCodeName { get; set; }

        public int? CountCode { get; set; }

        public  CharsetType CharsetType { get; set; }

        public  TypeCode TypeCode { get; set; }
    }
}
