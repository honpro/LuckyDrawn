namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("CustomerType")]
    public class CustomerType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerPypeID { get; set; }

        [StringLength(255)]
        public string CustomerPypeName { get; set; }
    }
}
