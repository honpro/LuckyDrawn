namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("CustomerTypeofBussiness")]
    public  class CustomerTypeofBussiness
    {
        
        public CustomerTypeofBussiness()
        {
            Customers = new HashSet<Customer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerTypeofBussinessID { get; set; }

        [StringLength(255)]
        public string CustomerTypeofBussinessName { get; set; }

        
        public  ICollection<Customer> Customers { get; set; }
    }
}
