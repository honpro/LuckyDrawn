using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public CustomerRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public bool Delete(int CustomerID)
        {
            var DeleteCus = addContext.Customers.Find(CustomerID);
            if (DeleteCus == null)
            {
                return false;
            }
            addContext.Remove(DeleteCus);
            return true;
        }

        public List<CustomerDTO> GetAll()
        {
            var allCus = addContext.Customers.ToList();
            return admap.Map<List<CustomerDTO>>(allCus);
        }

        public CustomerDTO GetById(int CustomerID)
        {
            var byid = addContext.Customers.Find(CustomerID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<CustomerDTO>(byid);
        }

        public bool Insert(CustomerDTO CustomerDTO)
        {
            var insertCus = addContext.Customers.Find(CustomerDTO.CustomerID);
            if (insertCus == null)
            {
                addContext.Customers.Add(admap.Map<Customer>(CustomerDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public bool Update(CustomerDTO CustomerDTO)
        {
            var updateCus = addContext.Customers.Find(CustomerDTO.CustomerID);
            if (updateCus != null)
            {
                addContext.Customers.Update(admap.Map(CustomerDTO, updateCus));
                return true;
            }
            return false;
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    addContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }
}
