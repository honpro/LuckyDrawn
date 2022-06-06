namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Account")]
    public class Account
    {
        
        public Account()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Gmail { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        public bool? Status { get; set; }

        
        public  ICollection<Customer> Customers { get; set; }
    }
}
