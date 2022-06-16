using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iCustomerTypeRepository
    {
        IEnumerable<CustomerType> GetAll();
        CustomerType GetById(int CustomerTypeID);
        void Insert(CustomerType CustomerType);
        void Update(CustomerType CustomerType);
        void Delete(int CustomerTypeID);
        void Save();
    }
}
