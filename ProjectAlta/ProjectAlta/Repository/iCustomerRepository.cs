using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface ICustomerRepository
    {
        List<CustomerDTO> GetAll();
        CustomerDTO GetById(int CustomerID);
        bool Insert(CustomerDTO CustomerDTO);
        bool Update(CustomerDTO CustomerDTO);
        bool Delete(int CustomerID);
        void Save();
    }
}
