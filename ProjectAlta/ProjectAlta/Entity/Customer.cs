namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Customer")]
    public  class Customer
    {
        
        public Customer()
        {
            BarcodesUsageHistories = new HashSet<BarcodesUsageHistory>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(11)]
        public string CustomerPhone { get; set; }

        public DateTime? CustomerBirth { get; set; }

        public int? CustomerPosition { get; set; }

        [StringLength(255)]
        public string CustomerLocaltion { get; set; }

        public bool? CustomerStatus { get; set; }

        public int? CustomerTypeofBussinessID { get; set; }

        [StringLength(255)]
        public string CustomerTypeofBussinessName { get; set; }

        public int? UserID { get; set; }

        public bool? Block { get; set; }

        public virtual Account Account { get; set; }

        
        public  ICollection<BarcodesUsageHistory> BarcodesUsageHistories { get; set; }

        public  CustomerTypeofBussiness CustomerTypeofBussiness { get; set; }
    }
}
