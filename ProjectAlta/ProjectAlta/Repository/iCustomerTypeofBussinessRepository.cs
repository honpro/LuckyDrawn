using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface ICustomerTypeofBussinessRepository
    {
        List<CustomerTypeofBussinessDTO> GetAll();
        CustomerTypeofBussinessDTO GetById(int CustomerTypeofBussinessID);
        bool Insert(CustomerTypeofBussinessDTO CustomerTypeofBussinessDTO);
        bool Update(CustomerTypeofBussinessDTO CustomerTypeofBussinessDTO);
        bool Delete(int CustomerTypeofBussinessID);
        void Save();
    }
}
