using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iCustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int CustomerID);
        void Insert(Customer Customer);
        void Update(Customer Customer);
        void Delete(int CustomerID);
        void Save();
    }
}
