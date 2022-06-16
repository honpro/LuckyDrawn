using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iCustomerTypeofBussinessRepository
    {
        IEnumerable<CustomerTypeofBussiness> GetAll();
        CustomerTypeofBussiness GetById(int CustomerTypeofBussinessID);
        void Insert(CustomerTypeofBussiness CustomerTypeofBussiness);
        void Update(CustomerTypeofBussiness CustomerTypeofBussiness);
        void Delete(int CustomerTypeofBussinessID);
        void Save();
    }
}
