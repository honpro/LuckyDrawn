namespace ProjectAlta.DTO
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime? CustomerBirth { get; set; }
        public int? CustomerPosition { get; set; }
        public string CustomerLocaltion { get; set; }
        public bool? CustomerStatus { get; set; }
        public int? CustomerTypeofBussinessID { get; set; }
        public string CustomerTypeofBussinessName { get; set; }
        public int? UserID { get; set; }
        public bool? Block { get; set; }
    }
}
