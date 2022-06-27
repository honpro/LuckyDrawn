using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface ICustomerTypeRepository
    {
        List<CustomerPypeDTO> GetAll();
        CustomerPypeDTO GetById(int CustomerTypeID);
        bool Insert(CustomerPypeDTO CustomerTypeDTO);
        bool Update(CustomerPypeDTO CustomerTypeDTO);
        bool Delete(int CustomerTypeID);
        void Save();
    }
}
