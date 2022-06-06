namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("TypeCode")]
    public class TypeCode
    {
        
        public TypeCode()
        {
            ProgramSizes = new HashSet<ProgramSize>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeCodeID { get; set; }

        [StringLength(255)]
        public string TypeCodeName { get; set; }

        
        public ICollection<ProgramSize> ProgramSizes { get; set; }
    }
}
