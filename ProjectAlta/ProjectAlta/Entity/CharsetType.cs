namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("CharsetType")]
    public class CharsetType
    {
        
        public CharsetType()
        {
            ProgramSizes = new HashSet<ProgramSize>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharsetTypeID { get; set; }

        [StringLength(255)]
        public string Charset { get; set; }

        
        public  ICollection<ProgramSize> ProgramSizes { get; set; }
    }
}
